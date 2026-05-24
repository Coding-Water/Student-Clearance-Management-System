using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class RecycleBinForm : Form
    {
        public RecycleBinForm()
        {
            // Only Admin can access this form
            string role = AppSession.LoggedInRole?.Trim().ToLower() ?? "";
            if (role != "admin")
            {
                MessageBox.Show(
                    "Access Denied: Only administrators can access the Recycle Bin.",
                    "Unauthorized Access",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Form will close immediately on load
                this.Load += (s, e) => this.Close();
                return;
            }

            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        private void RecycleBinForm_Load(object sender, EventArgs e)
        {
            cboRecordType.Items.Clear();
            cboRecordType.Items.Add("Students");
            cboRecordType.Items.Add("Courses");
            cboRecordType.Items.Add("Departments");
            cboRecordType.Items.Add("Academic Terms");
            cboRecordType.SelectedIndex = 0;

            LoadDeletedRecords();
            LoadActivityLogs();
        }

        private void cboRecordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeletedRecords();
        }

        private void LoadDeletedRecords()
        {
            if (cboRecordType.SelectedItem == null) return;

            string selectedType = cboRecordType.SelectedItem.ToString();
            string query = "";

            switch (selectedType)
            {
                case "Students":
                    query = @"SELECT 
                                s.StudentID,
                                s.FirstName,
                                s.LastName,
                                c.CourseCode,
                                s.YearLevel,
                                s.Section,
                                s.ContactNumber
                             FROM Students s
                             LEFT JOIN Courses c ON s.CourseID = c.CourseID
                             WHERE s.IsDeleted = 1";
                    break;
                case "Courses":
                    query = @"SELECT 
                                CourseID,
                                CourseCode,
                                CourseName
                             FROM Courses
                             WHERE IsDeleted = 1";
                    break;
                case "Departments":
                    query = @"SELECT 
                                DepartmentID,
                                DepartmentName
                             FROM Departments
                             WHERE IsDeleted = 1";
                    break;
                case "Academic Terms":
                    query = @"SELECT 
                                TermID,
                                SchoolYear,
                                Semester,
                                IsActive
                             FROM AcademicTerms
                             WHERE IsDeleted = 1";
                    break;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDeletedRecords.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading deleted records: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadActivityLogs()
        {
            string query = @"SELECT 
                                LogID,
                                RecordType AS [Record Type],
                                RecordID AS [Record ID],
                                RecordDetails AS [Details],
                                ActionType AS [Action],
                                ActionDate AS [Date & Time],
                                PerformedBy AS [User]
                             FROM RecycleBinLogs
                             ORDER BY LogID DESC";

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading activity logs: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to restore.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string selectedType = cboRecordType.SelectedItem.ToString();
            DataGridViewRow row = dgvDeletedRecords.SelectedRows[0];
            string recordId = "";
            string displayDetails = "";

            // Identify IDs and details depending on record type
            switch (selectedType)
            {
                case "Students":
                    recordId = row.Cells["StudentID"].Value.ToString();
                    displayDetails = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                    break;
                case "Courses":
                    recordId = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString() + " - " + row.Cells["CourseName"].Value.ToString();
                    break;
                case "Departments":
                    recordId = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    recordId = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to restore the {selectedType.ToLower().TrimEnd('s')} '{displayDetails}'?",
                "Confirm Restoration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            DBConnection db = new DBConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        if (selectedType == "Students")
                        {
                            // 1. Data-Integrity Check: Check if Course is deleted
                            SqlCommand checkCourseCmd = new SqlCommand(
                                @"SELECT c.CourseCode, c.IsDeleted 
                                  FROM Students s 
                                  INNER JOIN Courses c ON s.CourseID = c.CourseID 
                                  WHERE s.StudentID = @studentId",
                                conn,
                                transaction);
                            checkCourseCmd.Parameters.AddWithValue("@studentId", recordId);
                            
                            string courseCode = "";
                            bool isCourseDeleted = false;

                            using (SqlDataReader reader = checkCourseCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    courseCode = reader["CourseCode"].ToString();
                                    isCourseDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                                }
                            }

                            if (isCourseDeleted)
                            {
                                throw new InvalidOperationException(
                                    $"Cannot restore student because their course '{courseCode}' is deleted. " +
                                    "Please restore the course first.");
                            }

                            // 2. Update Student IsDeleted
                            SqlCommand restoreStudentCmd = new SqlCommand(
                                "UPDATE Students SET IsDeleted = 0 WHERE StudentID = @id", 
                                conn, 
                                transaction);
                            restoreStudentCmd.Parameters.AddWithValue("@id", recordId);
                            restoreStudentCmd.ExecuteNonQuery();

                            // 3. Update Clearance Records IsDeleted
                            SqlCommand restoreClearanceCmd = new SqlCommand(
                                "UPDATE ClearanceRecords SET IsDeleted = 0 WHERE StudentID = @id", 
                                conn, 
                                transaction);
                            restoreClearanceCmd.Parameters.AddWithValue("@id", recordId);
                            restoreClearanceCmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            // 1. Restore Course IsDeleted
                            SqlCommand restoreCourseCmd = new SqlCommand(
                                "UPDATE Courses SET IsDeleted = 0 WHERE CourseID = @id", 
                                conn, 
                                transaction);
                            restoreCourseCmd.Parameters.AddWithValue("@id", recordId);
                            restoreCourseCmd.ExecuteNonQuery();

                            // 2. Restore Course Department Requirements
                            SqlCommand restoreReqsCmd = new SqlCommand(
                                "UPDATE CourseDepartmentRequirements SET IsDeleted = 0 WHERE CourseID = @id", 
                                conn, 
                                transaction);
                            restoreReqsCmd.Parameters.AddWithValue("@id", recordId);
                            restoreReqsCmd.ExecuteNonQuery();

                            // 3. Restore Students belonging to Course
                            SqlCommand restoreStudentsCmd = new SqlCommand(
                                "UPDATE Students SET IsDeleted = 0 WHERE CourseID = @id", 
                                conn, 
                                transaction);
                            restoreStudentsCmd.Parameters.AddWithValue("@id", recordId);
                            restoreStudentsCmd.ExecuteNonQuery();

                            // 4. Restore Clearance Records belonging to those Students
                            SqlCommand restoreClearanceCmd = new SqlCommand(
                                @"UPDATE ClearanceRecords 
                                  SET IsDeleted = 0 
                                  WHERE StudentID IN (SELECT StudentID FROM Students WHERE CourseID = @id)", 
                                conn, 
                                transaction);
                            restoreClearanceCmd.Parameters.AddWithValue("@id", recordId);
                            restoreClearanceCmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            // 1. Restore Department
                            SqlCommand restoreDeptCmd = new SqlCommand(
                                "UPDATE Departments SET IsDeleted = 0 WHERE DepartmentID = @id", 
                                conn, 
                                transaction);
                            restoreDeptCmd.Parameters.AddWithValue("@id", recordId);
                            restoreDeptCmd.ExecuteNonQuery();

                            // 2. Restore Clearance Records of Department
                            SqlCommand restoreClearanceCmd = new SqlCommand(
                                "UPDATE ClearanceRecords SET IsDeleted = 0 WHERE DepartmentID = @id", 
                                conn, 
                                transaction);
                            restoreClearanceCmd.Parameters.AddWithValue("@id", recordId);
                            restoreClearanceCmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            // 1. Restore Term
                            SqlCommand restoreTermCmd = new SqlCommand(
                                "UPDATE AcademicTerms SET IsDeleted = 0 WHERE TermID = @id", 
                                conn, 
                                transaction);
                            restoreTermCmd.Parameters.AddWithValue("@id", recordId);
                            restoreTermCmd.ExecuteNonQuery();

                            // 2. Restore Clearance Records of Term
                            SqlCommand restoreClearanceCmd = new SqlCommand(
                                "UPDATE ClearanceRecords SET IsDeleted = 0 WHERE TermID = @id", 
                                conn, 
                                transaction);
                            restoreClearanceCmd.Parameters.AddWithValue("@id", recordId);
                            restoreClearanceCmd.ExecuteNonQuery();
                        }

                        // Log Restoration to Audit trail
                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy)
                              VALUES (@recordType, @recordId, @details, 'Restore', GETDATE(), @username)",
                            conn,
                            transaction);
                        logCmd.Parameters.AddWithValue("@recordType", selectedType.TrimEnd('s'));
                        logCmd.Parameters.AddWithValue("@recordId", recordId);
                        logCmd.Parameters.AddWithValue("@details", displayDetails + $" (ID: {recordId})");
                        logCmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            $"{selectedType.TrimEnd('s')} '{displayDetails}' restored successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadDeletedRecords();
                        LoadActivityLogs();
                    }
                    catch (InvalidOperationException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Integrity Check Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Restoration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeletePermanently_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete permanently.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string selectedType = cboRecordType.SelectedItem.ToString();
            DataGridViewRow row = dgvDeletedRecords.SelectedRows[0];
            string recordId = "";
            string displayDetails = "";

            switch (selectedType)
            {
                case "Students":
                    recordId = row.Cells["StudentID"].Value.ToString();
                    displayDetails = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                    break;
                case "Courses":
                    recordId = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString() + " - " + row.Cells["CourseName"].Value.ToString();
                    break;
                case "Departments":
                    recordId = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    recordId = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show(
                $"WARNING: Are you sure you want to PERMANENTLY delete the {selectedType.ToLower().TrimEnd('s')} '{displayDetails}'?\n\nThis action is IRREVERSIBLE and will cascade delete all related clearances, requirements, and user profiles.",
                "Confirm Permanent Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            DBConnection db = new DBConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        if (selectedType == "Students")
                        {
                            // 1. Cascade delete clearance records
                            SqlCommand deleteClearances = new SqlCommand(
                                "DELETE FROM ClearanceRecords WHERE StudentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            // 2. Cascade delete student user profile
                            SqlCommand deleteUser = new SqlCommand(
                                "DELETE FROM Users WHERE Username = @id", conn, transaction);
                            deleteUser.Parameters.AddWithValue("@id", recordId);
                            deleteUser.ExecuteNonQuery();

                            // 3. Delete student record
                            SqlCommand deleteStudent = new SqlCommand(
                                "DELETE FROM Students WHERE StudentID = @id", conn, transaction);
                            deleteStudent.Parameters.AddWithValue("@id", recordId);
                            deleteStudent.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            // 1. Cascade delete clearance records of students of this course
                            SqlCommand deleteClearances = new SqlCommand(
                                @"DELETE FROM ClearanceRecords 
                                  WHERE StudentID IN (SELECT StudentID FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            // 2. Delete user records for students of this course
                            SqlCommand deleteUsers = new SqlCommand(
                                @"DELETE FROM Users 
                                  WHERE Username IN (SELECT CAST(StudentID AS VARCHAR) FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteUsers.Parameters.AddWithValue("@id", recordId);
                            deleteUsers.ExecuteNonQuery();

                            // 3. Cascade delete students
                            SqlCommand deleteStudents = new SqlCommand(
                                "DELETE FROM Students WHERE CourseID = @id", conn, transaction);
                            deleteStudents.Parameters.AddWithValue("@id", recordId);
                            deleteStudents.ExecuteNonQuery();

                            // 4. Cascade delete requirements
                            SqlCommand deleteReqs = new SqlCommand(
                                "DELETE FROM CourseDepartmentRequirements WHERE CourseID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            // 5. Delete course
                            SqlCommand deleteCourse = new SqlCommand(
                                "DELETE FROM Courses WHERE CourseID = @id", conn, transaction);
                            deleteCourse.Parameters.AddWithValue("@id", recordId);
                            deleteCourse.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            // 1. Cascade delete clearances
                            SqlCommand deleteClearances = new SqlCommand(
                                "DELETE FROM ClearanceRecords WHERE DepartmentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            // 2. Cascade delete requirements
                            SqlCommand deleteReqs = new SqlCommand(
                                "DELETE FROM CourseDepartmentRequirements WHERE DepartmentID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            // 3. Delete department
                            SqlCommand deleteDept = new SqlCommand(
                                "DELETE FROM Departments WHERE DepartmentID = @id", conn, transaction);
                            deleteDept.Parameters.AddWithValue("@id", recordId);
                            deleteDept.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            // 1. Cascade delete clearances
                            SqlCommand deleteClearances = new SqlCommand(
                                "DELETE FROM ClearanceRecords WHERE TermID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            // 2. Delete term
                            SqlCommand deleteTerm = new SqlCommand(
                                "DELETE FROM AcademicTerms WHERE TermID = @id", conn, transaction);
                            deleteTerm.Parameters.AddWithValue("@id", recordId);
                            deleteTerm.ExecuteNonQuery();
                        }

                        // Log Purge to Audit Trail
                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy)
                              VALUES (@recordType, @recordId, @details, 'Purge', GETDATE(), @username)",
                            conn,
                            transaction);
                        logCmd.Parameters.AddWithValue("@recordType", selectedType.TrimEnd('s'));
                        logCmd.Parameters.AddWithValue("@recordId", recordId);
                        logCmd.Parameters.AddWithValue("@details", displayDetails + $" (ID: {recordId})");
                        logCmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            $"{selectedType.TrimEnd('s')} '{displayDetails}' purged permanently.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadDeletedRecords();
                        LoadActivityLogs();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Purge failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshLogs_Click(object sender, EventArgs e)
        {
            LoadActivityLogs();
            MessageBox.Show("Activity history logs reloaded successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

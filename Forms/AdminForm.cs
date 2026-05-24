using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class AdminForm : Form
    {
        private int selectedUserID = 0;

        public AdminForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);

            // Tab 1 Load
            LoadUsers();

            // Tab 2 Setup
            cboRecordType.Items.Clear();
            cboRecordType.Items.Add("Students");
            cboRecordType.Items.Add("Courses");
            cboRecordType.Items.Add("Departments");
            cboRecordType.Items.Add("Academic Terms");
            cboRecordType.SelectedIndex = 0;
            LoadDeletedRecords();
            LoadActivityLogs();

            // Tab 3 Setup
            cboMasterTables.Items.Clear();
            cboMasterTables.Items.Add("Students");
            cboMasterTables.Items.Add("Courses");
            cboMasterTables.Items.Add("Departments");
            cboMasterTables.Items.Add("Academic Terms");
            cboMasterTables.Items.Add("Clearance Records");
            cboMasterTables.Items.Add("Course Requirements");
            cboMasterTables.SelectedIndex = 0;
            LoadMasterRecords();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ================== TAB 1 LOGIC ==================
        private void LoadUsers()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT UserID, Username, Password, Role FROM Users WHERE IsDeleted = 0 ORDER BY UserID DESC";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
                if (dgvUsers.Columns["UserID"] != null) dgvUsers.Columns["UserID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all user fields.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Check duplicate
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
                    check.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role, IsDeleted) VALUES (@username, @password, @role, 0)", conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all user fields.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Check username availability
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND UserID != @userID", conn);
                    check.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    check.Parameters.AddWithValue("@userID", selectedUserID);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Username already taken.");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Username = @username, Password = @password, Role = @role WHERE UserID = @userID", conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user login profile?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET IsDeleted = 1 WHERE UserID = @userID", conn);
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            ClearUserFields();
        }

        private void ClearUserFields()
        {
            selectedUserID = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
            txtUsername.Focus();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cboRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }


        // ================== TAB 2 LOGIC ==================
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
                    query = @"SELECT s.StudentID, s.FirstName, s.LastName, c.CourseCode, s.YearLevel, s.Section, s.ContactNumber
                             FROM Students s LEFT JOIN Courses c ON s.CourseID = c.CourseID WHERE s.IsDeleted = 1";
                    break;
                case "Courses":
                    query = "SELECT CourseID, CourseCode, CourseName FROM Courses WHERE IsDeleted = 1";
                    break;
                case "Departments":
                    query = "SELECT DepartmentID, DepartmentName FROM Departments WHERE IsDeleted = 1";
                    break;
                case "Academic Terms":
                    query = "SELECT TermID, SchoolYear, Semester, IsActive FROM AcademicTerms WHERE IsDeleted = 1";
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
                foreach (DataGridViewColumn col in dgvDeletedRecords.Columns)
                {
                    if (col.Name.EndsWith("ID") && col.Name != "StudentID") col.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading deleted records: " + ex.Message);
            }
        }

        private void LoadActivityLogs()
        {
            string query = "SELECT LogID, RecordType AS [Record Type], RecordID AS [Record ID], RecordDetails AS [Details], ActionType AS [Action], ActionDate AS [Date], PerformedBy AS [Performed By] FROM RecycleBinLogs ORDER BY LogID DESC";
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
                if (dgvHistory.Columns["LogID"] != null) dgvHistory.Columns["LogID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to restore.");
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

            DialogResult confirm = MessageBox.Show($"Restore {selectedType.ToLower().TrimEnd('s')} '{displayDetails}'?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            // Integrity Check course
                            SqlCommand c = new SqlCommand("SELECT c.IsDeleted FROM Students s INNER JOIN Courses c ON s.CourseID = c.CourseID WHERE s.StudentID = @studentID", conn, transaction);
                            c.Parameters.AddWithValue("@studentID", recordId);
                            object val = c.ExecuteScalar();
                            if (val != null && Convert.ToBoolean(val))
                            {
                                throw new InvalidOperationException("Cannot restore student because their course is soft-deleted. Please restore the course first.");
                            }

                            SqlCommand cmd1 = new SqlCommand("UPDATE Students SET IsDeleted = 0 WHERE StudentID = @id", conn, transaction);
                            cmd1.Parameters.AddWithValue("@id", recordId);
                            cmd1.ExecuteNonQuery();

                            SqlCommand cmd2 = new SqlCommand("UPDATE ClearanceRecords SET IsDeleted = 0 WHERE StudentID = @id", conn, transaction);
                            cmd2.Parameters.AddWithValue("@id", recordId);
                            cmd2.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Courses SET IsDeleted = 0 WHERE CourseID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Departments SET IsDeleted = 0 WHERE DepartmentID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE AcademicTerms SET IsDeleted = 0 WHERE TermID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }

                        // Log activity
                        SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Restore', GETDATE(), @u)", conn, transaction);
                        log.Parameters.AddWithValue("@t", selectedType.TrimEnd('s'));
                        log.Parameters.AddWithValue("@id", recordId);
                        log.Parameters.AddWithValue("@d", displayDetails);
                        log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                        log.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record restored successfully.");
                        LoadDeletedRecords();
                        LoadActivityLogs();
                        LoadMasterRecords(); // Refresh editor
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Restore failed: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void btnDeletePermanently_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to purge.");
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

            DialogResult confirm = MessageBox.Show($"WARNING: PERMANENTLY purge '{displayDetails}'? This action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE StudentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteUser = new SqlCommand("DELETE FROM Users WHERE Username = @id", conn, transaction);
                            deleteUser.Parameters.AddWithValue("@id", recordId);
                            deleteUser.ExecuteNonQuery();

                            SqlCommand deleteStudent = new SqlCommand("DELETE FROM Students WHERE StudentID = @id", conn, transaction);
                            deleteStudent.Parameters.AddWithValue("@id", recordId);
                            deleteStudent.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE StudentID IN (SELECT StudentID FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteUsers = new SqlCommand("DELETE FROM Users WHERE Username IN (SELECT CAST(StudentID AS VARCHAR) FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteUsers.Parameters.AddWithValue("@id", recordId);
                            deleteUsers.ExecuteNonQuery();

                            SqlCommand deleteStudents = new SqlCommand("DELETE FROM Students WHERE CourseID = @id", conn, transaction);
                            deleteStudents.Parameters.AddWithValue("@id", recordId);
                            deleteStudents.ExecuteNonQuery();

                            SqlCommand deleteReqs = new SqlCommand("DELETE FROM CourseDepartmentRequirements WHERE CourseID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            SqlCommand deleteCourse = new SqlCommand("DELETE FROM Courses WHERE CourseID = @id", conn, transaction);
                            deleteCourse.Parameters.AddWithValue("@id", recordId);
                            deleteCourse.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE DepartmentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteReqs = new SqlCommand("DELETE FROM CourseDepartmentRequirements WHERE DepartmentID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            SqlCommand deleteDept = new SqlCommand("DELETE FROM Departments WHERE DepartmentID = @id", conn, transaction);
                            deleteDept.Parameters.AddWithValue("@id", recordId);
                            deleteDept.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE TermID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteTerm = new SqlCommand("DELETE FROM AcademicTerms WHERE TermID = @id", conn, transaction);
                            deleteTerm.Parameters.AddWithValue("@id", recordId);
                            deleteTerm.ExecuteNonQuery();
                        }

                        SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Purge', GETDATE(), @u)", conn, transaction);
                        log.Parameters.AddWithValue("@t", selectedType.TrimEnd('s'));
                        log.Parameters.AddWithValue("@id", recordId);
                        log.Parameters.AddWithValue("@d", displayDetails);
                        log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                        log.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record purged permanently.");
                        LoadDeletedRecords();
                        LoadActivityLogs();
                        LoadMasterRecords(); // Refresh editor
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Purge failed: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void btnRefreshLogs_Click(object sender, EventArgs e)
        {
            LoadActivityLogs();
        }


        // ================== TAB 3 LOGIC ==================
        private void cboMasterTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMasterRecords();
        }

        private void LoadMasterRecords()
        {
            if (cboMasterTables.SelectedItem == null) return;

            string table = cboMasterTables.SelectedItem.ToString();
            string query = "";

            switch (table)
            {
                case "Students":
                    query = "SELECT StudentID, FirstName, LastName, YearLevel, Section, ContactNumber FROM Students WHERE IsDeleted = 0";
                    break;
                case "Courses":
                    query = "SELECT CourseID, CourseCode, CourseName FROM Courses WHERE IsDeleted = 0";
                    break;
                case "Departments":
                    query = "SELECT DepartmentID, DepartmentName FROM Departments WHERE IsDeleted = 0";
                    break;
                case "Academic Terms":
                    query = "SELECT TermID, SchoolYear, Semester, IsActive FROM AcademicTerms WHERE IsDeleted = 0";
                    break;
                case "Clearance Records":
                    query = @"SELECT cr.ClearanceID, s.StudentID, s.FirstName + ' ' + s.LastName AS Student, d.DepartmentName AS Department, cr.Status, cr.Remarks 
                             FROM ClearanceRecords cr 
                             INNER JOIN Students s ON cr.StudentID = s.StudentID 
                             INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID 
                             WHERE cr.IsDeleted = 0 AND s.IsDeleted = 0 AND d.IsDeleted = 0";
                    break;
                case "Course Requirements":
                    query = @"SELECT cdr.RequirementID, c.CourseCode, d.DepartmentName, cdr.IsRequired 
                             FROM CourseDepartmentRequirements cdr 
                             INNER JOIN Courses c ON cdr.CourseID = c.CourseID 
                             INNER JOIN Departments d ON cdr.DepartmentID = d.DepartmentID 
                             WHERE cdr.IsDeleted = 0 AND c.IsDeleted = 0 AND d.IsDeleted = 0";
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
                        dgvMasterRecords.DataSource = dt;
                    }
                }

                // Hide Database ID columns programmatically while maintaining StudentID visibility
                foreach (DataGridViewColumn col in dgvMasterRecords.Columns)
                {
                    if (col.Name.EndsWith("ID") && col.Name != "StudentID")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading master records: " + ex.Message);
            }
        }

        private void btnMasterRefresh_Click(object sender, EventArgs e)
        {
            LoadMasterRecords();
            MessageBox.Show("Table records reloaded successfully.");
        }

      
        private void btnMasterDelete_Click(object sender, EventArgs e)
        {
            if (dgvMasterRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record in the table first.");
                return;
            }

            string table = cboMasterTables.SelectedItem.ToString();
            DataGridViewRow row = dgvMasterRecords.SelectedRows[0];
            string keyName = "";
            string recordVal = "";
            string dbTable = "";
            string displayDetails = "";

            switch (table)
            {
                case "Students":
                    keyName = "StudentID";
                    dbTable = "Students";
                    recordVal = row.Cells["StudentID"].Value.ToString();
                    displayDetails = "Student ID: " + recordVal;
                    break;
                case "Courses":
                    keyName = "CourseID";
                    dbTable = "Courses";
                    recordVal = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString();
                    break;
                case "Departments":
                    keyName = "DepartmentID";
                    dbTable = "Departments";
                    recordVal = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    keyName = "TermID";
                    dbTable = "AcademicTerms";
                    recordVal = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
                case "Clearance Records":
                    keyName = "ClearanceID";
                    dbTable = "ClearanceRecords";
                    recordVal = row.Cells["ClearanceID"].Value.ToString();
                    displayDetails = "Clearance Record (Student ID: " + row.Cells["StudentID"].Value.ToString() + ")";
                    break;
                case "Course Requirements":
                    keyName = "RequirementID";
                    dbTable = "CourseDepartmentRequirements";
                    recordVal = row.Cells["RequirementID"].Value.ToString();
                    displayDetails = "Requirement for course: " + row.Cells["CourseCode"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show($"Soft-delete the selected record '{displayDetails}' and move it to Recycle Bin?", "Confirm Soft Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE {dbTable} SET IsDeleted = 1 WHERE {keyName} = @id", conn);
                    cmd.Parameters.AddWithValue("@id", recordVal);
                    cmd.ExecuteNonQuery();

                    // Log soft delete
                    SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Delete', GETDATE(), @u)", conn);
                    log.Parameters.AddWithValue("@t", table.TrimEnd('s'));
                    log.Parameters.AddWithValue("@id", recordVal);
                    log.Parameters.AddWithValue("@d", displayDetails);
                    log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                    log.ExecuteNonQuery();
                }

                MessageBox.Show("Record soft-deleted and moved to Recycle Bin.");
                LoadMasterRecords();
                LoadDeletedRecords();
                LoadActivityLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Soft delete failed: " + ex.Message);
            }
        }
    }
}

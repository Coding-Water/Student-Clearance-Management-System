using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Interfaces;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    // INHERITANCE: StudentForm inherits properties and behaviors from the base class 'Form'.
    // INTERFACE: StudentForm implements the 'ICrud' interface, forcing it to provide definitions for Add(), Update(), and Delete().
    public partial class StudentForm : Form, ICrud
    {
        public StudentForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        // METHOD INVOCATION: Invoking (calling) other methods to run their encapsulated logic.
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadYearLevels();
            LoadCourses();
            LoadStudents();

            if (AppSession.LoggedInRole.Equals("staff", StringComparison.OrdinalIgnoreCase))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // ENCAPSULATION: Helper methods are defined as 'private' to hide implementation details
        // and protect the class's internal logic from external manipulation.
        private void LoadYearLevels()
        {
            cboYearLevel.Items.Clear();

            cboYearLevel.Items.Add("1st");
            cboYearLevel.Items.Add("2nd");
            cboYearLevel.Items.Add("3rd");
            cboYearLevel.Items.Add("4th");
            cboYearLevel.Items.Add("Masteral");
            cboYearLevel.Items.Add("PhD");

            if (cboYearLevel.Items.Count > 0)
            {
                cboYearLevel.SelectedIndex = 0;
            }
        }

        private void LoadCourses()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        CourseID,
                                        CourseCode + ' - ' + CourseName AS CourseDisplay  
                                     FROM Courses
                                     WHERE IsDeleted = 0";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboCourse.DataSource = dt;
                        cboCourse.DisplayMember = "CourseDisplay";
                        cboCourse.ValueMember = "CourseID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading courses: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"SELECT 
                                        s.StudentID,
                                        s.FirstName,
                                        s.LastName,
                                        c.CourseCode,
                                        c.CourseName,
                                        s.YearLevel,
                                        s.Section,
                                        s.ContactNumber,
                                        s.CourseID
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.IsDeleted = 0
                                     AND c.IsDeleted = 0";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvStudents.DataSource = dt;

                        if (dgvStudents.Columns["CourseID"] != null)
                        {
                            dgvStudents.Columns["CourseID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // METHOD IMPLEMENTATION: Providing the concrete logic for the 'Add' method defined in the ICrud interface.
        public void Add()
        {
            if (AppSession.LoggedInRole.Equals("staff", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Staff members are not authorized to add students.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtID.Text == "" ||
                txtFirst.Text == "" ||
                txtLast.Text == "" ||
                cboCourse.SelectedValue == null ||
                cboYearLevel.SelectedItem == null ||
                txtSection.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"INSERT INTO Students
                                     (StudentID, FirstName, LastName, CourseID, YearLevel, Section, ContactNumber, IsDeleted)
                                     VALUES
                                     (@id, @first, @last, @courseID, @year, @section, @contact, 0)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@first", txtFirst.Text);
                    cmd.Parameters.AddWithValue("@last", txtLast.Text);
                    cmd.Parameters.AddWithValue("@courseID", cboCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@year", cboYearLevel.Text);
                    cmd.Parameters.AddWithValue("@section", txtSection.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding student: " + ex.Message,
                    "Add Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Update()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (txtFirst.Text == "" ||
                txtLast.Text == "" ||
                cboCourse.SelectedValue == null ||
                cboYearLevel.SelectedItem == null ||
                txtSection.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            string oldFirst = "";
            string oldLast = "";
            string oldYear = "";
            string oldSection = "";
            string oldContact = "";
            string oldCourseDisplay = "";
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand getOldCmd = new SqlCommand(
                        @"SELECT s.FirstName, s.LastName, s.YearLevel, s.Section, s.ContactNumber, c.CourseCode
                          FROM Students s
                          LEFT JOIN Courses c ON s.CourseID = c.CourseID
                          WHERE s.StudentID = @id AND s.IsDeleted = 0", conn);
                    getOldCmd.Parameters.AddWithValue("@id", txtID.Text);
                    using (SqlDataReader reader = getOldCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldFirst = reader["FirstName"]?.ToString() ?? "";
                            oldLast = reader["LastName"]?.ToString() ?? "";
                            oldYear = reader["YearLevel"]?.ToString() ?? "";
                            oldSection = reader["Section"]?.ToString() ?? "";
                            oldContact = reader["ContactNumber"]?.ToString() ?? "";
                            oldCourseDisplay = reader["CourseCode"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch {}

            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"UPDATE Students
                                     SET FirstName = @first,
                                         LastName = @last,
                                         CourseID = @courseID,
                                         YearLevel = @year,
                                         Section = @section,
                                         ContactNumber = @contact
                                     WHERE StudentID = @id
                                     AND IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@first", txtFirst.Text);
                    cmd.Parameters.AddWithValue("@last", txtLast.Text);
                    cmd.Parameters.AddWithValue("@courseID", cboCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@year", cboYearLevel.Text);
                    cmd.Parameters.AddWithValue("@section", txtSection.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                    cmd.ExecuteNonQuery();

                    // Log update action if any student details changed
                    string newFirst = txtFirst.Text.Trim();
                    string newLast = txtLast.Text.Trim();
                    string newYear = cboYearLevel.Text;
                    string newSection = txtSection.Text.Trim();
                    string newContact = txtContact.Text.Trim();
                    string newCourseDisplay = cboCourse.Text;

                    if (oldFirst != newFirst || oldLast != newLast || oldYear != newYear || 
                        oldSection != newSection || oldContact != newContact || oldCourseDisplay != newCourseDisplay)
                    {
                        string details = $"Updated Student: Name '{oldLast}, {oldFirst}' -> '{newLast}, {newFirst}', Course '{oldCourseDisplay}' -> '{newCourseDisplay}', Year '{oldYear}' -> '{newYear}', Section '{oldSection}' -> '{newSection}', Contact '{oldContact}' -> '{newContact}'";
                        string logQuery = @"INSERT INTO UpdateLogs (RecordType, RecordID, UpdateDetails, PerformedBy, UserRole, ActionDate)
                                            VALUES ('Student', @recordId, @details, @user, @role, GETDATE())";
                        SqlCommand logCmd = new SqlCommand(logQuery, conn);
                        logCmd.Parameters.AddWithValue("@recordId", txtID.Text);
                        logCmd.Parameters.AddWithValue("@details", details);
                        logCmd.Parameters.AddWithValue("@user", AppSession.LoggedInUsername);
                        logCmd.Parameters.AddWithValue("@role", AppSession.LoggedInRole);
                        logCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating student: " + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            if (AppSession.LoggedInRole.Equals("staff", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Staff members are not authorized to delete students.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtID.Text == "")
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(
                            @"UPDATE Students
                              SET IsDeleted = 1
                              WHERE StudentID = @id",
                            conn,transaction);

                        cmd1.Parameters.AddWithValue("@id", txtID.Text);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(
                            @"UPDATE ClearanceRecords
                              SET IsDeleted = 1
                              WHERE StudentID = @id",
                            conn,
                            transaction);

                        cmd2.Parameters.AddWithValue("@id", txtID.Text);
                        cmd2.ExecuteNonQuery();

                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy)
                              VALUES ('Student', @recordId, @details, 'Delete', GETDATE(), @username)",
                            conn,
                            transaction);
                        logCmd.Parameters.AddWithValue("@recordId", txtID.Text);
                        logCmd.Parameters.AddWithValue("@details", txtFirst.Text + " " + txtLast.Text + " (ID: " + txtID.Text + ")");
                        logCmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Student deleted. Related clearance records were also marked as deleted.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error deleting student: " + ex.Message,
                            "Delete Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SearchStudents()
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"SELECT 
                                        s.StudentID,
                                        s.FirstName,
                                        s.LastName,
                                        c.CourseCode,
                                        c.CourseName,
                                        s.YearLevel,
                                        s.Section,
                                        s.ContactNumber,
                                        s.CourseID
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.IsDeleted = 0
                                     AND c.IsDeleted = 0
                                     AND (
                                        CAST(s.StudentID AS VARCHAR) LIKE @search OR
                                        s.FirstName LIKE @search OR
                                        s.LastName LIKE @search OR
                                        c.CourseCode LIKE @search OR
                                        c.CourseName LIKE @search OR
                                        s.YearLevel LIKE @search OR
                                        s.Section LIKE @search OR
                                        s.ContactNumber LIKE @search
                                     )";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStudents.DataSource = dt;

                    if (dgvStudents.Columns["CourseID"] != null)
                    {
                        dgvStudents.Columns["CourseID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching students: " + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtSection.Clear();
            txtContact.Clear();
            txtSearch.Clear();

            if (cboCourse.Items.Count > 0)
            {
                cboCourse.SelectedIndex = 0;
            }

            if (cboYearLevel.Items.Count > 0)
            {
                cboYearLevel.SelectedIndex = 0;
            }

            txtID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            LoadStudents();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            LoadStudents();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadStudents();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtID.Text = row.Cells["StudentID"].Value.ToString();
                txtFirst.Text = row.Cells["FirstName"].Value.ToString();
                txtLast.Text = row.Cells["LastName"].Value.ToString();
                cboYearLevel.Text = row.Cells["YearLevel"].Value.ToString();
                txtSection.Text = row.Cells["Section"].Value.ToString();
                txtContact.Text = row.Cells["ContactNumber"].Value.ToString();

                if (row.Cells["CourseID"].Value != DBNull.Value)
                {
                    cboCourse.SelectedValue = row.Cells["CourseID"].Value;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
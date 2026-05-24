using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Interfaces;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class AcademicTermForm : Form, ICrud
    {
        public AcademicTermForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        private void AcademicTermForm_Load(object sender, EventArgs e)
        {
            LoadSemesters();
            LoadAcademicTerms();
            lblTermID.Visible = false;
            txtTermID.Visible = false;
            if (dgvAcademicTerms.Columns["TermID"] != null)
            {
                dgvAcademicTerms.Columns["TermID"].Visible = false;
            }
        }

        private void LoadSemesters()
        {
            cboSemester.Items.Clear();
            cboSemester.Items.Add("1st Semester");
            cboSemester.Items.Add("2nd Semester");
            cboSemester.Items.Add("Summer");

            if (cboSemester.Items.Count > 0)
            {
                cboSemester.SelectedIndex = 0;
            }
        }

        private void LoadAcademicTerms()
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"SELECT 
                                        TermID,
                                        SchoolYear,
                                        Semester,
                                        IsActive
                                     FROM AcademicTerms
                                     WHERE IsDeleted = 0
                                     ORDER BY TermID DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvAcademicTerms.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading academic terms: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Add()
        {
            if (txtSchoolYear.Text == "" || cboSemester.Text == "")
            {
                MessageBox.Show(
                    "Please fill all academic term fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                        if (chkIsActive.Checked)
                        {
                            SqlCommand deactivateCmd = new SqlCommand(
                                "UPDATE AcademicTerms SET IsActive = 0 WHERE IsDeleted = 0",
                                conn,
                                transaction);

                            deactivateCmd.ExecuteNonQuery();
                        }

                        string query = @"INSERT INTO AcademicTerms
                                         (SchoolYear, Semester, IsActive, IsDeleted)
                                         VALUES
                                         (@schoolYear, @semester, @isActive, 0)";

                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@schoolYear", txtSchoolYear.Text.Trim());
                        cmd.Parameters.AddWithValue("@semester", cboSemester.Text);
                        cmd.Parameters.AddWithValue("@isActive", chkIsActive.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Academic term added successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error adding academic term: " + ex.Message,
                            "Add Error",
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

        public void Update()
        {
            if (txtTermID.Text == "")
            {
                MessageBox.Show(
                    "Please select an academic term to update.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txtSchoolYear.Text == "" || cboSemester.Text == "")
            {
                MessageBox.Show(
                    "Please fill all academic term fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                        if (chkIsActive.Checked)
                        {
                            SqlCommand deactivateCmd = new SqlCommand(
                                "UPDATE AcademicTerms SET IsActive = 0 WHERE IsDeleted = 0",
                                conn,
                                transaction);

                            deactivateCmd.ExecuteNonQuery();
                        }

                        string query = @"UPDATE AcademicTerms
                                         SET SchoolYear = @schoolYear,
                                             Semester = @semester,
                                             IsActive = @isActive
                                         WHERE TermID = @termID
                                         AND IsDeleted = 0";

                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@termID", txtTermID.Text);
                        cmd.Parameters.AddWithValue("@schoolYear", txtSchoolYear.Text.Trim());
                        cmd.Parameters.AddWithValue("@semester", cboSemester.Text);
                        cmd.Parameters.AddWithValue("@isActive", chkIsActive.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Academic term updated successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error updating academic term: " + ex.Message,
                            "Update Error",
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

        public void Delete()
        {
            if (txtTermID.Text == "")
            {
                MessageBox.Show(
                    "Please select an academic term to delete.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Deleting this academic term will also mark related clearance records as deleted. Continue?",
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
                            @"UPDATE AcademicTerms
                              SET IsDeleted = 1,
                                  IsActive = 0
                              WHERE TermID = @termID",
                            conn,
                            transaction);

                        cmd1.Parameters.AddWithValue("@termID", txtTermID.Text);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(
                            @"UPDATE ClearanceRecords
                              SET IsDeleted = 1
                              WHERE TermID = @termID",
                            conn,
                            transaction);

                        cmd2.Parameters.AddWithValue("@termID", txtTermID.Text);
                        cmd2.ExecuteNonQuery();

                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy)
                              VALUES ('AcademicTerm', @recordId, @details, 'Delete', GETDATE(), @username)",
                            conn,
                            transaction);
                        logCmd.Parameters.AddWithValue("@recordId", txtTermID.Text);
                        logCmd.Parameters.AddWithValue("@details", txtSchoolYear.Text.Trim() + " - " + cboSemester.Text + " (ID: " + txtTermID.Text + ")");
                        logCmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Academic term deleted successfully. Related clearance records were also marked as deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error deleting academic term: " + ex.Message,
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

        private void SetActiveTerm()
        {
            if (txtTermID.Text == "")
            {
                MessageBox.Show(
                    "Please select an academic term to set active.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Set this academic term as active and generate clearance checklists for all active students?",
                "Set Active Term",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

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
                        SqlCommand deactivateCmd = new SqlCommand(
                            "UPDATE AcademicTerms SET IsActive = 0 WHERE IsDeleted = 0",
                            conn,
                            transaction);

                        deactivateCmd.ExecuteNonQuery();

                        SqlCommand activateCmd = new SqlCommand(
                            @"UPDATE AcademicTerms
                              SET IsActive = 1
                              WHERE TermID = @termID
                              AND IsDeleted = 0",
                            conn,
                            transaction);

                        activateCmd.Parameters.AddWithValue("@termID", txtTermID.Text);
                        activateCmd.ExecuteNonQuery();

                        SqlCommand generateCmd = new SqlCommand(
                            @"INSERT INTO ClearanceRecords
                              (StudentID, DepartmentID, TermID, Status, Remarks, IsDeleted)
                              SELECT 
                                  s.StudentID,
                                  d.DepartmentID,
                                  @termID,
                                  'Pending',
                                  '',
                                  0
                              FROM Students s
                              INNER JOIN CourseDepartmentRequirements cdr
                                  ON s.CourseID = cdr.CourseID
                              INNER JOIN Departments d
                                  ON cdr.DepartmentID = d.DepartmentID
                              WHERE s.IsDeleted = 0
                              AND cdr.IsRequired = 1
                              AND cdr.IsDeleted = 0
                              AND d.IsDeleted = 0
                              AND NOT EXISTS (
                                  SELECT 1
                                  FROM ClearanceRecords cr
                                  WHERE cr.StudentID = s.StudentID
                                  AND cr.DepartmentID = d.DepartmentID
                                  AND cr.TermID = @termID
                                  AND cr.IsDeleted = 0
                              )",
                            conn,
                            transaction);

                        generateCmd.Parameters.AddWithValue("@termID", txtTermID.Text);
                        generateCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Academic term is now active. Clearance checklists were generated for all active students.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error setting active term: " + ex.Message,
                            "Set Active Error",
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

        private void ClearFields()
        {
            txtTermID.Clear();
            txtSchoolYear.Clear();
            chkIsActive.Checked = false;

            if (cboSemester.Items.Count > 0)
            {
                cboSemester.SelectedIndex = 0;
            }

            txtSchoolYear.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            LoadAcademicTerms();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            LoadAcademicTerms();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadAcademicTerms();
            ClearFields();
        }

        private void btnSetActive_Click(object sender, EventArgs e)
        {
            SetActiveTerm();
            LoadAcademicTerms();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAcademicTerms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAcademicTerms.Rows[e.RowIndex];

                txtTermID.Text = row.Cells["TermID"].Value.ToString();
                txtSchoolYear.Text = row.Cells["SchoolYear"].Value.ToString();
                cboSemester.Text = row.Cells["Semester"].Value.ToString();

                bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
                chkIsActive.Checked = isActive;
            }
        }
    }
}
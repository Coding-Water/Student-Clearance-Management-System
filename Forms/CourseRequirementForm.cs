using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;

namespace Student_Clearance_Management_System.Forms
{
    public partial class CourseRequirementForm : Form
    {
        private bool isLoading = false;

        public CourseRequirementForm()
        {
            InitializeComponent();
        }

        private void CourseRequirementForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                isLoading = true;

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        CourseID,
                                        CourseCode + ' - ' + CourseName AS CourseDisplay
                                     FROM Courses
                                     WHERE IsDeleted = 0
                                     ORDER BY CourseCode";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboCourse.DataSource = dt;
                    cboCourse.DisplayMember = "CourseDisplay";
                    cboCourse.ValueMember = "CourseID";
                }

                isLoading = false;

                if (cboCourse.Items.Count > 0)
                {
                    cboCourse.SelectedIndex = 0;
                    LoadRequirements();
                }
            }
            catch (Exception ex)
            {
                isLoading = false;

                MessageBox.Show(
                    "Error loading courses: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetSelectedCourseID()
        {
            if (cboCourse.SelectedValue == null)
            {
                return 0;
            }

            if (int.TryParse(cboCourse.SelectedValue.ToString(), out int courseID))
            {
                return courseID;
            }

            return 0;
        }

        private void EnsureRequirementsForSelectedCourse()
        {
            int courseID = GetSelectedCourseID();

            if (courseID == 0)
            {
                return;
            }

            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO CourseDepartmentRequirements
                                 (CourseID, DepartmentID, IsRequired, IsDeleted)
                                 SELECT
                                    @courseID,
                                    d.DepartmentID,
                                    1,
                                    0
                                 FROM Departments d
                                 WHERE d.IsDeleted = 0
                                 AND NOT EXISTS (
                                    SELECT 1
                                    FROM CourseDepartmentRequirements cdr
                                    WHERE cdr.CourseID = @courseID
                                    AND cdr.DepartmentID = d.DepartmentID
                                    AND cdr.IsDeleted = 0
                                 )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@courseID", courseID);
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadRequirements()
        {
            try
            {
                int courseID = GetSelectedCourseID();

                if (courseID == 0)
                {
                    return;
                }

                EnsureRequirementsForSelectedCourse();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        cdr.RequirementID,
                                        d.DepartmentID,
                                        d.DepartmentName,
                                        CAST(cdr.IsRequired AS BIT) AS IsRequired
                                     FROM CourseDepartmentRequirements cdr
                                     INNER JOIN Departments d 
                                        ON cdr.DepartmentID = d.DepartmentID
                                     WHERE cdr.CourseID = @courseID
                                     AND cdr.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     ORDER BY d.DepartmentName";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@courseID", courseID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRequirements.DataSource = dt;
                }

                FormatRequirementsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading requirements: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormatRequirementsGrid()
        {
            dgvRequirements.ReadOnly = false;
            dgvRequirements.AllowUserToAddRows = false;
            dgvRequirements.AllowUserToDeleteRows = false;
            dgvRequirements.MultiSelect = false;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRequirements.Columns["RequirementID"] != null)
            {
                dgvRequirements.Columns["RequirementID"].Visible = false;
            }

            if (dgvRequirements.Columns["DepartmentID"] != null)
            {
                dgvRequirements.Columns["DepartmentID"].Visible = false;
            }

            if (dgvRequirements.Columns["DepartmentName"] != null)
            {
                dgvRequirements.Columns["DepartmentName"].HeaderText = "Department";
                dgvRequirements.Columns["DepartmentName"].ReadOnly = true;
            }

            if (dgvRequirements.Columns["IsRequired"] != null)
            {
                dgvRequirements.Columns["IsRequired"].HeaderText = "Required?";
                dgvRequirements.Columns["IsRequired"].ReadOnly = false;
            }
        }

        private void SaveRequirements()
        {
            if (dgvRequirements.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No requirements to save.",
                    "No Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvRequirements.EndEdit();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow row in dgvRequirements.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            if (row.Cells["RequirementID"].Value == null)
                            {
                                continue;
                            }

                            int requirementID = Convert.ToInt32(row.Cells["RequirementID"].Value);

                            bool isRequired = false;

                            if (row.Cells["IsRequired"].Value != null &&
                                row.Cells["IsRequired"].Value != DBNull.Value)
                            {
                                isRequired = Convert.ToBoolean(row.Cells["IsRequired"].Value);
                            }

                            string query = @"UPDATE CourseDepartmentRequirements
                                             SET IsRequired = @isRequired
                                             WHERE RequirementID = @requirementID
                                             AND IsDeleted = 0";

                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@isRequired", isRequired);
                            cmd.Parameters.AddWithValue("@requirementID", requirementID);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Course requirements saved successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error saving requirements: " + ex.Message,
                            "Save Error",
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

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadRequirements();
        }

        private void dgvRequirements_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvRequirements.IsCurrentCellDirty)
            {
                dgvRequirements.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvRequirements_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnSaveRequirements_Click(object sender, EventArgs e)
        {
            SaveRequirements();
            LoadRequirements();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequirements();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
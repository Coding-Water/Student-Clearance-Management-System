using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Interfaces;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class DepartmentForm : Form, ICrud
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    string query = @"SELECT DepartmentID, DepartmentName
                                     FROM Departments
                                     WHERE IsDeleted = 0";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvDepartments.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading departments: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Add()
        {
            if (txtDepartmentName.Text == "")
            {
                MessageBox.Show("Please enter department name.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Departments
                                     (DepartmentName, IsDeleted)
                                     VALUES
                                     (@name, 0)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtDepartmentName.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Department added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding department: " + ex.Message,
                    "Add Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Update()
        {
            if (txtDepartmentID.Text == "")
            {
                MessageBox.Show("Please select a department to update.");
                return;
            }

            if (txtDepartmentName.Text == "")
            {
                MessageBox.Show("Please enter department name.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Departments
                                     SET DepartmentName = @name
                                     WHERE DepartmentID = @id
                                     AND IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtDepartmentID.Text);
                    cmd.Parameters.AddWithValue("@name", txtDepartmentName.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Department updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating department: " + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            if (txtDepartmentID.Text == "")
            {
                MessageBox.Show("Please select a department to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Deleting this department will also mark related clearance records as deleted. Continue?",
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
                            @"UPDATE Departments
                              SET IsDeleted = 1
                              WHERE DepartmentID = @id",
                            conn,
                            transaction);

                        cmd1.Parameters.AddWithValue("@id", txtDepartmentID.Text);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(
                            @"UPDATE ClearanceRecords
                              SET IsDeleted = 1
                              WHERE DepartmentID = @id",
                            conn,
                            transaction);

                        cmd2.Parameters.AddWithValue("@id", txtDepartmentID.Text);
                        cmd2.ExecuteNonQuery();

                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy)
                              VALUES ('Department', @recordId, @details, 'Delete', GETDATE(), @username)",
                            conn,
                            transaction);
                        logCmd.Parameters.AddWithValue("@recordId", txtDepartmentID.Text);
                        logCmd.Parameters.AddWithValue("@details", txtDepartmentName.Text.Trim() + " (ID: " + txtDepartmentID.Text + ")");
                        logCmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Department deleted. Related clearance records were also marked as deleted.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error deleting department: " + ex.Message,
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

        private void ClearFields()
        {
            txtDepartmentID.Clear();
            txtDepartmentName.Clear();
            txtDepartmentName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            LoadDepartments();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            LoadDepartments();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadDepartments();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartments.Rows[e.RowIndex];

                txtDepartmentID.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
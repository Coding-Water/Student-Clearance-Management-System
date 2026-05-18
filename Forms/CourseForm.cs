using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Interfaces;

namespace Student_Clearance_Management_System.Forms
{
    public partial class CourseForm : Form, ICrud
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT CourseID, CourseCode, CourseName
                                     FROM Courses
                                     WHERE IsDeleted = 0
                                     ORDER BY CourseCode";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCourses.DataSource = dt;
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

        public void Add()
        {
            if (txtCourseCode.Text == "" || txtCourseName.Text == "")
            {
                MessageBox.Show(
                    "Please fill all course fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string insertCourseQuery = @"INSERT INTO Courses
                                                     (CourseCode, CourseName, IsDeleted)
                                                     OUTPUT INSERTED.CourseID
                                                     VALUES
                                                     (@code, @name, 0)";

                        SqlCommand courseCmd = new SqlCommand(insertCourseQuery, conn, transaction);
                        courseCmd.Parameters.AddWithValue("@code", txtCourseCode.Text.Trim());
                        courseCmd.Parameters.AddWithValue("@name", txtCourseName.Text.Trim());

                        int newCourseID = Convert.ToInt32(courseCmd.ExecuteScalar());

                        string requirementsQuery = @"INSERT INTO CourseDepartmentRequirements
                                                     (CourseID, DepartmentID, IsRequired, IsDeleted)
                                                     SELECT
                                                        @courseID,
                                                        DepartmentID,
                                                        1,
                                                        0
                                                     FROM Departments
                                                     WHERE IsDeleted = 0
                                                     AND NOT EXISTS (
                                                        SELECT 1
                                                        FROM CourseDepartmentRequirements cdr
                                                        WHERE cdr.CourseID = @courseID
                                                        AND cdr.DepartmentID = Departments.DepartmentID
                                                        AND cdr.IsDeleted = 0
                                                     )";

                        SqlCommand requirementsCmd = new SqlCommand(requirementsQuery, conn, transaction);
                        requirementsCmd.Parameters.AddWithValue("@courseID", newCourseID);
                        requirementsCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Course added successfully. Department requirements were also created.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error adding course: " + ex.Message,
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
            if (txtCourseID.Text == "")
            {
                MessageBox.Show(
                    "Please select a course to update.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txtCourseCode.Text == "" || txtCourseName.Text == "")
            {
                MessageBox.Show(
                    "Please fill all course fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE Courses
                                     SET CourseCode = @code,
                                         CourseName = @name
                                     WHERE CourseID = @id
                                     AND IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtCourseID.Text);
                    cmd.Parameters.AddWithValue("@code", txtCourseCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtCourseName.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Course updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating course: " + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            if (txtCourseID.Text == "")
            {
                MessageBox.Show(
                    "Please select a course to delete.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Deleting this course will also mark related students, course requirements, and clearance records as deleted. Continue?",
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

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(
                            @"UPDATE Courses
                              SET IsDeleted = 1
                              WHERE CourseID = @id",
                            conn,
                            transaction);

                        cmd1.Parameters.AddWithValue("@id", txtCourseID.Text);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(
                            @"UPDATE CourseDepartmentRequirements
                              SET IsDeleted = 1
                              WHERE CourseID = @id",
                            conn,
                            transaction);

                        cmd2.Parameters.AddWithValue("@id", txtCourseID.Text);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(
                            @"UPDATE Students
                              SET IsDeleted = 1
                              WHERE CourseID = @id",
                            conn,
                            transaction);

                        cmd3.Parameters.AddWithValue("@id", txtCourseID.Text);
                        cmd3.ExecuteNonQuery();

                        SqlCommand cmd4 = new SqlCommand(
                            @"UPDATE ClearanceRecords
                              SET IsDeleted = 1
                              WHERE StudentID IN (
                                  SELECT StudentID
                                  FROM Students
                                  WHERE CourseID = @id
                              )",
                            conn,
                            transaction);

                        cmd4.Parameters.AddWithValue("@id", txtCourseID.Text);
                        cmd4.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(
                            "Course deleted successfully. Related records were also marked as deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Error deleting course: " + ex.Message,
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
            txtCourseID.Clear();
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtCourseCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            LoadCourses();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            LoadCourses();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            LoadCourses();
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

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

                txtCourseID.Text = row.Cells["CourseID"].Value.ToString();
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
            }
        }
    }
}
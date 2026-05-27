using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class StudentDashboard : Form
    {
        private int studentID;
        private string studentName = "";
        private bool isInitializing = true; //

        public StudentDashboard()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);

            if (int.TryParse(AppSession.LoggedInUsername, out int parsedID))
            {
                studentID = parsedID;
            }

            LoadStudentProfile();
            LoadAcademicTerms();
            isInitializing = false;
            LoadChecklist();
        }

        private void LoadStudentProfile()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT s.FirstName, s.LastName, s.YearLevel, s.Section, c.CourseCode, c.CourseName
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.StudentID = @studentID
                                     AND s.IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        studentName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        lblWelcome.Text = "Welcome, " + studentName + "!";
                        lblStudentID.Text = "Student ID: " + studentID.ToString();
                        lblCourse.Text = "Course: " + reader["CourseCode"].ToString() + " - " + reader["CourseName"].ToString();
                        lblYearSection.Text = "Year / Section: " + reader["YearLevel"].ToString() + " Year - " + reader["Section"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAcademicTerms()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT TermID, SchoolYear + ' - ' + Semester AS TermDisplay, IsActive
                                     FROM AcademicTerms
                                     WHERE IsDeleted = 0
                                     ORDER BY TermID DESC";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboAcademicTerm.DataSource = dt;
                        cboAcademicTerm.DisplayMember = "TermDisplay";
                        cboAcademicTerm.ValueMember = "TermID";

                        // Select active term by default
                        DataRow[] activeRows = dt.Select("IsActive = True");
                        if (activeRows.Length > 0)
                        {
                            cboAcademicTerm.SelectedValue = activeRows[0]["TermID"];
                        }
                        else if (dt.Rows.Count > 0)
                        {
                            cboAcademicTerm.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading terms: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChecklist()
        {
            if (cboAcademicTerm.SelectedValue == null) return;

            try
            {
                int termID = Convert.ToInt32(cboAcademicTerm.SelectedValue);

                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        d.DepartmentName AS [Department],
                                        cr.Status AS [Status],
                                        cr.Remarks AS [Remarks]
                                     FROM ClearanceRecords cr
                                     INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                     WHERE cr.StudentID = @studentID
                                     AND cr.TermID = @termID
                                     AND cr.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     ORDER BY d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@termID", termID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvChecklist.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading checklist: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAcademicTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            LoadChecklist();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadChecklist();
            MessageBox.Show("Clearance checklist refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppSession.LoggedInUserID = 0;
                AppSession.LoggedInUsername = "";
                AppSession.LoggedInRole = "";

                StudentLoginForm loginForm = new StudentLoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}

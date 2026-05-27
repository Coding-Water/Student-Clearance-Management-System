using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
            CustomStyling(); //
        }

        private void CustomStyling()
        {
            // Adjust label alignments
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblSubtitle.Left = (this.ClientSize.Width - lblSubtitle.Width) / 2;
            lblRegisterLink.Left = (this.ClientSize.Width - lblRegisterLink.Width) / 2;
            lblStaffLink.Left = (this.ClientSize.Width - lblStaffLink.Width) / 2;

            // Hover styling for links
            lblRegisterLink.MouseEnter += (s, e) => lblRegisterLink.ForeColor = UIHelper.ColorPrimaryHover;
            lblRegisterLink.MouseLeave += (s, e) => lblRegisterLink.ForeColor = UIHelper.ColorPrimary;

            lblStaffLink.MouseEnter += (s, e) => lblStaffLink.ForeColor = UIHelper.ColorSecondaryHover;
            lblStaffLink.MouseLeave += (s, e) => lblStaffLink.ForeColor = UIHelper.ColorSecondary;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter your student ID and password.",
                    "Login Required",
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

                    string query = @"SELECT u.UserID, u.Username, u.Role, s.FirstName, s.LastName
                                     FROM Users u
                                     INNER JOIN Students s ON CAST(s.StudentID AS VARCHAR) = u.Username
                                     WHERE u.Username = @username
                                     AND u.Password = @password
                                     AND u.Role IN ('student', 'Student', 'students', 'Students')
                                     AND u.IsDeleted = 0
                                     AND s.IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtStudentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        AppSession.LoggedInUserID = Convert.ToInt32(reader["UserID"]);
                        AppSession.LoggedInUsername = reader["Username"].ToString();
                        AppSession.LoggedInRole = "student";

                        string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();

                        MessageBox.Show(
                            "Login successful! Welcome " + fullName + ".",
                            "Login Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        StudentDashboard dashboard = new StudentDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid student ID or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm regForm = new StudentRegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void lblStaffLink_Click(object sender, EventArgs e)
        {
            LoginForm staffLogin = new LoginForm();
            staffLogin.Show();
            this.Hide();
        }
    }
}

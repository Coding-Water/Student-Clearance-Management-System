using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public class StudentLoginForm : Form
    {
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStudentID;
        private Label lblPassword;
        private TextBox txtStudentID;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblRegisterLink;
        private Label lblStaffLink;

        public StudentLoginForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
            CustomStyling();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.lblStudentID = new Label();
            this.lblPassword = new Label();
            this.txtStudentID = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblRegisterLink = new Label();
            this.lblStaffLink = new Label();

            this.SuspendLayout();

            // Form properties
            this.ClientSize = new Size(480, 420);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentLoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Clearance Access";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = UIHelper.ColorPrimary;
            this.lblTitle.Location = new Point(40, 30);
            this.lblTitle.Size = new Size(400, 32);
            this.lblTitle.Text = "STUDENT CLEARANCE SYSTEM";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            this.lblSubtitle.ForeColor = UIHelper.ColorSecondary;
            this.lblSubtitle.Location = new Point(160, 70);
            this.lblSubtitle.Size = new Size(160, 21);
            this.lblSubtitle.Text = "Student Access Portal";

            // lblStudentID
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new Point(60, 120);
            this.lblStudentID.Size = new Size(100, 20);
            this.lblStudentID.Text = "Student ID:";

            // txtStudentID
            this.txtStudentID.Location = new Point(60, 145);
            this.txtStudentID.Size = new Size(360, 30);
            this.txtStudentID.TabIndex = 1;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(60, 195);
            this.lblPassword.Size = new Size(100, 20);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Location = new Point(60, 220);
            this.txtPassword.Size = new Size(360, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Location = new Point(60, 280);
            this.btnLogin.Size = new Size(360, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN AS STUDENT";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // lblRegisterLink
            this.lblRegisterLink.AutoSize = true;
            this.lblRegisterLink.Cursor = Cursors.Hand;
            this.lblRegisterLink.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            this.lblRegisterLink.ForeColor = UIHelper.ColorPrimary;
            this.lblRegisterLink.Location = new Point(125, 340);
            this.lblRegisterLink.Size = new Size(230, 19);
            this.lblRegisterLink.Text = "Not registered yet? Register here";
            this.lblRegisterLink.Click += new EventHandler(this.lblRegisterLink_Click);

            // lblStaffLink
            this.lblStaffLink.AutoSize = true;
            this.lblStaffLink.Cursor = Cursors.Hand;
            this.lblStaffLink.Font = new Font("Segoe UI", 9.5F, FontStyle.Underline);
            this.lblStaffLink.ForeColor = UIHelper.ColorSecondary;
            this.lblStaffLink.Location = new Point(180, 375);
            this.lblStaffLink.Size = new Size(120, 17);
            this.lblStaffLink.Text = "Staff / Admin Login";
            this.lblStaffLink.Click += new EventHandler(this.lblStaffLink_Click);

            // Adding controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRegisterLink);
            this.Controls.Add(this.lblStaffLink);

            this.ResumeLayout(false);
            this.PerformLayout();
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
                                     AND u.Role = 'student'
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

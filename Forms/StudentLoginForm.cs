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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblStudentID = new Label();
            lblPassword = new Label();
            txtStudentID = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblRegisterLink = new Label();
            lblStaffLink = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(79, 70, 229);
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(457, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STUDENT CLEARANCE SYSTEM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(160, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(198, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Student Access Portal";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(60, 120);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(82, 20);
            lblStudentID.TabIndex = 2;
            lblStudentID.Text = "Student ID:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(60, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(60, 145);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(360, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(60, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(60, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN AS STUDENT";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegisterLink
            // 
            lblRegisterLink.AutoSize = true;
            lblRegisterLink.Cursor = Cursors.Hand;
            lblRegisterLink.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lblRegisterLink.ForeColor = Color.FromArgb(79, 70, 229);
            lblRegisterLink.Location = new Point(125, 340);
            lblRegisterLink.Name = "lblRegisterLink";
            lblRegisterLink.Size = new Size(261, 23);
            lblRegisterLink.TabIndex = 4;
            lblRegisterLink.Text = "Not registered yet? Register here";
            lblRegisterLink.Click += lblRegisterLink_Click;
            // 
            // lblStaffLink
            // 
            lblStaffLink.AutoSize = true;
            lblStaffLink.Cursor = Cursors.Hand;
            lblStaffLink.Font = new Font("Segoe UI", 9.5F, FontStyle.Underline);
            lblStaffLink.ForeColor = Color.FromArgb(107, 114, 128);
            lblStaffLink.Location = new Point(180, 375);
            lblStaffLink.Name = "lblStaffLink";
            lblStaffLink.Size = new Size(144, 21);
            lblStaffLink.TabIndex = 5;
            lblStaffLink.Text = "Staff / Admin Login";
            lblStaffLink.Click += lblStaffLink_Click;
            // 
            // StudentLoginForm
            // 
            ClientSize = new Size(515, 420);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblRegisterLink);
            Controls.Add(lblStaffLink);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Clearance Access";
            ResumeLayout(false);
            PerformLayout();
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

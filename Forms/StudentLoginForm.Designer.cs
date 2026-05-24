using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Forms
{
    partial class StudentLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStudentID;
        private Label lblPassword;
        private TextBox txtStudentID;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblRegisterLink;
        private Label lblStaffLink;
    }
}

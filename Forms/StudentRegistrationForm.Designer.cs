using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Forms
{
    partial class StudentRegistrationForm
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
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblYearLevel = new Label();
            lblSection = new Label();
            lblContact = new Label();
            lblCourse = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cboYearLevel = new ComboBox();
            txtSection = new TextBox();
            txtContact = new TextBox();
            cboCourse = new ComboBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(79, 70, 229);
            lblTitle.Location = new Point(111, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Self Registration";
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(40, 80);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(150, 20);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID (Number):";
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(40, 155);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(150, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(298, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(150, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblYearLevel
            // 
            lblYearLevel.Location = new Point(40, 230);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(150, 20);
            lblYearLevel.TabIndex = 5;
            lblYearLevel.Text = "Year Level:";
            // 
            // lblSection
            // 
            lblSection.Location = new Point(298, 155);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(150, 20);
            lblSection.TabIndex = 6;
            lblSection.Text = "Section:";
            // 
            // lblContact
            // 
            lblContact.Location = new Point(31, 355);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(150, 20);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Number:";
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(40, 290);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(150, 20);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Select Course:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(31, 430);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Choose Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Location = new Point(31, 505);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(200, 20);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(40, 105);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(230, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(40, 180);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(298, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 27);
            txtLastName.TabIndex = 4;
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Location = new Point(40, 255);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(230, 28);
            cboYearLevel.TabIndex = 5;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(298, 180);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(230, 27);
            txtSection.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(31, 380);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(500, 27);
            txtContact.TabIndex = 7;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Location = new Point(40, 315);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(491, 28);
            cboCourse.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 455);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(500, 27);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(31, 530);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(500, 27);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(31, 590);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(500, 45);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "CREATE STUDENT ACCOUNT";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(31, 650);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(500, 45);
            btnBackToLogin.TabIndex = 11;
            btnBackToLogin.Text = "CANCEL AND GO BACK";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // StudentRegistrationForm
            // 
            ClientSize = new Size(580, 703);
            Controls.Add(lblTitle);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblYearLevel);
            Controls.Add(cboYearLevel);
            Controls.Add(lblSection);
            Controls.Add(txtSection);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnBackToLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Self Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblYearLevel;
        private Label lblSection;
        private Label lblContact;
        private Label lblCourse;
        private Label lblPassword;
        private Label lblConfirmPassword;

        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cboYearLevel;
        private TextBox txtSection;
        private TextBox txtContact;
        private ComboBox cboCourse;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private Button btnRegister;
        private Button btnBackToLogin;
    }
}

namespace Student_Clearance_Management_System.Forms
{
    partial class Dashboard
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
            lblDashboard = new Label();
            lblTotalStudentsTitle = new Label();
            lblPendingTitle = new Label();
            lblClearedTitle = new Label();
            lblTotalStudents = new Label();
            lblPending = new Label();
            lblCleared = new Label();
            btnStudents = new Button();
            btnDepartments = new Button();
            btnClearance = new Button();
            btnCourses = new Button();
            lblTotalCourses = new Label();
            lblTotalCoursesTitle = new Label();
            lblTotalDepartments = new Label();
            lblTotalDepartmentsTitle = new Label();
            lblAcademicTerm = new Label();
            lblLoggedInUser = new Label();
            cboAcademicTerm = new ComboBox();
            btnAcademicTerms = new Button();
            btnLogout = new Button();
            btnRefresh = new Button();
            btnCourseRequirements = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(74, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(456, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STUDENT CLEARANCE MANAGEMENT SYSTEM";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 15F);
            lblDashboard.Location = new Point(234, 47);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(108, 28);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.AutoSize = true;
            lblTotalStudentsTitle.Font = new Font("Segoe UI", 15F);
            lblTotalStudentsTitle.Location = new Point(31, 196);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(135, 28);
            lblTotalStudentsTitle.TabIndex = 2;
            lblTotalStudentsTitle.Text = "Total Students";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 15F);
            lblPendingTitle.Location = new Point(196, 196);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(172, 28);
            lblPendingTitle.TabIndex = 3;
            lblPendingTitle.Text = "Pending Clearance";
            // 
            // lblClearedTitle
            // 
            lblClearedTitle.AutoSize = true;
            lblClearedTitle.Font = new Font("Segoe UI", 15F);
            lblClearedTitle.Location = new Point(403, 196);
            lblClearedTitle.Name = "lblClearedTitle";
            lblClearedTitle.Size = new Size(78, 28);
            lblClearedTitle.TabIndex = 4;
            lblClearedTitle.Text = "Cleared";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 15F);
            lblTotalStudents.Location = new Point(74, 235);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(23, 28);
            lblTotalStudents.TabIndex = 5;
            lblTotalStudents.Text = "0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 15F);
            lblPending.Location = new Point(249, 235);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(23, 28);
            lblPending.TabIndex = 0;
            lblPending.Text = "0";
            // 
            // lblCleared
            // 
            lblCleared.AutoSize = true;
            lblCleared.Font = new Font("Segoe UI", 15F);
            lblCleared.Location = new Point(426, 235);
            lblCleared.Name = "lblCleared";
            lblCleared.Size = new Size(23, 28);
            lblCleared.TabIndex = 7;
            lblCleared.Text = "0";
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(26, 389);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(140, 56);
            btnStudents.TabIndex = 8;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.Location = new Point(317, 389);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(140, 56);
            btnDepartments.TabIndex = 9;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnClearance
            // 
            btnClearance.Location = new Point(463, 389);
            btnClearance.Name = "btnClearance";
            btnClearance.Size = new Size(140, 56);
            btnClearance.TabIndex = 10;
            btnClearance.Text = "Clearance";
            btnClearance.UseVisualStyleBackColor = true;
            btnClearance.Click += btnClearance_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(171, 389);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(140, 56);
            btnCourses.TabIndex = 11;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // lblTotalCourses
            // 
            lblTotalCourses.AutoSize = true;
            lblTotalCourses.Font = new Font("Segoe UI", 15F);
            lblTotalCourses.Location = new Point(74, 332);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(23, 28);
            lblTotalCourses.TabIndex = 13;
            lblTotalCourses.Text = "0";
            // 
            // lblTotalCoursesTitle
            // 
            lblTotalCoursesTitle.AutoSize = true;
            lblTotalCoursesTitle.Font = new Font("Segoe UI", 15F);
            lblTotalCoursesTitle.Location = new Point(31, 293);
            lblTotalCoursesTitle.Name = "lblTotalCoursesTitle";
            lblTotalCoursesTitle.Size = new Size(127, 28);
            lblTotalCoursesTitle.TabIndex = 12;
            lblTotalCoursesTitle.Text = "Total Courses";
            // 
            // lblTotalDepartments
            // 
            lblTotalDepartments.AutoSize = true;
            lblTotalDepartments.Font = new Font("Segoe UI", 15F);
            lblTotalDepartments.Location = new Point(239, 332);
            lblTotalDepartments.Name = "lblTotalDepartments";
            lblTotalDepartments.Size = new Size(23, 28);
            lblTotalDepartments.TabIndex = 15;
            lblTotalDepartments.Text = "0";
            // 
            // lblTotalDepartmentsTitle
            // 
            lblTotalDepartmentsTitle.AutoSize = true;
            lblTotalDepartmentsTitle.Font = new Font("Segoe UI", 15F);
            lblTotalDepartmentsTitle.Location = new Point(196, 293);
            lblTotalDepartmentsTitle.Name = "lblTotalDepartmentsTitle";
            lblTotalDepartmentsTitle.Size = new Size(172, 28);
            lblTotalDepartmentsTitle.TabIndex = 14;
            lblTotalDepartmentsTitle.Text = "Total Departments";
            // 
            // lblAcademicTerm
            // 
            lblAcademicTerm.AutoSize = true;
            lblAcademicTerm.Font = new Font("Segoe UI", 15F);
            lblAcademicTerm.Location = new Point(31, 100);
            lblAcademicTerm.Name = "lblAcademicTerm";
            lblAcademicTerm.Size = new Size(148, 28);
            lblAcademicTerm.TabIndex = 16;
            lblAcademicTerm.Text = "Academic Term:";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI", 15F);
            lblLoggedInUser.Location = new Point(31, 141);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(127, 28);
            lblLoggedInUser.TabIndex = 17;
            lblLoggedInUser.Text = "Logged in as:";
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 15F);
            cboAcademicTerm.FormattingEnabled = true;
            cboAcademicTerm.Location = new Point(185, 97);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(418, 36);
            cboAcademicTerm.TabIndex = 18;
            // 
            // btnAcademicTerms
            // 
            btnAcademicTerms.Location = new Point(171, 469);
            btnAcademicTerms.Name = "btnAcademicTerms";
            btnAcademicTerms.Size = new Size(140, 56);
            btnAcademicTerms.TabIndex = 22;
            btnAcademicTerms.Text = "Academic Terms";
            btnAcademicTerms.UseVisualStyleBackColor = true;
            btnAcademicTerms.Click += btnAcademicTerms_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(463, 469);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 56);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(317, 469);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 56);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCourseRequirements
            // 
            btnCourseRequirements.Location = new Point(26, 469);
            btnCourseRequirements.Name = "btnCourseRequirements";
            btnCourseRequirements.Size = new Size(140, 56);
            btnCourseRequirements.TabIndex = 19;
            btnCourseRequirements.Text = "Course Requirements";
            btnCourseRequirements.UseVisualStyleBackColor = true;
            btnCourseRequirements.Click += btnCourseRequirements_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 555);
            Controls.Add(btnAcademicTerms);
            Controls.Add(btnLogout);
            Controls.Add(btnRefresh);
            Controls.Add(btnCourseRequirements);
            Controls.Add(cboAcademicTerm);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lblAcademicTerm);
            Controls.Add(lblTotalDepartments);
            Controls.Add(lblTotalDepartmentsTitle);
            Controls.Add(lblTotalCourses);
            Controls.Add(lblTotalCoursesTitle);
            Controls.Add(btnCourses);
            Controls.Add(btnClearance);
            Controls.Add(btnDepartments);
            Controls.Add(btnStudents);
            Controls.Add(lblCleared);
            Controls.Add(lblPending);
            Controls.Add(lblTotalStudents);
            Controls.Add(lblClearedTitle);
            Controls.Add(lblPendingTitle);
            Controls.Add(lblTotalStudentsTitle);
            Controls.Add(lblDashboard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDashboard;
        private Label lblTotalStudentsTitle;
        private Label lblPendingTitle;
        private Label lblClearedTitle;
        private Label lblTotalStudents;
        private Label lblPending;
        private Label lblCleared;
        private Button btnStudents;
        private Button btnDepartments;
        private Button btnClearance;
        private Button btnCourses;
        private Label lblTotalCourses;
        private Label lblTotalCoursesTitle;
        private Label lblTotalDepartments;
        private Label lblTotalDepartmentsTitle;
        private Label lblAcademicTerm;
        private Label lblLoggedInUser;
        private ComboBox cboAcademicTerm;
        private Button btnAcademicTerms;
        private Button btnLogout;
        private Button btnRefresh;
        private Button btnCourseRequirements;
    }
}
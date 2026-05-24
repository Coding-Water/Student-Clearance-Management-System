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

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblLoggedInUser = new Label();
            pnlTermBar = new Panel();
            cboAcademicTerm = new ComboBox();
            btnRecycleBin = new Button();
            lblAcademicTerm = new Label();
            pnlStats = new Panel();
            pnlStatStudents = new Panel();
            lblTotalStudents = new Label();
            lblTotalStudentsTitle = new Label();
            pnlStatCourses = new Panel();
            lblTotalCourses = new Label();
            lblTotalCoursesTitle = new Label();
            pnlStatDepts = new Panel();
            lblTotalDepartments = new Label();
            lblTotalDepartmentsTitle = new Label();
            pnlStatPending = new Panel();
            lblPending = new Label();
            lblPendingTitle = new Label();
            pnlStatCleared = new Panel();
            lblCleared = new Label();
            lblClearedTitle = new Label();
            lblDashboard = new Label();
            pnlNavButtons = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnAcademicTerms = new Button();
            btnCourseRequirements = new Button();
            btnClearance = new Button();
            btnDepartments = new Button();
            btnCourses = new Button();
            btnStudents = new Button();
            pnlHeader.SuspendLayout();
            pnlTermBar.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlStatStudents.SuspendLayout();
            pnlStatCourses.SuspendLayout();
            pnlStatDepts.SuspendLayout();
            pnlStatPending.SuspendLayout();
            pnlStatCleared.SuspendLayout();
            pnlNavButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblLoggedInUser);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(21, 0, 21, 0);
            pnlHeader.Size = new Size(785, 69);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 69);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎓  Student Clearance Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.Dock = DockStyle.Right;
            lblLoggedInUser.Font = new Font("Segoe UI", 9.5F);
            lblLoggedInUser.ForeColor = Color.FromArgb(199, 210, 254);
            lblLoggedInUser.Location = new Point(503, 0);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(261, 69);
            lblLoggedInUser.TabIndex = 1;
            lblLoggedInUser.Text = "Logged in as:";
            lblLoggedInUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTermBar
            // 
            pnlTermBar.BackColor = Color.White;
            pnlTermBar.Controls.Add(cboAcademicTerm);
            pnlTermBar.Controls.Add(btnRecycleBin);
            pnlTermBar.Controls.Add(lblAcademicTerm);
            pnlTermBar.Dock = DockStyle.Top;
            pnlTermBar.Location = new Point(0, 69);
            pnlTermBar.Name = "pnlTermBar";
            pnlTermBar.Padding = new Padding(21, 11, 21, 11);
            pnlTermBar.Size = new Size(785, 52);
            pnlTermBar.TabIndex = 2;
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 10F);
            cboAcademicTerm.Location = new Point(165, 11);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(319, 31);
            cboAcademicTerm.TabIndex = 1;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // btnRecycleBin
            // 
            btnRecycleBin.Location = new Point(650, 8);
            btnRecycleBin.Name = "btnRecycleBin";
            btnRecycleBin.Size = new Size(112, 36);
            btnRecycleBin.TabIndex = 16;
            btnRecycleBin.Text = "🔐  Admin Panel";
            btnRecycleBin.UseVisualStyleBackColor = true;
            btnRecycleBin.Click += btnRecycleBin_Click;
            // 
            // lblAcademicTerm
            // 
            lblAcademicTerm.AutoSize = true;
            lblAcademicTerm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAcademicTerm.ForeColor = Color.FromArgb(55, 65, 81);
            lblAcademicTerm.Location = new Point(21, 13);
            lblAcademicTerm.Name = "lblAcademicTerm";
            lblAcademicTerm.Size = new Size(138, 23);
            lblAcademicTerm.TabIndex = 2;
            lblAcademicTerm.Text = "Academic Term:";
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(249, 250, 251);
            pnlStats.Controls.Add(pnlStatStudents);
            pnlStats.Controls.Add(pnlStatCourses);
            pnlStats.Controls.Add(pnlStatDepts);
            pnlStats.Controls.Add(pnlStatPending);
            pnlStats.Controls.Add(pnlStatCleared);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 121);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(16, 12, 16, 12);
            pnlStats.Size = new Size(785, 120);
            pnlStats.TabIndex = 1;
            // 
            // pnlStatStudents
            // 
            pnlStatStudents.BackColor = Color.White;
            pnlStatStudents.Controls.Add(lblTotalStudents);
            pnlStatStudents.Controls.Add(lblTotalStudentsTitle);
            pnlStatStudents.Location = new Point(16, 12);
            pnlStatStudents.Name = "pnlStatStudents";
            pnlStatStudents.Padding = new Padding(11, 11, 11, 11);
            pnlStatStudents.Size = new Size(142, 100);
            pnlStatStudents.TabIndex = 4;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Dock = DockStyle.Fill;
            lblTotalStudents.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalStudents.ForeColor = Color.FromArgb(79, 70, 229);
            lblTotalStudents.Location = new Point(11, 32);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(120, 57);
            lblTotalStudents.TabIndex = 0;
            lblTotalStudents.Text = "0";
            lblTotalStudents.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.Dock = DockStyle.Top;
            lblTotalStudentsTitle.Font = new Font("Segoe UI", 8.5F);
            lblTotalStudentsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalStudentsTitle.Location = new Point(11, 11);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(120, 21);
            lblTotalStudentsTitle.TabIndex = 1;
            lblTotalStudentsTitle.Text = "👩‍🎓 Total Students";
            lblTotalStudentsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStatCourses
            // 
            pnlStatCourses.BackColor = Color.White;
            pnlStatCourses.Controls.Add(lblTotalCourses);
            pnlStatCourses.Controls.Add(lblTotalCoursesTitle);
            pnlStatCourses.Location = new Point(170, 12);
            pnlStatCourses.Name = "pnlStatCourses";
            pnlStatCourses.Padding = new Padding(11, 11, 11, 11);
            pnlStatCourses.Size = new Size(142, 100);
            pnlStatCourses.TabIndex = 3;
            // 
            // lblTotalCourses
            // 
            lblTotalCourses.Dock = DockStyle.Fill;
            lblTotalCourses.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCourses.ForeColor = Color.FromArgb(16, 185, 129);
            lblTotalCourses.Location = new Point(11, 32);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(120, 57);
            lblTotalCourses.TabIndex = 0;
            lblTotalCourses.Text = "0";
            lblTotalCourses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCoursesTitle
            // 
            lblTotalCoursesTitle.Dock = DockStyle.Top;
            lblTotalCoursesTitle.Font = new Font("Segoe UI", 8.5F);
            lblTotalCoursesTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalCoursesTitle.Location = new Point(11, 11);
            lblTotalCoursesTitle.Name = "lblTotalCoursesTitle";
            lblTotalCoursesTitle.Size = new Size(120, 21);
            lblTotalCoursesTitle.TabIndex = 1;
            lblTotalCoursesTitle.Text = "📚 Courses";
            lblTotalCoursesTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStatDepts
            // 
            pnlStatDepts.BackColor = Color.White;
            pnlStatDepts.Controls.Add(lblTotalDepartments);
            pnlStatDepts.Controls.Add(lblTotalDepartmentsTitle);
            pnlStatDepts.Location = new Point(325, 12);
            pnlStatDepts.Name = "pnlStatDepts";
            pnlStatDepts.Padding = new Padding(11, 11, 11, 11);
            pnlStatDepts.Size = new Size(142, 100);
            pnlStatDepts.TabIndex = 2;
            // 
            // lblTotalDepartments
            // 
            lblTotalDepartments.Dock = DockStyle.Fill;
            lblTotalDepartments.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalDepartments.ForeColor = Color.FromArgb(245, 158, 11);
            lblTotalDepartments.Location = new Point(11, 32);
            lblTotalDepartments.Name = "lblTotalDepartments";
            lblTotalDepartments.Size = new Size(120, 57);
            lblTotalDepartments.TabIndex = 0;
            lblTotalDepartments.Text = "0";
            lblTotalDepartments.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalDepartmentsTitle
            // 
            lblTotalDepartmentsTitle.Dock = DockStyle.Top;
            lblTotalDepartmentsTitle.Font = new Font("Segoe UI", 8.5F);
            lblTotalDepartmentsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalDepartmentsTitle.Location = new Point(11, 11);
            lblTotalDepartmentsTitle.Name = "lblTotalDepartmentsTitle";
            lblTotalDepartmentsTitle.Size = new Size(120, 21);
            lblTotalDepartmentsTitle.TabIndex = 1;
            lblTotalDepartmentsTitle.Text = "🏢 Departments";
            lblTotalDepartmentsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStatPending
            // 
            pnlStatPending.BackColor = Color.White;
            pnlStatPending.Controls.Add(lblPending);
            pnlStatPending.Controls.Add(lblPendingTitle);
            pnlStatPending.Location = new Point(478, 12);
            pnlStatPending.Name = "pnlStatPending";
            pnlStatPending.Padding = new Padding(11, 11, 11, 11);
            pnlStatPending.Size = new Size(142, 100);
            pnlStatPending.TabIndex = 1;
            // 
            // lblPending
            // 
            lblPending.Dock = DockStyle.Fill;
            lblPending.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPending.ForeColor = Color.FromArgb(239, 68, 68);
            lblPending.Location = new Point(11, 32);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(120, 57);
            lblPending.TabIndex = 0;
            lblPending.Text = "0";
            lblPending.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Dock = DockStyle.Top;
            lblPendingTitle.Font = new Font("Segoe UI", 8.5F);
            lblPendingTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblPendingTitle.Location = new Point(11, 11);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(120, 21);
            lblPendingTitle.TabIndex = 1;
            lblPendingTitle.Text = "⏳ Pending";
            lblPendingTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStatCleared
            // 
            pnlStatCleared.BackColor = Color.White;
            pnlStatCleared.Controls.Add(lblCleared);
            pnlStatCleared.Controls.Add(lblClearedTitle);
            pnlStatCleared.Location = new Point(632, 12);
            pnlStatCleared.Name = "pnlStatCleared";
            pnlStatCleared.Padding = new Padding(11, 11, 11, 11);
            pnlStatCleared.Size = new Size(142, 100);
            pnlStatCleared.TabIndex = 0;
            // 
            // lblCleared
            // 
            lblCleared.Dock = DockStyle.Fill;
            lblCleared.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCleared.ForeColor = Color.FromArgb(22, 163, 74);
            lblCleared.Location = new Point(11, 32);
            lblCleared.Name = "lblCleared";
            lblCleared.Size = new Size(120, 57);
            lblCleared.TabIndex = 0;
            lblCleared.Text = "0";
            lblCleared.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClearedTitle
            // 
            lblClearedTitle.Dock = DockStyle.Top;
            lblClearedTitle.Font = new Font("Segoe UI", 8.5F);
            lblClearedTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblClearedTitle.Location = new Point(11, 11);
            lblClearedTitle.Name = "lblClearedTitle";
            lblClearedTitle.Size = new Size(120, 21);
            lblClearedTitle.TabIndex = 1;
            lblClearedTitle.Text = "✅ Cleared";
            lblClearedTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDashboard
            // 
            lblDashboard.Location = new Point(0, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(101, 23);
            lblDashboard.TabIndex = 4;
            lblDashboard.Visible = false;
            // 
            // pnlNavButtons
            // 
            pnlNavButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlNavButtons.Controls.Add(btnLogout);
            pnlNavButtons.Controls.Add(btnReports);
            pnlNavButtons.Controls.Add(btnAcademicTerms);
            pnlNavButtons.Controls.Add(btnCourseRequirements);
            pnlNavButtons.Controls.Add(btnClearance);
            pnlNavButtons.Controls.Add(btnDepartments);
            pnlNavButtons.Controls.Add(btnCourses);
            pnlNavButtons.Controls.Add(btnStudents);
            pnlNavButtons.Dock = DockStyle.Fill;
            pnlNavButtons.Location = new Point(0, 241);
            pnlNavButtons.Name = "pnlNavButtons";
            pnlNavButtons.Padding = new Padding(16, 16, 16, 16);
            pnlNavButtons.Size = new Size(785, 162);
            pnlNavButtons.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(592, 85);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 59);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "🔒  Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(398, 85);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(170, 59);
            btnReports.TabIndex = 15;
            btnReports.Text = "📊  Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAcademicTerms
            // 
            btnAcademicTerms.Location = new Point(209, 85);
            btnAcademicTerms.Name = "btnAcademicTerms";
            btnAcademicTerms.Size = new Size(170, 59);
            btnAcademicTerms.TabIndex = 14;
            btnAcademicTerms.Text = "📅  Acad. Terms";
            btnAcademicTerms.UseVisualStyleBackColor = true;
            btnAcademicTerms.Click += btnAcademicTerms_Click;
            // 
            // btnCourseRequirements
            // 
            btnCourseRequirements.Location = new Point(21, 84);
            btnCourseRequirements.Name = "btnCourseRequirements";
            btnCourseRequirements.Size = new Size(170, 59);
            btnCourseRequirements.TabIndex = 13;
            btnCourseRequirements.Text = "⚙️  Course Req.";
            btnCourseRequirements.UseVisualStyleBackColor = true;
            btnCourseRequirements.Click += btnCourseRequirements_Click;
            // 
            // btnClearance
            // 
            btnClearance.Location = new Point(592, 16);
            btnClearance.Name = "btnClearance";
            btnClearance.Size = new Size(170, 59);
            btnClearance.TabIndex = 13;
            btnClearance.Text = "📋  Clearance";
            btnClearance.UseVisualStyleBackColor = true;
            btnClearance.Click += btnClearance_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.Location = new Point(398, 16);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(170, 59);
            btnDepartments.TabIndex = 12;
            btnDepartments.Text = "🏢  Departments";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(209, 16);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(170, 59);
            btnCourses.TabIndex = 11;
            btnCourses.Text = "📚  Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(21, 16);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(170, 59);
            btnStudents.TabIndex = 10;
            btnStudents.Text = "👩‍🎓  Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 403);
            Controls.Add(pnlNavButtons);
            Controls.Add(pnlStats);
            Controls.Add(pnlTermBar);
            Controls.Add(pnlHeader);
            Controls.Add(lblDashboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Dashboard — Student Clearance System";
            Load += Dashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlTermBar.ResumeLayout(false);
            pnlTermBar.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlStatStudents.ResumeLayout(false);
            pnlStatCourses.ResumeLayout(false);
            pnlStatDepts.ResumeLayout(false);
            pnlStatPending.ResumeLayout(false);
            pnlStatCleared.ResumeLayout(false);
            pnlNavButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlTermBar;
        private Panel pnlStats;
        private Panel pnlStatStudents;
        private Panel pnlStatCourses;
        private Panel pnlStatDepts;
        private Panel pnlStatPending;
        private Panel pnlStatCleared;
        private Panel pnlNavButtons;

        private Label lblTitle;
        private Label lblDashboard;
        private Label lblLoggedInUser;
        private Label lblAcademicTerm;
        private ComboBox cboAcademicTerm;

        private Label lblTotalStudentsTitle;
        private Label lblTotalStudents;
        private Label lblTotalCoursesTitle;
        private Label lblTotalCourses;
        private Label lblTotalDepartmentsTitle;
        private Label lblTotalDepartments;
        private Label lblPendingTitle;
        private Label lblPending;
        private Label lblClearedTitle;
        private Label lblCleared;

        private Button btnStudents;
        private Button btnCourses;
        private Button btnDepartments;
        private Button btnClearance;
        private Button btnCourseRequirements;
        private Button btnAcademicTerms;
        private Button btnReports;
        private Button btnRecycleBin;
        private Button btnLogout;
    }
}

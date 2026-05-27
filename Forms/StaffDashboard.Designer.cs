using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Forms
{
    partial class StaffDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnLogout = new Button();
            pnlFilterCard = new Panel();
            lblAssignedDepts = new Label();
            txtStudentSearch = new TextBox();
            lblStudent = new Label();
            lblSelectedTerm = new Label();
            cboAcademicTerm = new ComboBox();
            pnlActionBar = new Panel();
            btnClear = new Button();
            btnSaveChanges = new Button();
            btnLoadChecklist = new Button();
            pnlLeft = new Panel();
            dgvChecklistGrid = new DataGridView();
            lblChecklist = new Label();
            pnlRight = new Panel();
            dgvAllRecords = new DataGridView();
            pnlSearchRecords = new Panel();
            txtRecordsSearch = new TextBox();
            lblRecordsSearch = new Label();
            lblRecords = new Label();
            splitter = new Splitter();
            pnlHeader.SuspendLayout();
            pnlFilterCard.SuspendLayout();
            pnlActionBar.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChecklistGrid).BeginInit();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllRecords).BeginInit();
            pnlSearchRecords.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1242, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1142, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📋  Staff Clearance Portal";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1142, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 50);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout ➔";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlFilterCard
            // 
            pnlFilterCard.BackColor = Color.White;
            pnlFilterCard.Controls.Add(lblAssignedDepts);
            pnlFilterCard.Controls.Add(txtStudentSearch);
            pnlFilterCard.Controls.Add(lblStudent);
            pnlFilterCard.Controls.Add(lblSelectedTerm);
            pnlFilterCard.Controls.Add(cboAcademicTerm);
            pnlFilterCard.Dock = DockStyle.Top;
            pnlFilterCard.Location = new Point(0, 50);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Size = new Size(1242, 60);
            pnlFilterCard.TabIndex = 1;
            // 
            // lblAssignedDepts
            // 
            lblAssignedDepts.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblAssignedDepts.ForeColor = Color.FromArgb(75, 85, 99);
            lblAssignedDepts.Location = new Point(800, 20);
            lblAssignedDepts.Name = "lblAssignedDepts";
            lblAssignedDepts.Size = new Size(420, 25);
            lblAssignedDepts.TabIndex = 4;
            lblAssignedDepts.Text = "Assigned Departments: Loading...";
            lblAssignedDepts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtStudentSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStudentSearch.Location = new Point(480, 20);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(300, 23);
            txtStudentSearch.TabIndex = 3;
            txtStudentSearch.KeyDown += txtStudentSearch_KeyDown;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStudent.Location = new Point(370, 22);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(104, 17);
            lblStudent.TabIndex = 2;
            lblStudent.Text = "Search Student:";
            // 
            // lblSelectedTerm
            // 
            lblSelectedTerm.AutoSize = true;
            lblSelectedTerm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSelectedTerm.Location = new Point(20, 22);
            lblSelectedTerm.Name = "lblSelectedTerm";
            lblSelectedTerm.Size = new Size(106, 17);
            lblSelectedTerm.TabIndex = 0;
            lblSelectedTerm.Text = "Academic Term:";
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Location = new Point(130, 20);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(200, 23);
            cboAcademicTerm.TabIndex = 1;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // pnlActionBar
            // 
            pnlActionBar.BackColor = Color.FromArgb(243, 244, 246);
            pnlActionBar.Controls.Add(btnClear);
            pnlActionBar.Controls.Add(btnSaveChanges);
            pnlActionBar.Controls.Add(btnLoadChecklist);
            pnlActionBar.Dock = DockStyle.Top;
            pnlActionBar.Location = new Point(0, 110);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new Size(1242, 50);
            pnlActionBar.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(370, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(16, 185, 129);
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(190, 10);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(160, 30);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Save Checklist Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnLoadChecklist
            // 
            btnLoadChecklist.BackColor = Color.FromArgb(79, 70, 229);
            btnLoadChecklist.Cursor = Cursors.Hand;
            btnLoadChecklist.FlatStyle = FlatStyle.Flat;
            btnLoadChecklist.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadChecklist.ForeColor = Color.White;
            btnLoadChecklist.Location = new Point(20, 10);
            btnLoadChecklist.Name = "btnLoadChecklist";
            btnLoadChecklist.Size = new Size(150, 30);
            btnLoadChecklist.TabIndex = 0;
            btnLoadChecklist.Text = "Load Checklist";
            btnLoadChecklist.UseVisualStyleBackColor = false;
            btnLoadChecklist.Click += btnLoadChecklist_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(dgvChecklistGrid);
            pnlLeft.Controls.Add(lblChecklist);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 160);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(20);
            pnlLeft.Size = new Size(580, 561);
            pnlLeft.TabIndex = 3;
            // 
            // dgvChecklistGrid
            // 
            dgvChecklistGrid.AllowUserToAddRows = false;
            dgvChecklistGrid.AllowUserToDeleteRows = false;
            dgvChecklistGrid.BackgroundColor = Color.White;
            dgvChecklistGrid.Dock = DockStyle.Fill;
            dgvChecklistGrid.Location = new Point(20, 50);
            dgvChecklistGrid.Name = "dgvChecklistGrid";
            dgvChecklistGrid.RowHeadersWidth = 51;
            dgvChecklistGrid.RowTemplate.Height = 29;
            dgvChecklistGrid.Size = new Size(540, 491);
            dgvChecklistGrid.TabIndex = 1;
            dgvChecklistGrid.DataError += dgvChecklistGrid_DataError;
            // 
            // lblChecklist
            // 
            lblChecklist.Dock = DockStyle.Top;
            lblChecklist.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChecklist.ForeColor = Color.FromArgb(31, 41, 55);
            lblChecklist.Location = new Point(20, 20);
            lblChecklist.Name = "lblChecklist";
            lblChecklist.Size = new Size(540, 30);
            lblChecklist.TabIndex = 0;
            lblChecklist.Text = "Your Assigned Department rows";
            lblChecklist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvAllRecords);
            pnlRight.Controls.Add(pnlSearchRecords);
            pnlRight.Controls.Add(lblRecords);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(585, 160);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(20);
            pnlRight.Size = new Size(657, 561);
            pnlRight.TabIndex = 5;
            // 
            // dgvAllRecords
            // 
            dgvAllRecords.AllowUserToAddRows = false;
            dgvAllRecords.AllowUserToDeleteRows = false;
            dgvAllRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllRecords.BackgroundColor = Color.White;
            dgvAllRecords.Dock = DockStyle.Fill;
            dgvAllRecords.Location = new Point(20, 95);
            dgvAllRecords.Name = "dgvAllRecords";
            dgvAllRecords.ReadOnly = true;
            dgvAllRecords.RowHeadersWidth = 51;
            dgvAllRecords.RowTemplate.Height = 29;
            dgvAllRecords.Size = new Size(617, 446);
            dgvAllRecords.TabIndex = 2;
            // 
            // pnlSearchRecords
            // 
            pnlSearchRecords.Controls.Add(txtRecordsSearch);
            pnlSearchRecords.Controls.Add(lblRecordsSearch);
            pnlSearchRecords.Dock = DockStyle.Top;
            pnlSearchRecords.Location = new Point(20, 50);
            pnlSearchRecords.Name = "pnlSearchRecords";
            pnlSearchRecords.Size = new Size(617, 45);
            pnlSearchRecords.TabIndex = 1;
            // 
            // txtRecordsSearch
            // 
            txtRecordsSearch.Location = new Point(140, 10);
            txtRecordsSearch.Name = "txtRecordsSearch";
            txtRecordsSearch.Size = new Size(250, 23);
            txtRecordsSearch.TabIndex = 1;
            txtRecordsSearch.TextChanged += txtRecordsSearch_TextChanged;
            // 
            // lblRecordsSearch
            // 
            lblRecordsSearch.AutoSize = true;
            lblRecordsSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecordsSearch.Location = new Point(10, 13);
            lblRecordsSearch.Name = "lblRecordsSearch";
            lblRecordsSearch.Size = new Size(138, 15);
            lblRecordsSearch.TabIndex = 0;
            lblRecordsSearch.Text = "Filter records summary:";
            // 
            // lblRecords
            // 
            lblRecords.Dock = DockStyle.Top;
            lblRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecords.ForeColor = Color.FromArgb(31, 41, 55);
            lblRecords.Location = new Point(20, 20);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(617, 30);
            lblRecords.TabIndex = 0;
            lblRecords.Text = "All Students Clearance Records Summary";
            lblRecords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter
            // 
            splitter.Location = new Point(580, 160);
            splitter.Name = "splitter";
            splitter.Size = new Size(5, 561);
            splitter.TabIndex = 4;
            splitter.TabStop = false;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 721);
            Controls.Add(pnlRight);
            Controls.Add(splitter);
            Controls.Add(pnlLeft);
            Controls.Add(pnlActionBar);
            Controls.Add(pnlFilterCard);
            Controls.Add(pnlHeader);
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Clearance Management Dashboard";
            Load += StaffDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilterCard.ResumeLayout(false);
            pnlFilterCard.PerformLayout();
            pnlActionBar.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChecklistGrid).EndInit();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllRecords).EndInit();
            pnlSearchRecords.ResumeLayout(false);
            pnlSearchRecords.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnLogout;
        private Panel pnlFilterCard;
        private Label lblSelectedTerm;
        private ComboBox cboAcademicTerm;
        private TextBox txtStudentSearch;
        private Label lblStudent;
        private Label lblAssignedDepts;
        private Panel pnlActionBar;
        private Button btnClear;
        private Button btnSaveChanges;
        private Button btnLoadChecklist;
        private Panel pnlLeft;
        private Label lblChecklist;
        private DataGridView dgvChecklistGrid;
        private Splitter splitter;
        private Panel pnlRight;
        private DataGridView dgvAllRecords;
        private Label lblRecords;
        private Panel pnlSearchRecords;
        private TextBox txtRecordsSearch;
        private Label lblRecordsSearch;
    }
}

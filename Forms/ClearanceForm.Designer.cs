namespace Student_Clearance_Management_System.Forms
{
    partial class ClearanceForm
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
            btnBack = new Button();
            pnlFilterCard = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStudent = new Label();
            lblSelectedTerm = new Label();
            cboAcademicTerm = new ComboBox();
            pnlActionBar = new Panel();
            btnClear = new Button();
            btnDeleteSelected = new Button();
            btnAdd = new Button();
            btnLoadChecklist = new Button();
            pnlLeft = new Panel();
            dgvClearanceDepartments = new DataGridView();
            lblChecklist = new Label();
            pnlRight = new Panel();
            dgvClearanceRecords = new DataGridView();
            lblRecords = new Label();
            splitter = new Splitter();
            txtSearchBox = new TextBox();
            pnlHeader.SuspendLayout();
            pnlFilterCard.SuspendLayout();
            pnlActionBar.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceDepartments).BeginInit();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceRecords).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1242, 45);
            pnlHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1172, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📋  Clearance Processing";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(67, 56, 202);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 45);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlFilterCard
            // 
            pnlFilterCard.BackColor = Color.White;
            pnlFilterCard.Controls.Add(txtSearchBox);
            pnlFilterCard.Controls.Add(lblSearch);
            pnlFilterCard.Controls.Add(txtSearch);
            pnlFilterCard.Controls.Add(lblStudent);
            pnlFilterCard.Controls.Add(lblSelectedTerm);
            pnlFilterCard.Controls.Add(cboAcademicTerm);
            pnlFilterCard.Dock = DockStyle.Top;
            pnlFilterCard.Location = new Point(0, 45);
            pnlFilterCard.Margin = new Padding(3, 2, 3, 2);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Padding = new Padding(18, 8, 18, 6);
            pnlFilterCard.Size = new Size(1242, 82);
            pnlFilterCard.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(55, 65, 81);
            lblSearch.Location = new Point(590, 49);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Student:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(694, 47);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Filter by name or ID...";
            txtSearch.Size = new Size(298, 25);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(55, 65, 81);
            lblStudent.Location = new Point(21, 49);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(55, 15);
            lblStudent.TabIndex = 4;
            lblStudent.Text = "Student:";
            // 
            // lblSelectedTerm
            // 
            lblSelectedTerm.AutoSize = true;
            lblSelectedTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedTerm.ForeColor = Color.FromArgb(55, 65, 81);
            lblSelectedTerm.Location = new Point(21, 17);
            lblSelectedTerm.Name = "lblSelectedTerm";
            lblSelectedTerm.Size = new Size(96, 15);
            lblSelectedTerm.TabIndex = 5;
            lblSelectedTerm.Text = "Academic Term:";
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 10F);
            cboAcademicTerm.Location = new Point(125, 15);
            cboAcademicTerm.Margin = new Padding(3, 2, 3, 2);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(210, 25);
            cboAcademicTerm.TabIndex = 1;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // pnlActionBar
            // 
            pnlActionBar.BackColor = Color.FromArgb(249, 250, 251);
            pnlActionBar.Controls.Add(btnClear);
            pnlActionBar.Controls.Add(btnDeleteSelected);
            pnlActionBar.Controls.Add(btnAdd);
            pnlActionBar.Controls.Add(btnLoadChecklist);
            pnlActionBar.Dock = DockStyle.Top;
            pnlActionBar.Location = new Point(0, 127);
            pnlActionBar.Margin = new Padding(3, 2, 3, 2);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Padding = new Padding(18, 8, 18, 8);
            pnlActionBar.Size = new Size(1242, 44);
            pnlActionBar.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(438, 8);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 27);
            btnClear.TabIndex = 7;
            btnClear.Text = "↺  Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteSelected.Cursor = Cursors.Hand;
            btnDeleteSelected.FlatAppearance.BorderSize = 0;
            btnDeleteSelected.FlatStyle = FlatStyle.Flat;
            btnDeleteSelected.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeleteSelected.ForeColor = Color.White;
            btnDeleteSelected.Location = new Point(298, 8);
            btnDeleteSelected.Margin = new Padding(3, 2, 3, 2);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(131, 27);
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "🗑️  Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 163, 74);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(158, 8);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "💾  Save All";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnSaveAll_Click;
            // 
            // btnLoadChecklist
            // 
            btnLoadChecklist.BackColor = Color.FromArgb(79, 70, 229);
            btnLoadChecklist.Cursor = Cursors.Hand;
            btnLoadChecklist.FlatAppearance.BorderSize = 0;
            btnLoadChecklist.FlatStyle = FlatStyle.Flat;
            btnLoadChecklist.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLoadChecklist.ForeColor = Color.White;
            btnLoadChecklist.Location = new Point(18, 8);
            btnLoadChecklist.Margin = new Padding(3, 2, 3, 2);
            btnLoadChecklist.Name = "btnLoadChecklist";
            btnLoadChecklist.Size = new Size(131, 27);
            btnLoadChecklist.TabIndex = 4;
            btnLoadChecklist.Text = "📥  Load Checklist";
            btnLoadChecklist.UseVisualStyleBackColor = false;
            btnLoadChecklist.Click += btnLoadChecklist_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(249, 250, 251);
            pnlLeft.Controls.Add(dgvClearanceDepartments);
            pnlLeft.Controls.Add(lblChecklist);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 171);
            pnlLeft.Margin = new Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10, 6, 5, 9);
            pnlLeft.Size = new Size(581, 384);
            pnlLeft.TabIndex = 2;
            // 
            // dgvClearanceDepartments
            // 
            dgvClearanceDepartments.AllowUserToAddRows = false;
            dgvClearanceDepartments.AllowUserToDeleteRows = false;
            dgvClearanceDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClearanceDepartments.Dock = DockStyle.Fill;
            dgvClearanceDepartments.Location = new Point(10, 27);
            dgvClearanceDepartments.Margin = new Padding(3, 2, 3, 2);
            dgvClearanceDepartments.MultiSelect = false;
            dgvClearanceDepartments.Name = "dgvClearanceDepartments";
            dgvClearanceDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceDepartments.Size = new Size(566, 348);
            dgvClearanceDepartments.TabIndex = 8;
            dgvClearanceDepartments.CurrentCellDirtyStateChanged += dgvClearanceDepartments_CurrentCellDirtyStateChanged;
            // 
            // lblChecklist
            // 
            lblChecklist.Dock = DockStyle.Top;
            lblChecklist.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblChecklist.ForeColor = Color.FromArgb(55, 65, 81);
            lblChecklist.Location = new Point(10, 6);
            lblChecklist.Name = "lblChecklist";
            lblChecklist.Size = new Size(566, 21);
            lblChecklist.TabIndex = 9;
            lblChecklist.Text = "Clearance Checklist  (tick to mark Cleared)";
            lblChecklist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(249, 250, 251);
            pnlRight.Controls.Add(dgvClearanceRecords);
            pnlRight.Controls.Add(lblRecords);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(585, 171);
            pnlRight.Margin = new Padding(3, 2, 3, 2);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(5, 6, 10, 9);
            pnlRight.Size = new Size(657, 384);
            pnlRight.TabIndex = 0;
            // 
            // dgvClearanceRecords
            // 
            dgvClearanceRecords.AllowUserToAddRows = false;
            dgvClearanceRecords.AllowUserToDeleteRows = false;
            dgvClearanceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClearanceRecords.Dock = DockStyle.Fill;
            dgvClearanceRecords.Location = new Point(5, 27);
            dgvClearanceRecords.Margin = new Padding(3, 2, 3, 2);
            dgvClearanceRecords.MultiSelect = false;
            dgvClearanceRecords.Name = "dgvClearanceRecords";
            dgvClearanceRecords.ReadOnly = true;
            dgvClearanceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceRecords.Size = new Size(642, 348);
            dgvClearanceRecords.TabIndex = 9;
            // 
            // lblRecords
            // 
            lblRecords.Dock = DockStyle.Top;
            lblRecords.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRecords.ForeColor = Color.FromArgb(55, 65, 81);
            lblRecords.Location = new Point(5, 6);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(642, 21);
            lblRecords.TabIndex = 10;
            lblRecords.Text = "Clearance Records / Summary Report";
            lblRecords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter
            // 
            splitter.BackColor = Color.FromArgb(229, 231, 235);
            splitter.Location = new Point(581, 171);
            splitter.Margin = new Padding(3, 2, 3, 2);
            splitter.Name = "splitter";
            splitter.Size = new Size(4, 384);
            splitter.TabIndex = 1;
            splitter.TabStop = false;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.Font = new Font("Segoe UI", 10F);
            txtSearchBox.Location = new Point(125, 47);
            txtSearchBox.Margin = new Padding(3, 2, 3, 2);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search by name or ID...";
            txtSearchBox.Size = new Size(298, 25);
            txtSearchBox.TabIndex = 6;
            // 
            // ClearanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 555);
            Controls.Add(pnlRight);
            Controls.Add(splitter);
            Controls.Add(pnlLeft);
            Controls.Add(pnlActionBar);
            Controls.Add(pnlFilterCard);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClearanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clearance Processing — Clearance System";
            Load += ClearanceForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilterCard.ResumeLayout(false);
            pnlFilterCard.PerformLayout();
            pnlActionBar.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClearanceDepartments).EndInit();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClearanceRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlFilterCard;
        private Panel pnlActionBar;
        private Panel pnlLeft;
        private Panel pnlRight;
        private Splitter splitter;
        private Label lblTitle;
        private Label lblSelectedTerm;
        private Label lblStudent;
        private Label lblSearch;
        private Label lblChecklist;
        private Label lblRecords;
        private ComboBox cboAcademicTerm;
        private TextBox txtSearch;
        private Button btnLoadChecklist;
        private Button btnAdd;
        private Button btnDeleteSelected;
        private Button btnClear;
        private DataGridView dgvClearanceDepartments;
        private DataGridView dgvClearanceRecords;
        private Button btnBack;
        private TextBox txtSearchBox;
    }
}

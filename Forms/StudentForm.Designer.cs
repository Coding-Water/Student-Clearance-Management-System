namespace Student_Clearance_Management_System.Forms
{
    partial class StudentForm
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
            pnlInputCard = new Panel();
            lblID = new Label();
            txtID = new TextBox();
            lblFirst = new Label();
            txtFirst = new TextBox();
            lblLast = new Label();
            txtLast = new TextBox();
            lblCourse = new Label();
            cboCourse = new ComboBox();
            lblYear = new Label();
            cboYearLevel = new ComboBox();
            lblSection = new Label();
            txtSection = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvStudents = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1060, 60);
            pnlHeader.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(980, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👩‍🎓  Student Management";
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
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 60);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlInputCard
            // 
            pnlInputCard.BackColor = Color.White;
            pnlInputCard.Controls.Add(lblID);
            pnlInputCard.Controls.Add(txtID);
            pnlInputCard.Controls.Add(lblFirst);
            pnlInputCard.Controls.Add(txtFirst);
            pnlInputCard.Controls.Add(lblLast);
            pnlInputCard.Controls.Add(txtLast);
            pnlInputCard.Controls.Add(lblCourse);
            pnlInputCard.Controls.Add(cboCourse);
            pnlInputCard.Controls.Add(lblYear);
            pnlInputCard.Controls.Add(cboYearLevel);
            pnlInputCard.Controls.Add(lblSection);
            pnlInputCard.Controls.Add(txtSection);
            pnlInputCard.Controls.Add(lblContact);
            pnlInputCard.Controls.Add(txtContact);
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Location = new Point(0, 60);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(21, 16, 21, 8);
            pnlInputCard.Size = new Size(1060, 173);
            pnlInputCard.TabIndex = 12;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(55, 65, 81);
            lblID.Location = new Point(21, 16);
            lblID.Name = "lblID";
            lblID.Size = new Size(88, 20);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID:";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(21, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(171, 30);
            txtID.TabIndex = 1;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirst.ForeColor = Color.FromArgb(55, 65, 81);
            lblFirst.Location = new Point(215, 16);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(90, 20);
            lblFirst.TabIndex = 2;
            lblFirst.Text = "First Name:";
            // 
            // txtFirst
            // 
            txtFirst.BorderStyle = BorderStyle.FixedSingle;
            txtFirst.Font = new Font("Segoe UI", 10F);
            txtFirst.Location = new Point(215, 40);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(240, 30);
            txtFirst.TabIndex = 2;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLast.ForeColor = Color.FromArgb(55, 65, 81);
            lblLast.Location = new Point(478, 16);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(88, 20);
            lblLast.TabIndex = 4;
            lblLast.Text = "Last Name:";
            // 
            // txtLast
            // 
            txtLast.BorderStyle = BorderStyle.FixedSingle;
            txtLast.Font = new Font("Segoe UI", 10F);
            txtLast.Location = new Point(478, 40);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(240, 30);
            txtLast.TabIndex = 3;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(55, 65, 81);
            lblCourse.Location = new Point(741, 16);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(61, 20);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Course:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 10F);
            cboCourse.Location = new Point(741, 40);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(297, 31);
            cboCourse.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(55, 65, 81);
            lblYear.Location = new Point(21, 91);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(83, 20);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year Level:";
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Font = new Font("Segoe UI", 10F);
            cboYearLevel.Location = new Point(21, 115);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(171, 31);
            cboYearLevel.TabIndex = 5;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSection.ForeColor = Color.FromArgb(55, 65, 81);
            lblSection.Location = new Point(215, 91);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(64, 20);
            lblSection.TabIndex = 10;
            lblSection.Text = "Section:";
            // 
            // txtSection
            // 
            txtSection.BorderStyle = BorderStyle.FixedSingle;
            txtSection.Font = new Font("Segoe UI", 10F);
            txtSection.Location = new Point(215, 115);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(171, 30);
            txtSection.TabIndex = 6;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(55, 65, 81);
            lblContact.Location = new Point(409, 91);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(130, 20);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(409, 115);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(240, 30);
            txtContact.TabIndex = 7;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 233);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(21, 11, 21, 11);
            pnlButtons.Size = new Size(1060, 59);
            pnlButtons.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(432, 11);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 37);
            btnClear.TabIndex = 6;
            btnClear.Text = "↺  Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(295, 11);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "🗑️  Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(79, 70, 229);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(158, 11);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 37);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "✏️  Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(79, 70, 229);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(21, 11);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕  Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 292);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(21, 8, 21, 8);
            pnlSearch.Size = new Size(1060, 51);
            pnlSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(92, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or student ID...";
            txtSearch.Size = new Size(320, 30);
            txtSearch.TabIndex = 8;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(55, 65, 81);
            lblSearch.Location = new Point(21, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 21);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search:";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 343);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1060, 337);
            dgvStudents.TabIndex = 9;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 680);
            Controls.Add(dgvStudents);
            Controls.Add(pnlSearch);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management — Clearance System";
            Load += StudentForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInputCard;
        private Panel pnlButtons;
        private Panel pnlSearch;
        private Label lblTitle;
        private Label lblID;
        private Label lblFirst;
        private Label lblLast;
        private Label lblCourse;
        private Label lblYear;
        private Label lblSection;
        private Label lblContact;
        private Label lblSearch;
        private TextBox txtID;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtSection;
        private TextBox txtContact;
        private TextBox txtSearch;
        private DataGridView dgvStudents;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnBack;
        private ComboBox cboCourse;
        private ComboBox cboYearLevel;
    }
}
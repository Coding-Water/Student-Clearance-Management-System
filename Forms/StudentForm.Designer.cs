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
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(948, 45);
            pnlHeader.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(878, 45);
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
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 45);
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
            pnlInputCard.Location = new Point(0, 45);
            pnlInputCard.Margin = new Padding(3, 2, 3, 2);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(18, 12, 18, 6);
            pnlInputCard.Size = new Size(948, 130);
            pnlInputCard.TabIndex = 12;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(55, 65, 81);
            lblID.Location = new Point(18, 12);
            lblID.Name = "lblID";
            lblID.Size = new Size(71, 15);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID:";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(18, 30);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 25);
            txtID.TabIndex = 1;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirst.ForeColor = Color.FromArgb(55, 65, 81);
            lblFirst.Location = new Point(188, 12);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(73, 15);
            lblFirst.TabIndex = 2;
            lblFirst.Text = "First Name:";
            // 
            // txtFirst
            // 
            txtFirst.BorderStyle = BorderStyle.FixedSingle;
            txtFirst.Font = new Font("Segoe UI", 10F);
            txtFirst.Location = new Point(188, 30);
            txtFirst.Margin = new Padding(3, 2, 3, 2);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(210, 25);
            txtFirst.TabIndex = 2;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLast.ForeColor = Color.FromArgb(55, 65, 81);
            lblLast.Location = new Point(418, 12);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(70, 15);
            lblLast.TabIndex = 4;
            lblLast.Text = "Last Name:";
            // 
            // txtLast
            // 
            txtLast.BorderStyle = BorderStyle.FixedSingle;
            txtLast.Font = new Font("Segoe UI", 10F);
            txtLast.Location = new Point(418, 30);
            txtLast.Margin = new Padding(3, 2, 3, 2);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(210, 25);
            txtLast.TabIndex = 3;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(55, 65, 81);
            lblCourse.Location = new Point(648, 12);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(50, 15);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Course:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 10F);
            cboCourse.Location = new Point(648, 30);
            cboCourse.Margin = new Padding(3, 2, 3, 2);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(260, 25);
            cboCourse.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(55, 65, 81);
            lblYear.Location = new Point(18, 68);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(68, 15);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year Level:";
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Font = new Font("Segoe UI", 10F);
            cboYearLevel.Location = new Point(18, 86);
            cboYearLevel.Margin = new Padding(3, 2, 3, 2);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(150, 25);
            cboYearLevel.TabIndex = 5;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSection.ForeColor = Color.FromArgb(55, 65, 81);
            lblSection.Location = new Point(188, 68);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(53, 15);
            lblSection.TabIndex = 10;
            lblSection.Text = "Section:";
            // 
            // txtSection
            // 
            txtSection.BorderStyle = BorderStyle.FixedSingle;
            txtSection.Font = new Font("Segoe UI", 10F);
            txtSection.Location = new Point(188, 86);
            txtSection.Margin = new Padding(3, 2, 3, 2);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(150, 25);
            txtSection.TabIndex = 6;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(55, 65, 81);
            lblContact.Location = new Point(358, 68);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(101, 15);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(358, 86);
            txtContact.Margin = new Padding(3, 2, 3, 2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(210, 25);
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
            pnlButtons.Location = new Point(0, 175);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(18, 8, 18, 8);
            pnlButtons.Size = new Size(948, 44);
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
            btnClear.Location = new Point(378, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 28);
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
            btnDelete.Location = new Point(258, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 28);
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
            btnUpdate.Location = new Point(138, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 28);
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
            btnAdd.Location = new Point(18, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 28);
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
            pnlSearch.Location = new Point(0, 219);
            pnlSearch.Margin = new Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(18, 6, 18, 6);
            pnlSearch.Size = new Size(948, 38);
            pnlSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(70, 8);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or student ID...";
            txtSearch.Size = new Size(280, 25);
            txtSearch.TabIndex = 8;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(55, 65, 81);
            lblSearch.Location = new Point(18, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(52, 17);
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
            dgvStudents.Location = new Point(0, 257);
            dgvStudents.Margin = new Padding(3, 2, 3, 2);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(948, 253);
            dgvStudents.TabIndex = 9;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 510);
            Controls.Add(dgvStudents);
            Controls.Add(pnlSearch);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
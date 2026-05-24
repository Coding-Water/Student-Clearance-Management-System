namespace Student_Clearance_Management_System.Forms
{
    partial class AcademicTermForm
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
            lblTermID = new Label();
            txtTermID = new TextBox();
            lblSchoolYear = new Label();
            txtSchoolYear = new TextBox();
            lblSemester = new Label();
            cboSemester = new ComboBox();
            lblActive = new Label();
            chkIsActive = new CheckBox();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnSetActive = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvAcademicTerms = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAcademicTerms).BeginInit();
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
            pnlHeader.Size = new Size(1061, 60);
            pnlHeader.TabIndex = 12;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(981, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📅  Academic Term Management";
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
            pnlInputCard.Controls.Add(lblTermID);
            pnlInputCard.Controls.Add(txtTermID);
            pnlInputCard.Controls.Add(lblSchoolYear);
            pnlInputCard.Controls.Add(txtSchoolYear);
            pnlInputCard.Controls.Add(lblSemester);
            pnlInputCard.Controls.Add(cboSemester);
            pnlInputCard.Controls.Add(lblActive);
            pnlInputCard.Controls.Add(chkIsActive);
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Location = new Point(0, 60);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(21, 12, 21, 8);
            pnlInputCard.Size = new Size(1061, 131);
            pnlInputCard.TabIndex = 11;
            // 
            // lblTermID
            // 
            lblTermID.Location = new Point(-1, 0);
            lblTermID.Name = "lblTermID";
            lblTermID.Size = new Size(101, 23);
            lblTermID.TabIndex = 0;
            lblTermID.Visible = false;
            // 
            // txtTermID
            // 
            txtTermID.Location = new Point(0, 0);
            txtTermID.Name = "txtTermID";
            txtTermID.ReadOnly = true;
            txtTermID.Size = new Size(100, 27);
            txtTermID.TabIndex = 1;
            txtTermID.Visible = false;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSchoolYear.ForeColor = Color.FromArgb(55, 65, 81);
            lblSchoolYear.Location = new Point(21, 12);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(94, 20);
            lblSchoolYear.TabIndex = 2;
            lblSchoolYear.Text = "School Year:";
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.BorderStyle = BorderStyle.FixedSingle;
            txtSchoolYear.Font = new Font("Segoe UI", 10.5F);
            txtSchoolYear.Location = new Point(21, 33);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.PlaceholderText = "e.g. 2024-2025";
            txtSchoolYear.Size = new Size(220, 31);
            txtSchoolYear.TabIndex = 1;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSemester.ForeColor = Color.FromArgb(55, 65, 81);
            lblSemester.Location = new Point(261, 12);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(79, 20);
            lblSemester.TabIndex = 3;
            lblSemester.Text = "Semester:";
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new Font("Segoe UI", 10.5F);
            cboSemester.Location = new Point(261, 33);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(260, 31);
            cboSemester.TabIndex = 2;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActive.ForeColor = Color.FromArgb(55, 65, 81);
            lblActive.Location = new Point(21, 77);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(156, 20);
            lblActive.TabIndex = 4;
            lblActive.Text = "Mark as Active Term:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(181, 76);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(78, 27);
            chkIsActive.TabIndex = 3;
            chkIsActive.Text = "Active";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnSetActive);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 191);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(21, 11, 21, 11);
            pnlButtons.Size = new Size(1061, 59);
            pnlButtons.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(520, 11);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "↺  Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSetActive
            // 
            btnSetActive.BackColor = Color.FromArgb(22, 163, 74);
            btnSetActive.Cursor = Cursors.Hand;
            btnSetActive.FlatAppearance.BorderSize = 0;
            btnSetActive.FlatStyle = FlatStyle.Flat;
            btnSetActive.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSetActive.ForeColor = Color.White;
            btnSetActive.Location = new Point(395, 11);
            btnSetActive.Name = "btnSetActive";
            btnSetActive.Size = new Size(115, 36);
            btnSetActive.TabIndex = 7;
            btnSetActive.Text = "✅  Set Active";
            btnSetActive.UseVisualStyleBackColor = false;
            btnSetActive.Click += btnSetActive_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(270, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 36);
            btnDelete.TabIndex = 6;
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
            btnUpdate.Location = new Point(145, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 36);
            btnUpdate.TabIndex = 5;
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
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "➕  Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAcademicTerms
            // 
            dgvAcademicTerms.AllowUserToAddRows = false;
            dgvAcademicTerms.AllowUserToDeleteRows = false;
            dgvAcademicTerms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcademicTerms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcademicTerms.Dock = DockStyle.Fill;
            dgvAcademicTerms.Location = new Point(0, 250);
            dgvAcademicTerms.MultiSelect = false;
            dgvAcademicTerms.Name = "dgvAcademicTerms";
            dgvAcademicTerms.ReadOnly = true;
            dgvAcademicTerms.RowHeadersWidth = 51;
            dgvAcademicTerms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcademicTerms.Size = new Size(1061, 350);
            dgvAcademicTerms.TabIndex = 9;
            dgvAcademicTerms.CellClick += dgvAcademicTerms_CellClick;
            // 
            // AcademicTermForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 600);
            Controls.Add(dgvAcademicTerms);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AcademicTermForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academic Term Management — Clearance System";
            Load += AcademicTermForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAcademicTerms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInputCard;
        private Panel pnlButtons;
        private Label lblTitle;
        private Label lblTermID;
        private Label lblSchoolYear;
        private Label lblSemester;
        private Label lblActive;
        private TextBox txtTermID;
        private TextBox txtSchoolYear;
        private ComboBox cboSemester;
        private CheckBox chkIsActive;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSetActive;
        private Button btnClear;
        private DataGridView dgvAcademicTerms;
        private Button btnBack;
    }
}

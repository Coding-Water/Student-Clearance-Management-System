namespace Student_Clearance_Management_System.Forms
{
    partial class AcademicTermForm
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
            cboSemester = new ComboBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvAcademicTerms = new DataGridView();
            txtSchoolYear = new TextBox();
            txtTermID = new TextBox();
            lblActive = new Label();
            lblSemester = new Label();
            lblSchoolYear = new Label();
            lblTermID = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            btnSetActive = new Button();
            chkIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvAcademicTerms).BeginInit();
            SuspendLayout();
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new Font("Segoe UI", 15F);
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(128, 174);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(224, 36);
            cboSemester.TabIndex = 44;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(633, 294);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F);
            btnUpdate.Location = new Point(335, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F);
            btnDelete.Location = new Point(180, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(18, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAcademicTerms
            // 
            dgvAcademicTerms.AllowUserToAddRows = false;
            dgvAcademicTerms.AllowUserToDeleteRows = false;
            dgvAcademicTerms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcademicTerms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcademicTerms.Location = new Point(18, 363);
            dgvAcademicTerms.MultiSelect = false;
            dgvAcademicTerms.Name = "dgvAcademicTerms";
            dgvAcademicTerms.ReadOnly = true;
            dgvAcademicTerms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcademicTerms.Size = new Size(762, 338);
            dgvAcademicTerms.TabIndex = 38;
            dgvAcademicTerms.CellClick += dgvAcademicTerms_CellClick;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 15F);
            txtSchoolYear.Location = new Point(128, 126);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(227, 34);
            txtSchoolYear.TabIndex = 34;
            // 
            // txtTermID
            // 
            txtTermID.Font = new Font("Segoe UI", 15F);
            txtTermID.Location = new Point(128, 83);
            txtTermID.Name = "txtTermID";
            txtTermID.ReadOnly = true;
            txtTermID.Size = new Size(227, 34);
            txtTermID.TabIndex = 33;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 15F);
            lblActive.Location = new Point(15, 218);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(70, 28);
            lblActive.TabIndex = 28;
            lblActive.Text = "Active:";
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 15F);
            lblSemester.Location = new Point(12, 174);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(96, 28);
            lblSemester.TabIndex = 27;
            lblSemester.Text = "Semester:";
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 15F);
            lblSchoolYear.Location = new Point(12, 129);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(117, 28);
            lblSchoolYear.TabIndex = 26;
            lblSchoolYear.Text = "School Year:";
            // 
            // lblTermID
            // 
            lblTermID.AutoSize = true;
            lblTermID.Font = new Font("Segoe UI", 15F);
            lblTermID.Location = new Point(12, 86);
            lblTermID.Name = "lblTermID";
            lblTermID.Size = new Size(82, 28);
            lblTermID.TabIndex = 25;
            lblTermID.Text = "Term ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(180, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 28);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Academic Term Management";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 41);
            btnBack.TabIndex = 45;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSetActive
            // 
            btnSetActive.Font = new Font("Segoe UI", 15F);
            btnSetActive.Location = new Point(485, 294);
            btnSetActive.Name = "btnSetActive";
            btnSetActive.Size = new Size(130, 40);
            btnSetActive.TabIndex = 46;
            btnSetActive.Text = "Set Active";
            btnSetActive.UseVisualStyleBackColor = true;
            btnSetActive.Click += btnSetActive_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 16F);
            chkIsActive.Location = new Point(128, 218);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(91, 34);
            chkIsActive.TabIndex = 47;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // AcademicTermForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 738);
            Controls.Add(chkIsActive);
            Controls.Add(btnSetActive);
            Controls.Add(btnBack);
            Controls.Add(cboSemester);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvAcademicTerms);
            Controls.Add(txtSchoolYear);
            Controls.Add(txtTermID);
            Controls.Add(lblActive);
            Controls.Add(lblSemester);
            Controls.Add(lblSchoolYear);
            Controls.Add(lblTermID);
            Controls.Add(lblTitle);
            Name = "AcademicTermForm";
            Text = "AcademicForm";
            Load += AcademicTermForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAcademicTerms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSemester;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvAcademicTerms;
        private TextBox txtSchoolYear;
        private TextBox txtTermID;
        private Label lblActive;
        private Label lblSemester;
        private Label lblSchoolYear;
        private Label lblTermID;
        private Label lblTitle;
        private Button btnBack;
        private Button btnSetActive;
        private CheckBox chkIsActive;
    }
}
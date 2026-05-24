namespace Student_Clearance_Management_System.Forms
{
    partial class ClearanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearanceForm));
            btnClear = new Button();
            btnDeleteSelected = new Button();
            btnAdd = new Button();
            dgvClearanceDepartments = new DataGridView();
            lblTitle = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblStudent = new Label();
            cboStudent = new ComboBox();
            lblSelectedTerm = new Label();
            lblChecklist = new Label();
            lblRecords = new Label();
            btnLoadChecklist = new Button();
            dgvClearanceRecords = new DataGridView();
            cboAcademicTerm = new ComboBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceRecords).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(224, 344);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(186, 53);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Font = new Font("Segoe UI", 15F);
            btnDeleteSelected.Location = new Point(339, 450);
            btnDeleteSelected.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(202, 53);
            btnDeleteSelected.TabIndex = 41;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(417, 344);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 53);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Save All";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSaveAll_Click;
            // 
            // dgvClearanceDepartments
            // 
            dgvClearanceDepartments.AllowUserToAddRows = false;
            dgvClearanceDepartments.AllowUserToDeleteRows = false;
            dgvClearanceDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClearanceDepartments.Location = new Point(16, 521);
            dgvClearanceDepartments.Margin = new Padding(3, 4, 3, 4);
            dgvClearanceDepartments.MultiSelect = false;
            dgvClearanceDepartments.Name = "dgvClearanceDepartments";
            dgvClearanceDepartments.RowHeadersWidth = 51;
            dgvClearanceDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceDepartments.Size = new Size(1430, 396);
            dgvClearanceDepartments.TabIndex = 38;
            dgvClearanceDepartments.CurrentCellDirtyStateChanged += dgvClearanceDepartments_CurrentCellDirtyStateChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(217, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 35);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Clearance Processing";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(179, 264);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(347, 41);
            txtSearch.TabIndex = 45;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15F);
            lblSearch.Location = new Point(16, 264);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(94, 35);
            lblSearch.TabIndex = 44;
            lblSearch.Text = "Search:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 15F);
            lblStudent.Location = new Point(16, 176);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(104, 35);
            lblStudent.TabIndex = 26;
            lblStudent.Text = "Student:";
            // 
            // cboStudent
            // 
            cboStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudent.Font = new Font("Segoe UI", 15F);
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(179, 176);
            cboStudent.Margin = new Padding(3, 4, 3, 4);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(347, 43);
            cboStudent.TabIndex = 46;
            // 
            // lblSelectedTerm
            // 
            lblSelectedTerm.AutoSize = true;
            lblSelectedTerm.Font = new Font("Segoe UI", 15F);
            lblSelectedTerm.Location = new Point(16, 99);
            lblSelectedTerm.Name = "lblSelectedTerm";
            lblSelectedTerm.Size = new Size(175, 35);
            lblSelectedTerm.TabIndex = 50;
            lblSelectedTerm.Text = "Selected Term:";
            // 
            // lblChecklist
            // 
            lblChecklist.AutoSize = true;
            lblChecklist.Font = new Font("Segoe UI", 15F);
            lblChecklist.Location = new Point(565, 32);
            lblChecklist.Name = "lblChecklist";
            lblChecklist.Size = new Size(232, 35);
            lblChecklist.TabIndex = 52;
            lblChecklist.Text = "Clearance Checklist:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 15F);
            lblRecords.Location = new Point(16, 459);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(317, 35);
            lblRecords.TabIndex = 53;
            lblRecords.Text = "Clearance Records / Report";
            // 
            // btnLoadChecklist
            // 
            btnLoadChecklist.Font = new Font("Segoe UI", 15F);
            btnLoadChecklist.Location = new Point(14, 340);
            btnLoadChecklist.Margin = new Padding(3, 4, 3, 4);
            btnLoadChecklist.Name = "btnLoadChecklist";
            btnLoadChecklist.Size = new Size(203, 57);
            btnLoadChecklist.TabIndex = 54;
            btnLoadChecklist.Text = "Load Checklist";
            btnLoadChecklist.UseVisualStyleBackColor = true;
            btnLoadChecklist.Click += btnLoadChecklist_Click;
            // 
            // dgvClearanceRecords
            // 
            dgvClearanceRecords.AllowUserToAddRows = false;
            dgvClearanceRecords.AllowUserToDeleteRows = false;
            dgvClearanceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClearanceRecords.Location = new Point(565, 73);
            dgvClearanceRecords.Margin = new Padding(3, 4, 3, 4);
            dgvClearanceRecords.MultiSelect = false;
            dgvClearanceRecords.Name = "dgvClearanceRecords";
            dgvClearanceRecords.ReadOnly = true;
            dgvClearanceRecords.RowHeadersWidth = 51;
            dgvClearanceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceRecords.Size = new Size(895, 395);
            dgvClearanceRecords.TabIndex = 55;
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 15F);
            cboAcademicTerm.FormattingEnabled = true;
            cboAcademicTerm.Location = new Point(179, 88);
            cboAcademicTerm.Margin = new Padding(3, 4, 3, 4);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(347, 43);
            cboAcademicTerm.TabIndex = 56;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(2, 7);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 73);
            btnBack.TabIndex = 57;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ClearanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 927);
            Controls.Add(btnBack);
            Controls.Add(cboAcademicTerm);
            Controls.Add(dgvClearanceRecords);
            Controls.Add(btnLoadChecklist);
            Controls.Add(lblRecords);
            Controls.Add(lblChecklist);
            Controls.Add(lblSelectedTerm);
            Controls.Add(cboStudent);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnAdd);
            Controls.Add(dgvClearanceDepartments);
            Controls.Add(lblStudent);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClearanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClearanceForm";
            Load += ClearanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClearanceDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDeleteSelected;
        private Button btnAdd;
        private DataGridView dgvClearanceDepartments;
        private Label lblTitle;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblStudent;
        private ComboBox cboStudent;
        private Label lblSelectedTerm;
        private Label lblChecklist;
        private Label lblRecords;
        private Button btnLoadChecklist;
        private DataGridView dgvClearanceRecords;
        private ComboBox cboAcademicTerm;
        private Button btnBack;
    }
}
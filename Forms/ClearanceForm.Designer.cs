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
            btnClear = new Button();
            btnBack = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvClearanceDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClearanceRecords).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(196, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(163, 40);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Font = new Font("Segoe UI", 15F);
            btnDeleteSelected.Location = new Point(267, 338);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(177, 40);
            btnDeleteSelected.TabIndex = 41;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(365, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 40);
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
            dgvClearanceDepartments.Location = new Point(14, 391);
            dgvClearanceDepartments.MultiSelect = false;
            dgvClearanceDepartments.Name = "dgvClearanceDepartments";
            dgvClearanceDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceDepartments.Size = new Size(1112, 297);
            dgvClearanceDepartments.TabIndex = 38;
            dgvClearanceDepartments.CurrentCellDirtyStateChanged += dgvClearanceDepartments_CurrentCellDirtyStateChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(190, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 28);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Clearance Processing";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(157, 198);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(304, 34);
            txtSearch.TabIndex = 45;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15F);
            lblSearch.Location = new Point(14, 198);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 44;
            lblSearch.Text = "Search:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 15F);
            lblStudent.Location = new Point(14, 132);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(84, 28);
            lblStudent.TabIndex = 26;
            lblStudent.Text = "Student:";
            // 
            // cboStudent
            // 
            cboStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudent.Font = new Font("Segoe UI", 15F);
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(157, 132);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(304, 36);
            cboStudent.TabIndex = 46;
            // 
            // lblSelectedTerm
            // 
            lblSelectedTerm.AutoSize = true;
            lblSelectedTerm.Font = new Font("Segoe UI", 15F);
            lblSelectedTerm.Location = new Point(14, 74);
            lblSelectedTerm.Name = "lblSelectedTerm";
            lblSelectedTerm.Size = new Size(137, 28);
            lblSelectedTerm.TabIndex = 50;
            lblSelectedTerm.Text = "Selected Term:";
            // 
            // lblChecklist
            // 
            lblChecklist.AutoSize = true;
            lblChecklist.Font = new Font("Segoe UI", 15F);
            lblChecklist.Location = new Point(494, 24);
            lblChecklist.Name = "lblChecklist";
            lblChecklist.Size = new Size(182, 28);
            lblChecklist.TabIndex = 52;
            lblChecklist.Text = "Clearance Checklist:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 15F);
            lblRecords.Location = new Point(14, 344);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(247, 28);
            lblRecords.TabIndex = 53;
            lblRecords.Text = "Clearance Records / Report";
            // 
            // btnLoadChecklist
            // 
            btnLoadChecklist.Font = new Font("Segoe UI", 15F);
            btnLoadChecklist.Location = new Point(12, 255);
            btnLoadChecklist.Name = "btnLoadChecklist";
            btnLoadChecklist.Size = new Size(178, 43);
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
            dgvClearanceRecords.Location = new Point(494, 55);
            dgvClearanceRecords.MultiSelect = false;
            dgvClearanceRecords.Name = "dgvClearanceRecords";
            dgvClearanceRecords.ReadOnly = true;
            dgvClearanceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceRecords.Size = new Size(632, 296);
            dgvClearanceRecords.TabIndex = 55;
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 15F);
            cboAcademicTerm.FormattingEnabled = true;
            cboAcademicTerm.Location = new Point(157, 66);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(304, 36);
            cboAcademicTerm.TabIndex = 56;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // ClearanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 695);
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
            Controls.Add(btnBack);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnAdd);
            Controls.Add(dgvClearanceDepartments);
            Controls.Add(lblStudent);
            Controls.Add(lblTitle);
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
        private Button btnBack;
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
    }
}
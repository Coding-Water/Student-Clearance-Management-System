namespace Student_Clearance_Management_System.Forms
{
    partial class StudentForm
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
            lblID = new Label();
            lblFirst = new Label();
            lblLast = new Label();
            lblCourse = new Label();
            lblYear = new Label();
            lblSection = new Label();
            lblContact = new Label();
            lblSearch = new Label();
            txtID = new TextBox();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            txtSection = new TextBox();
            txtContact = new TextBox();
            dgvStudents = new DataGridView();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            cboCourse = new ComboBox();
            cboYearLevel = new ComboBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(270, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 15F);
            lblID.Location = new Point(10, 63);
            lblID.Name = "lblID";
            lblID.Size = new Size(108, 28);
            lblID.TabIndex = 1;
            lblID.Text = "Student ID:";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 15F);
            lblFirst.Location = new Point(10, 106);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(110, 28);
            lblFirst.TabIndex = 2;
            lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 15F);
            lblLast.Location = new Point(10, 151);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(107, 28);
            lblLast.TabIndex = 3;
            lblLast.Text = "Last Name:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 15F);
            lblCourse.Location = new Point(13, 195);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(76, 28);
            lblCourse.TabIndex = 4;
            lblCourse.Text = "Course:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 15F);
            lblYear.Location = new Point(386, 60);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(101, 28);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year Level:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 15F);
            lblSection.Location = new Point(386, 103);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(81, 28);
            lblSection.TabIndex = 6;
            lblSection.Text = "Section:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 15F);
            lblContact.Location = new Point(386, 148);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(161, 28);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Number:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15F);
            lblSearch.Location = new Point(15, 334);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 15F);
            txtID.Location = new Point(126, 60);
            txtID.Name = "txtID";
            txtID.Size = new Size(227, 34);
            txtID.TabIndex = 9;
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 15F);
            txtFirst.Location = new Point(126, 103);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(227, 34);
            txtFirst.TabIndex = 10;
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI", 15F);
            txtLast.Location = new Point(129, 148);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(224, 34);
            txtLast.TabIndex = 11;
            // 
            // txtSection
            // 
            txtSection.Font = new Font("Segoe UI", 15F);
            txtSection.Location = new Point(553, 103);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(224, 34);
            txtSection.TabIndex = 14;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 15F);
            txtContact.Location = new Point(553, 148);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(224, 34);
            txtContact.TabIndex = 15;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(15, 385);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(762, 285);
            dgvStudents.TabIndex = 16;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(95, 334);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(224, 34);
            txtSearch.TabIndex = 17;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(114, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F);
            btnDelete.Location = new Point(250, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F);
            btnUpdate.Location = new Point(386, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(522, 263);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 15F);
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(129, 195);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(648, 36);
            cboCourse.TabIndex = 22;
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Font = new Font("Segoe UI", 15F);
            cboYearLevel.FormattingEnabled = true;
            cboYearLevel.Location = new Point(553, 52);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(224, 36);
            cboYearLevel.TabIndex = 23;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(15, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 41);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 682);
            Controls.Add(btnBack);
            Controls.Add(cboYearLevel);
            Controls.Add(cboCourse);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudents);
            Controls.Add(txtContact);
            Controls.Add(txtSection);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(txtID);
            Controls.Add(lblSearch);
            Controls.Add(lblContact);
            Controls.Add(lblSection);
            Controls.Add(lblYear);
            Controls.Add(lblCourse);
            Controls.Add(lblLast);
            Controls.Add(lblFirst);
            Controls.Add(lblID);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dgvStudents;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private ComboBox cboCourse;
        private ComboBox cboYearLevel;
        private Button btnBack;
    }
}
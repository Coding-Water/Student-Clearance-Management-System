namespace Student_Clearance_Management_System.Forms
{
    partial class CourseForm
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
            lblCourseID = new Label();
            lblCourseCode = new Label();
            lblCourseName = new Label();
            txtCourseID = new TextBox();
            txtCourseCode = new TextBox();
            txtCourseName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCourses = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(243, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Management";
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Font = new Font("Segoe UI", 15F);
            lblCourseID.Location = new Point(25, 61);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(100, 28);
            lblCourseID.TabIndex = 1;
            lblCourseID.Text = "Course ID:";
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Font = new Font("Segoe UI", 15F);
            lblCourseCode.Location = new Point(25, 103);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(127, 28);
            lblCourseCode.TabIndex = 2;
            lblCourseCode.Text = "Course Code:";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Segoe UI", 15F);
            lblCourseName.Location = new Point(25, 150);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(133, 28);
            lblCourseName.TabIndex = 3;
            lblCourseName.Text = "Course Name:";
            // 
            // txtCourseID
            // 
            txtCourseID.Font = new Font("Segoe UI", 15F);
            txtCourseID.Location = new Point(163, 58);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.ReadOnly = true;
            txtCourseID.Size = new Size(157, 34);
            txtCourseID.TabIndex = 5;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Font = new Font("Segoe UI", 15F);
            txtCourseCode.Location = new Point(163, 103);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(157, 34);
            txtCourseCode.TabIndex = 6;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 15F);
            txtCourseName.Location = new Point(163, 150);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(499, 34);
            txtCourseName.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(383, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(532, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F);
            btnUpdate.Location = new Point(383, 101);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F);
            btnDelete.Location = new Point(532, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(25, 201);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(655, 198);
            dgvCourses.TabIndex = 12;
            dgvCourses.CellClick += dgvCourses_CellClick;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(22, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 41);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 416);
            Controls.Add(btnBack);
            Controls.Add(dgvCourses);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseCode);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseName);
            Controls.Add(lblCourseCode);
            Controls.Add(lblCourseID);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCourseID;
        private Label lblCourseCode;
        private Label lblCourseName;
        private TextBox txtCourseID;
        private TextBox txtCourseCode;
        private TextBox txtCourseName;
        private Button btnAdd;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCourses;
        private Button btnBack;
    }
}
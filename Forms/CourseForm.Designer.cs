namespace Student_Clearance_Management_System.Forms
{
    partial class CourseForm
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
            lblCourseID = new Label();
            txtCourseID = new TextBox();
            lblCourseCode = new Label();
            txtCourseCode = new TextBox();
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvCourses = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
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
            pnlHeader.Size = new Size(893, 45);
            pnlHeader.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(823, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚  Course Management";
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
            pnlInputCard.Controls.Add(lblCourseID);
            pnlInputCard.Controls.Add(txtCourseID);
            pnlInputCard.Controls.Add(lblCourseCode);
            pnlInputCard.Controls.Add(txtCourseCode);
            pnlInputCard.Controls.Add(lblCourseName);
            pnlInputCard.Controls.Add(txtCourseName);
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Location = new Point(0, 45);
            pnlInputCard.Margin = new Padding(3, 2, 3, 2);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(18, 9, 18, 6);
            pnlInputCard.Size = new Size(893, 105);
            pnlInputCard.TabIndex = 9;
            // 
            // lblCourseID
            // 
            lblCourseID.Location = new Point(0, 0);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(88, 17);
            lblCourseID.TabIndex = 0;
            lblCourseID.Visible = false;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(0, 0);
            txtCourseID.Margin = new Padding(3, 2, 3, 2);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.ReadOnly = true;
            txtCourseID.Size = new Size(88, 23);
            txtCourseID.TabIndex = 1;
            txtCourseID.Visible = false;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCourseCode.ForeColor = Color.FromArgb(55, 65, 81);
            lblCourseCode.Location = new Point(18, 9);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(79, 15);
            lblCourseCode.TabIndex = 2;
            lblCourseCode.Text = "Course Code:";
            // 
            // txtCourseCode
            // 
            txtCourseCode.BorderStyle = BorderStyle.FixedSingle;
            txtCourseCode.Font = new Font("Segoe UI", 10.5F);
            txtCourseCode.Location = new Point(18, 22);
            txtCourseCode.Margin = new Padding(3, 2, 3, 2);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.PlaceholderText = "e.g. BSIT";
            txtCourseCode.Size = new Size(175, 26);
            txtCourseCode.TabIndex = 1;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCourseName.ForeColor = Color.FromArgb(55, 65, 81);
            lblCourseName.Location = new Point(210, 9);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(84, 15);
            lblCourseName.TabIndex = 3;
            lblCourseName.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            txtCourseName.BorderStyle = BorderStyle.FixedSingle;
            txtCourseName.Font = new Font("Segoe UI", 10.5F);
            txtCourseName.Location = new Point(210, 22);
            txtCourseName.Margin = new Padding(3, 2, 3, 2);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.PlaceholderText = "e.g. Bachelor of Science in Information Technology";
            txtCourseName.Size = new Size(420, 26);
            txtCourseName.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 150);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(18, 8, 18, 8);
            pnlButtons.Size = new Size(893, 44);
            pnlButtons.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(338, 8);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 27);
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
            btnDelete.Location = new Point(231, 8);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 27);
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
            btnUpdate.Location = new Point(124, 8);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 27);
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
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 27);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕  Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.Location = new Point(0, 194);
            dgvCourses.Margin = new Padding(3, 2, 3, 2);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(893, 226);
            dgvCourses.TabIndex = 7;
            dgvCourses.CellClick += dgvCourses_CellClick;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 420);
            Controls.Add(dgvCourses);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management — Clearance System";
            Load += CourseForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInputCard;
        private Panel pnlButtons;
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

namespace Student_Clearance_Management_System.Forms
{
    partial class CourseRequirementForm
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
            lblCourse = new Label();
            cboCourse = new ComboBox();
            lblInstruction = new Label();
            pnlButtons = new Panel();
            btnRefresh = new Button();
            btnSaveRequirements = new Button();
            dgvRequirements = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFilterCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
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
            pnlHeader.Size = new Size(898, 45);
            pnlHeader.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(828, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "⚙️  Course Department Requirements";
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
            pnlFilterCard.Controls.Add(lblCourse);
            pnlFilterCard.Controls.Add(cboCourse);
            pnlFilterCard.Controls.Add(lblInstruction);
            pnlFilterCard.Dock = DockStyle.Top;
            pnlFilterCard.Location = new Point(0, 45);
            pnlFilterCard.Margin = new Padding(3, 2, 3, 2);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Padding = new Padding(18, 9, 18, 6);
            pnlFilterCard.Size = new Size(898, 82);
            pnlFilterCard.TabIndex = 6;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(55, 65, 81);
            lblCourse.Location = new Point(18, 9);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(86, 15);
            lblCourse.TabIndex = 0;
            lblCourse.Text = "Select Course:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 10.5F);
            cboCourse.Location = new Point(18, 22);
            cboCourse.Margin = new Padding(3, 2, 3, 2);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(596, 27);
            cboCourse.TabIndex = 1;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblInstruction.ForeColor = Color.FromArgb(107, 114, 128);
            lblInstruction.Location = new Point(18, 54);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(426, 15);
            lblInstruction.TabIndex = 2;
            lblInstruction.Text = "✏️  Check the departments that are required for clearance in the selected course.";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlButtons.Controls.Add(btnRefresh);
            pnlButtons.Controls.Add(btnSaveRequirements);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 127);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(18, 8, 18, 8);
            pnlButtons.Size = new Size(898, 44);
            pnlButtons.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(107, 114, 128);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(166, 8);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 27);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSaveRequirements
            // 
            btnSaveRequirements.BackColor = Color.FromArgb(79, 70, 229);
            btnSaveRequirements.Cursor = Cursors.Hand;
            btnSaveRequirements.FlatAppearance.BorderSize = 0;
            btnSaveRequirements.FlatStyle = FlatStyle.Flat;
            btnSaveRequirements.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSaveRequirements.ForeColor = Color.White;
            btnSaveRequirements.Location = new Point(18, 8);
            btnSaveRequirements.Margin = new Padding(3, 2, 3, 2);
            btnSaveRequirements.Name = "btnSaveRequirements";
            btnSaveRequirements.Size = new Size(140, 27);
            btnSaveRequirements.TabIndex = 2;
            btnSaveRequirements.Text = "💾  Save Requirements";
            btnSaveRequirements.UseVisualStyleBackColor = false;
            btnSaveRequirements.Click += btnSaveRequirements_Click;
            // 
            // dgvRequirements
            // 
            dgvRequirements.AllowUserToAddRows = false;
            dgvRequirements.AllowUserToDeleteRows = false;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequirements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequirements.Dock = DockStyle.Fill;
            dgvRequirements.Location = new Point(0, 171);
            dgvRequirements.Margin = new Padding(3, 2, 3, 2);
            dgvRequirements.MultiSelect = false;
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(898, 294);
            dgvRequirements.TabIndex = 4;
            dgvRequirements.CurrentCellDirtyStateChanged += dgvRequirements_CurrentCellDirtyStateChanged;
            // 
            // CourseRequirementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 465);
            Controls.Add(dgvRequirements);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFilterCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CourseRequirementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Requirements — Clearance System";
            Load += CourseRequirementForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilterCard.ResumeLayout(false);
            pnlFilterCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlFilterCard;
        private Panel pnlButtons;
        private Label lblTitle;
        private Label lblCourse;
        private Label lblInstruction;
        private ComboBox cboCourse;
        private Button btnSaveRequirements;
        private Button btnRefresh;
        private DataGridView dgvRequirements;
        private Button btnBack;
    }
}
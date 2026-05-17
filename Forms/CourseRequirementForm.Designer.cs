namespace Student_Clearance_Management_System.Forms
{
    partial class CourseRequirementForm
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
            cboCourse = new ComboBox();
            btnRefresh = new Button();
            btnSaveRequirements = new Button();
            dgvRequirements = new DataGridView();
            lblCourse = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            lblInstruction = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
            SuspendLayout();
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 15F);
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(104, 84);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(600, 36);
            cboCourse.TabIndex = 44;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.Location = new Point(158, 488);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 40);
            btnRefresh.TabIndex = 41;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSaveRequirements
            // 
            btnSaveRequirements.Font = new Font("Segoe UI", 15F);
            btnSaveRequirements.Location = new Point(22, 488);
            btnSaveRequirements.Name = "btnSaveRequirements";
            btnSaveRequirements.Size = new Size(130, 40);
            btnSaveRequirements.TabIndex = 40;
            btnSaveRequirements.Text = "Save Requirements";
            btnSaveRequirements.UseVisualStyleBackColor = true;
            btnSaveRequirements.Click += btnSaveRequirements_Click;
            // 
            // dgvRequirements
            // 
            dgvRequirements.AllowUserToAddRows = false;
            dgvRequirements.AllowUserToDeleteRows = false;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequirements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequirements.Location = new Point(22, 176);
            dgvRequirements.MultiSelect = false;
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(762, 289);
            dgvRequirements.TabIndex = 38;
            dgvRequirements.CurrentCellDirtyStateChanged += dgvRequirements_CurrentCellDirtyStateChanged;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 15F);
            lblCourse.Location = new Point(22, 87);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(76, 28);
            lblCourse.TabIndex = 28;
            lblCourse.Text = "Course:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(223, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 28);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Course Department Requirements";
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
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 15F);
            lblInstruction.Location = new Point(22, 133);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(391, 28);
            lblInstruction.TabIndex = 46;
            lblInstruction.Text = "Check departments required for this course:";
            // 
            // CourseRequirementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 553);
            Controls.Add(lblInstruction);
            Controls.Add(btnBack);
            Controls.Add(cboCourse);
            Controls.Add(btnRefresh);
            Controls.Add(btnSaveRequirements);
            Controls.Add(dgvRequirements);
            Controls.Add(lblCourse);
            Controls.Add(lblTitle);
            Name = "CourseRequirementForm";
            Text = "CourseRequirementForm";
            Load += CourseRequirementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCourse;
        private Button btnRefresh;
        private Button btnSaveRequirements;
        private DataGridView dgvRequirements;
        private Label lblCourse;
        private Label lblTitle;
        private Button btnBack;
        private Label lblInstruction;
    }
}
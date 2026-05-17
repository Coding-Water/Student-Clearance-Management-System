namespace Student_Clearance_Management_System.Forms
{
    partial class DepartmentForm
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
            dgvDepartments = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            txtDepartmentName = new TextBox();
            txtDepartmentID = new TextBox();
            lblDepartmentName = new Label();
            lblDepartmentID = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Location = new Point(23, 183);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(669, 216);
            dgvDepartments.TabIndex = 24;
            dgvDepartments.CellClick += dgvDepartments_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F);
            btnDelete.Location = new Point(562, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F);
            btnUpdate.Location = new Point(413, 123);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(562, 123);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(413, 71);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Font = new Font("Segoe UI", 15F);
            txtDepartmentName.Location = new Point(207, 122);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(180, 34);
            txtDepartmentName.TabIndex = 18;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Font = new Font("Segoe UI", 15F);
            txtDepartmentID.Location = new Point(207, 80);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.ReadOnly = true;
            txtDepartmentID.Size = new Size(180, 34);
            txtDepartmentID.TabIndex = 17;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Font = new Font("Segoe UI", 15F);
            lblDepartmentName.Location = new Point(23, 125);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(178, 28);
            lblDepartmentName.TabIndex = 15;
            lblDepartmentName.Text = "Department Name:";
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Font = new Font("Segoe UI", 15F);
            lblDepartmentID.Location = new Point(23, 83);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(145, 28);
            lblDepartmentID.TabIndex = 14;
            lblDepartmentID.Text = "Department ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(207, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 28);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Department Management";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(23, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 41);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 416);
            Controls.Add(btnBack);
            Controls.Add(dgvDepartments);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtDepartmentName);
            Controls.Add(txtDepartmentID);
            Controls.Add(lblDepartmentName);
            Controls.Add(lblDepartmentID);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDepartments;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtDepartmentName;
        private TextBox txtDepartmentID;
        private Label lblDepartmentName;
        private Label lblDepartmentID;
        private Label lblTitle;
        private Button btnBack;
    }
}
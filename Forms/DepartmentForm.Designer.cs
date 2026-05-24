namespace Student_Clearance_Management_System.Forms
{
    partial class DepartmentForm
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
            lblDepartmentID = new Label();
            txtDepartmentID = new TextBox();
            lblDepartmentName = new Label();
            txtDepartmentName = new TextBox();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvDepartments = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
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
            pnlHeader.Size = new Size(760, 60);
            pnlHeader.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(680, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏢  Department Management";
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
            pnlInputCard.Controls.Add(lblDepartmentID);
            pnlInputCard.Controls.Add(txtDepartmentID);
            pnlInputCard.Controls.Add(lblDepartmentName);
            pnlInputCard.Controls.Add(txtDepartmentName);
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Location = new Point(0, 60);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(20, 12, 20, 8);
            pnlInputCard.Size = new Size(760, 100);
            pnlInputCard.TabIndex = 8;
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.Location = new Point(0, 0);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(100, 23);
            lblDepartmentID.TabIndex = 0;
            lblDepartmentID.Visible = false;
            lblDepartmentID.Click += lblDepartmentID_Click;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(0, 0);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.ReadOnly = true;
            txtDepartmentID.Size = new Size(100, 27);
            txtDepartmentID.TabIndex = 1;
            txtDepartmentID.Visible = false;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDepartmentName.ForeColor = Color.FromArgb(55, 65, 81);
            lblDepartmentName.Location = new Point(20, 12);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(144, 20);
            lblDepartmentName.TabIndex = 2;
            lblDepartmentName.Text = "Department Name:";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            txtDepartmentName.Font = new Font("Segoe UI", 10.5F);
            txtDepartmentName.Location = new Point(20, 35);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.PlaceholderText = "e.g. Office of the Registrar";
            txtDepartmentName.Size = new Size(680, 31);
            txtDepartmentName.TabIndex = 1;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(249, 250, 251);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 160);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(20, 10, 20, 10);
            pnlButtons.Size = new Size(760, 58);
            pnlButtons.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(386, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 36);
            btnClear.TabIndex = 5;
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
            btnDelete.Location = new Point(264, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 36);
            btnDelete.TabIndex = 4;
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
            btnUpdate.Location = new Point(142, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 36);
            btnUpdate.TabIndex = 3;
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
            btnAdd.Location = new Point(20, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕  Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Dock = DockStyle.Fill;
            dgvDepartments.Location = new Point(0, 218);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(760, 302);
            dgvDepartments.TabIndex = 6;
            dgvDepartments.CellClick += dgvDepartments_CellClick;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 520);
            Controls.Add(dgvDepartments);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department Management — Clearance System";
            Load += DepartmentForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInputCard;
        private Panel pnlButtons;
        private Label lblTitle;
        private Label lblDepartmentID;
        private Label lblDepartmentName;
        private TextBox txtDepartmentID;
        private TextBox txtDepartmentName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dgvDepartments;
        private Button btnBack;
    }
}

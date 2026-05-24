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
            pnlHeader         = new Panel();
            lblTitle          = new Label();
            btnBack           = new Button();
            pnlInputCard      = new Panel();
            lblDepartmentID   = new Label();
            txtDepartmentID   = new TextBox();
            lblDepartmentName = new Label();
            txtDepartmentName = new TextBox();
            pnlButtons        = new Panel();
            btnAdd            = new Button();
            btnUpdate         = new Button();
            btnDelete         = new Button();
            btnClear          = new Button();
            dgvDepartments    = new DataGridView();

            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 60;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "🏢  Department Management";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            btnBack.BackColor = System.Drawing.Color.FromArgb(67, 56, 202);
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(80, 60);
            btnBack.Text = "← Back";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += btnBack_Click;

            // ── Input Card ────────────────────────────────────────────
            pnlInputCard.BackColor = System.Drawing.Color.White;
            pnlInputCard.Dock = DockStyle.Top;
            pnlInputCard.Height = 100;
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Padding = new Padding(20, 12, 20, 8);
            pnlInputCard.Controls.Add(lblDepartmentID);
            pnlInputCard.Controls.Add(txtDepartmentID);
            pnlInputCard.Controls.Add(lblDepartmentName);
            pnlInputCard.Controls.Add(txtDepartmentName);

            // Hidden Department ID
            lblDepartmentID.Visible  = false;
            txtDepartmentID.Visible  = false;
            txtDepartmentID.ReadOnly = true;
            txtDepartmentID.Name     = "txtDepartmentID";

            // Department Name field (full width)
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblDepartmentName.Location = new System.Drawing.Point(20, 12);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Text = "Department Name:";

            txtDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            txtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtDepartmentName.Location = new System.Drawing.Point(20, 30);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new System.Drawing.Size(680, 30);
            txtDepartmentName.TabIndex = 1;
            txtDepartmentName.PlaceholderText = "e.g. Office of the Registrar";

            // ── Action Buttons ────────────────────────────────────────
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Height = 58;
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(20, 10, 20, 10);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);

            // btnAdd
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            btnAdd.Location = new System.Drawing.Point(20, 10);
            btnAdd.Size = new System.Drawing.Size(115, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕  Add";
            btnAdd.Cursor = Cursors.Hand;

            // btnUpdate
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            btnUpdate.Location = new System.Drawing.Point(142, 10);
            btnUpdate.Size = new System.Drawing.Size(115, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "✏️  Update";
            btnUpdate.Cursor = Cursors.Hand;

            // btnDelete
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnDelete.Location = new System.Drawing.Point(264, 10);
            btnDelete.Size = new System.Drawing.Size(115, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "🗑️  Delete";
            btnDelete.Cursor = Cursors.Hand;

            // btnClear
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            btnClear.Location = new System.Drawing.Point(386, 10);
            btnClear.Size = new System.Drawing.Size(115, 36);
            btnClear.TabIndex = 5;
            btnClear.Text = "↺  Clear";
            btnClear.Cursor = Cursors.Hand;
            btnAdd.Click    += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click  += btnClear_Click;

            // ── Grid ──────────────────────────────────────────────────
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Dock = DockStyle.Fill;
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.TabIndex = 6;
            dgvDepartments.CellClick += dgvDepartments_CellClick;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 520);
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

            pnlButtons.ResumeLayout(false);
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlHeader.ResumeLayout(false);
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

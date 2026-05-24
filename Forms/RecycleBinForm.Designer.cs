namespace Student_Clearance_Management_System.Forms
{
    partial class RecycleBinForm
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
            pnlHeader           = new Panel();
            lblTitle            = new Label();
            btnBack             = new Button();
            tabControl1         = new TabControl();
            tabDeletedRecords   = new TabPage();
            pnlTabFilter        = new Panel();
            lblRecordType       = new Label();
            cboRecordType       = new ComboBox();
            btnRestore          = new Button();
            btnDeletePermanently = new Button();
            dgvDeletedRecords   = new DataGridView();
            tabActivityLogs     = new TabPage();
            pnlTabLogBar        = new Panel();
            btnRefreshLogs      = new Button();
            dgvHistory          = new DataGridView();

            pnlHeader.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDeletedRecords.SuspendLayout();
            pnlTabFilter.SuspendLayout();
            tabActivityLogs.SuspendLayout();
            pnlTabLogBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
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
            lblTitle.Text = "🗑️  Admin Panel — Recycle Bin & Activity Logs";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            btnBack.BackColor = System.Drawing.Color.FromArgb(67, 56, 202);
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(80, 60);
            btnBack.Text = "← Close";
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += btnBack_Click;

            // ── TabControl ────────────────────────────────────────────
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Controls.Add(tabDeletedRecords);
            tabControl1.Controls.Add(tabActivityLogs);

            // ── Tab 1: Deleted Records ────────────────────────────────
            tabDeletedRecords.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            tabDeletedRecords.Dock = DockStyle.Fill;
            tabDeletedRecords.Name = "tabDeletedRecords";
            tabDeletedRecords.Text = "  🗑️  Deleted Records  ";
            tabDeletedRecords.UseVisualStyleBackColor = true;
            tabDeletedRecords.Controls.Add(dgvDeletedRecords);
            tabDeletedRecords.Controls.Add(pnlTabFilter);

            pnlTabFilter.BackColor = System.Drawing.Color.White;
            pnlTabFilter.Dock = DockStyle.Top;
            pnlTabFilter.Height = 56;
            pnlTabFilter.Name = "pnlTabFilter";
            pnlTabFilter.Padding = new Padding(16, 10, 16, 10);
            pnlTabFilter.Controls.Add(btnDeletePermanently);
            pnlTabFilter.Controls.Add(btnRestore);
            pnlTabFilter.Controls.Add(cboRecordType);
            pnlTabFilter.Controls.Add(lblRecordType);

            lblRecordType.AutoSize = true;
            lblRecordType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRecordType.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblRecordType.Location = new System.Drawing.Point(16, 17);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Text = "Record Type:";

            cboRecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecordType.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboRecordType.Location = new System.Drawing.Point(110, 13);
            cboRecordType.Name = "cboRecordType";
            cboRecordType.Size = new System.Drawing.Size(200, 28);
            cboRecordType.TabIndex = 1;
            cboRecordType.SelectedIndexChanged += cboRecordType_SelectedIndexChanged;

            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            btnRestore.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnRestore.ForeColor = System.Drawing.Color.White;
            btnRestore.Location = new System.Drawing.Point(560, 13);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new System.Drawing.Size(150, 30);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "♻️  Restore Selected";
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Click += btnRestore_Click;

            btnDeletePermanently.FlatAppearance.BorderSize = 0;
            btnDeletePermanently.FlatStyle = FlatStyle.Flat;
            btnDeletePermanently.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnDeletePermanently.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnDeletePermanently.ForeColor = System.Drawing.Color.White;
            btnDeletePermanently.Location = new System.Drawing.Point(720, 13);
            btnDeletePermanently.Name = "btnDeletePermanently";
            btnDeletePermanently.Size = new System.Drawing.Size(170, 30);
            btnDeletePermanently.TabIndex = 3;
            btnDeletePermanently.Text = "🗑️  Delete Permanently";
            btnDeletePermanently.Cursor = Cursors.Hand;
            btnDeletePermanently.Click += btnDeletePermanently_Click;

            dgvDeletedRecords.AllowUserToAddRows = false;
            dgvDeletedRecords.AllowUserToDeleteRows = false;
            dgvDeletedRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeletedRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedRecords.Dock = DockStyle.Fill;
            dgvDeletedRecords.MultiSelect = false;
            dgvDeletedRecords.Name = "dgvDeletedRecords";
            dgvDeletedRecords.ReadOnly = true;
            dgvDeletedRecords.RowHeadersVisible = false;
            dgvDeletedRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeletedRecords.TabIndex = 4;

            // ── Tab 2: Activity Logs ──────────────────────────────────
            tabActivityLogs.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            tabActivityLogs.Dock = DockStyle.Fill;
            tabActivityLogs.Name = "tabActivityLogs";
            tabActivityLogs.Text = "  📋  Activity Logs  ";
            tabActivityLogs.UseVisualStyleBackColor = true;
            tabActivityLogs.Controls.Add(dgvHistory);
            tabActivityLogs.Controls.Add(pnlTabLogBar);

            pnlTabLogBar.BackColor = System.Drawing.Color.White;
            pnlTabLogBar.Dock = DockStyle.Top;
            pnlTabLogBar.Height = 56;
            pnlTabLogBar.Name = "pnlTabLogBar";
            pnlTabLogBar.Padding = new Padding(16, 10, 16, 10);
            pnlTabLogBar.Controls.Add(btnRefreshLogs);

            btnRefreshLogs.FlatAppearance.BorderSize = 0;
            btnRefreshLogs.FlatStyle = FlatStyle.Flat;
            btnRefreshLogs.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            btnRefreshLogs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnRefreshLogs.ForeColor = System.Drawing.Color.White;
            btnRefreshLogs.Location = new System.Drawing.Point(16, 13);
            btnRefreshLogs.Name = "btnRefreshLogs";
            btnRefreshLogs.Size = new System.Drawing.Size(150, 30);
            btnRefreshLogs.TabIndex = 1;
            btnRefreshLogs.Text = "🔄  Refresh Logs";
            btnRefreshLogs.Cursor = Cursors.Hand;
            btnRefreshLogs.Click += btnRefreshLogs_Click;

            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.TabIndex = 2;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(980, 640);
            Controls.Add(tabControl1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimumSize = new System.Drawing.Size(880, 560);
            Name = "RecycleBinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel — Recycle Bin & Logs";
            Load += RecycleBinForm_Load;

            pnlTabLogBar.ResumeLayout(false);
            tabActivityLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlTabFilter.ResumeLayout(false);
            pnlTabFilter.PerformLayout();
            tabDeletedRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).EndInit();
            tabControl1.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnBack;
        private TabControl tabControl1;
        private TabPage tabDeletedRecords;
        private Panel pnlTabFilter;
        private Label lblRecordType;
        private ComboBox cboRecordType;
        private Button btnRestore;
        private Button btnDeletePermanently;
        private DataGridView dgvDeletedRecords;
        private TabPage tabActivityLogs;
        private Panel pnlTabLogBar;
        private Button btnRefreshLogs;
        private DataGridView dgvHistory;
    }
}

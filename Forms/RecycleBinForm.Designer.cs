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
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            tabControl1 = new TabControl();
            tabDeletedRecords = new TabPage();
            dgvDeletedRecords = new DataGridView();
            pnlTabFilter = new Panel();
            btnDeletePermanently = new Button();
            btnRestore = new Button();
            cboRecordType = new ComboBox();
            lblRecordType = new Label();
            tabActivityLogs = new TabPage();
            dgvHistory = new DataGridView();
            pnlTabLogBar = new Panel();
            btnRefreshLogs = new Button();
            pnlHeader.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDeletedRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).BeginInit();
            pnlTabFilter.SuspendLayout();
            tabActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlTabLogBar.SuspendLayout();
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
            pnlHeader.Size = new Size(980, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(900, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🗑️  Admin Panel — Recycle Bin & Activity Logs";
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
            btnBack.Text = "← Close";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDeletedRecords);
            tabControl1.Controls.Add(tabActivityLogs);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 531);
            tabControl1.TabIndex = 0;
            // 
            // tabDeletedRecords
            // 
            tabDeletedRecords.BackColor = Color.FromArgb(249, 250, 251);
            tabDeletedRecords.Controls.Add(dgvDeletedRecords);
            tabDeletedRecords.Controls.Add(pnlTabFilter);
            tabDeletedRecords.Dock = DockStyle.Fill;
            tabDeletedRecords.Location = new Point(4, 32);
            tabDeletedRecords.Name = "tabDeletedRecords";
            tabDeletedRecords.Size = new Size(972, 495);
            tabDeletedRecords.TabIndex = 0;
            tabDeletedRecords.Text = "  🗑️  Deleted Records  ";
            tabDeletedRecords.UseVisualStyleBackColor = true;
            // 
            // dgvDeletedRecords
            // 
            dgvDeletedRecords.AllowUserToAddRows = false;
            dgvDeletedRecords.AllowUserToDeleteRows = false;
            dgvDeletedRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeletedRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedRecords.Dock = DockStyle.Fill;
            dgvDeletedRecords.Location = new Point(0, 56);
            dgvDeletedRecords.MultiSelect = false;
            dgvDeletedRecords.Name = "dgvDeletedRecords";
            dgvDeletedRecords.ReadOnly = true;
            dgvDeletedRecords.RowHeadersVisible = false;
            dgvDeletedRecords.RowHeadersWidth = 51;
            dgvDeletedRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeletedRecords.Size = new Size(972, 439);
            dgvDeletedRecords.TabIndex = 4;
            // 
            // pnlTabFilter
            // 
            pnlTabFilter.BackColor = Color.White;
            pnlTabFilter.Controls.Add(btnDeletePermanently);
            pnlTabFilter.Controls.Add(btnRestore);
            pnlTabFilter.Controls.Add(cboRecordType);
            pnlTabFilter.Controls.Add(lblRecordType);
            pnlTabFilter.Dock = DockStyle.Top;
            pnlTabFilter.Location = new Point(0, 0);
            pnlTabFilter.Name = "pnlTabFilter";
            pnlTabFilter.Padding = new Padding(16, 10, 16, 10);
            pnlTabFilter.Size = new Size(972, 56);
            pnlTabFilter.TabIndex = 5;
            // 
            // btnDeletePermanently
            // 
            btnDeletePermanently.BackColor = Color.FromArgb(220, 38, 38);
            btnDeletePermanently.Cursor = Cursors.Hand;
            btnDeletePermanently.FlatAppearance.BorderSize = 0;
            btnDeletePermanently.FlatStyle = FlatStyle.Flat;
            btnDeletePermanently.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeletePermanently.ForeColor = Color.White;
            btnDeletePermanently.Location = new Point(720, 13);
            btnDeletePermanently.Name = "btnDeletePermanently";
            btnDeletePermanently.Size = new Size(170, 30);
            btnDeletePermanently.TabIndex = 3;
            btnDeletePermanently.Text = "🗑️  Delete Permanently";
            btnDeletePermanently.UseVisualStyleBackColor = false;
            btnDeletePermanently.Click += btnDeletePermanently_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.FromArgb(22, 163, 74);
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(560, 13);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(150, 30);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "♻️  Restore Selected";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // cboRecordType
            // 
            cboRecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecordType.Font = new Font("Segoe UI", 10F);
            cboRecordType.Location = new Point(121, 13);
            cboRecordType.Name = "cboRecordType";
            cboRecordType.Size = new Size(200, 31);
            cboRecordType.TabIndex = 1;
            cboRecordType.SelectedIndexChanged += cboRecordType_SelectedIndexChanged;
            // 
            // lblRecordType
            // 
            lblRecordType.AutoSize = true;
            lblRecordType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecordType.ForeColor = Color.FromArgb(55, 65, 81);
            lblRecordType.Location = new Point(16, 17);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Size = new Size(99, 20);
            lblRecordType.TabIndex = 4;
            lblRecordType.Text = "Record Type:";
            // 
            // tabActivityLogs
            // 
            tabActivityLogs.BackColor = Color.FromArgb(249, 250, 251);
            tabActivityLogs.Controls.Add(dgvHistory);
            tabActivityLogs.Controls.Add(pnlTabLogBar);
            tabActivityLogs.Dock = DockStyle.Fill;
            tabActivityLogs.Location = new Point(4, 32);
            tabActivityLogs.Name = "tabActivityLogs";
            tabActivityLogs.Size = new Size(972, 495);
            tabActivityLogs.TabIndex = 1;
            tabActivityLogs.Text = "  📋  Activity Logs  ";
            tabActivityLogs.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 56);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(972, 439);
            dgvHistory.TabIndex = 2;
            // 
            // pnlTabLogBar
            // 
            pnlTabLogBar.BackColor = Color.White;
            pnlTabLogBar.Controls.Add(btnRefreshLogs);
            pnlTabLogBar.Dock = DockStyle.Top;
            pnlTabLogBar.Location = new Point(0, 0);
            pnlTabLogBar.Name = "pnlTabLogBar";
            pnlTabLogBar.Padding = new Padding(16, 10, 16, 10);
            pnlTabLogBar.Size = new Size(972, 56);
            pnlTabLogBar.TabIndex = 3;
            // 
            // btnRefreshLogs
            // 
            btnRefreshLogs.BackColor = Color.FromArgb(79, 70, 229);
            btnRefreshLogs.Cursor = Cursors.Hand;
            btnRefreshLogs.FlatAppearance.BorderSize = 0;
            btnRefreshLogs.FlatStyle = FlatStyle.Flat;
            btnRefreshLogs.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefreshLogs.ForeColor = Color.White;
            btnRefreshLogs.Location = new Point(16, 13);
            btnRefreshLogs.Name = "btnRefreshLogs";
            btnRefreshLogs.Size = new Size(150, 30);
            btnRefreshLogs.TabIndex = 1;
            btnRefreshLogs.Text = "🔄  Refresh Logs";
            btnRefreshLogs.UseVisualStyleBackColor = false;
            btnRefreshLogs.Click += btnRefreshLogs_Click;
            // 
            // RecycleBinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 591);
            Controls.Add(tabControl1);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(880, 560);
            Name = "RecycleBinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel — Recycle Bin & Logs";
            Load += RecycleBinForm_Load;
            pnlHeader.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabDeletedRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).EndInit();
            pnlTabFilter.ResumeLayout(false);
            pnlTabFilter.PerformLayout();
            tabActivityLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlTabLogBar.ResumeLayout(false);
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

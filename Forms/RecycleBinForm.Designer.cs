namespace Student_Clearance_Management_System.Forms
{
    partial class RecycleBinForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinForm));
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabDeletedRecords = new TabPage();
            lblRecordType = new Label();
            cboRecordType = new ComboBox();
            dgvDeletedRecords = new DataGridView();
            btnRestore = new Button();
            tabActivityLogs = new TabPage();
            dgvHistory = new DataGridView();
            btnRefreshLogs = new Button();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabDeletedRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).BeginInit();
            tabActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(280, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Recycle Bin Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDeletedRecords);
            tabControl1.Controls.Add(tabActivityLogs);
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(20, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 490);
            tabControl1.TabIndex = 2;
            // 
            // tabDeletedRecords
            // 
            tabDeletedRecords.Controls.Add(lblRecordType);
            tabDeletedRecords.Controls.Add(cboRecordType);
            tabDeletedRecords.Controls.Add(dgvDeletedRecords);
            tabDeletedRecords.Controls.Add(btnRestore);
            tabDeletedRecords.Location = new Point(4, 30);
            tabDeletedRecords.Name = "tabDeletedRecords";
            tabDeletedRecords.Padding = new Padding(10);
            tabDeletedRecords.Size = new Size(802, 456);
            tabDeletedRecords.TabIndex = 0;
            tabDeletedRecords.Text = "Deleted Records";
            tabDeletedRecords.UseVisualStyleBackColor = true;
            // 
            // lblRecordType
            // 
            lblRecordType.AutoSize = true;
            lblRecordType.Font = new Font("Segoe UI", 14F);
            lblRecordType.Location = new Point(15, 20);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Size = new Size(173, 25);
            lblRecordType.TabIndex = 0;
            lblRecordType.Text = "Select Record Type:";
            // 
            // cboRecordType
            // 
            cboRecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecordType.Font = new Font("Segoe UI", 14F);
            cboRecordType.FormattingEnabled = true;
            cboRecordType.Location = new Point(200, 17);
            cboRecordType.Name = "cboRecordType";
            cboRecordType.Size = new Size(250, 33);
            cboRecordType.TabIndex = 1;
            cboRecordType.SelectedIndexChanged += cboRecordType_SelectedIndexChanged;
            // 
            // dgvDeletedRecords
            // 
            dgvDeletedRecords.AllowUserToAddRows = false;
            dgvDeletedRecords.AllowUserToDeleteRows = false;
            dgvDeletedRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeletedRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeletedRecords.Location = new Point(15, 70);
            dgvDeletedRecords.MultiSelect = false;
            dgvDeletedRecords.Name = "dgvDeletedRecords";
            dgvDeletedRecords.ReadOnly = true;
            dgvDeletedRecords.RowHeadersVisible = false;
            dgvDeletedRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeletedRecords.Size = new Size(770, 310);
            dgvDeletedRecords.TabIndex = 2;
            // 
            // btnRestore
            // 
            btnRestore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestore.Location = new Point(605, 395);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(180, 45);
            btnRestore.TabIndex = 3;
            btnRestore.Text = "Restore Selected";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // tabActivityLogs
            // 
            tabActivityLogs.Controls.Add(dgvHistory);
            tabActivityLogs.Controls.Add(btnRefreshLogs);
            tabActivityLogs.Location = new Point(4, 30);
            tabActivityLogs.Name = "tabActivityLogs";
            tabActivityLogs.Padding = new Padding(10);
            tabActivityLogs.Size = new Size(802, 456);
            tabActivityLogs.TabIndex = 1;
            tabActivityLogs.Text = "Activity Logs";
            tabActivityLogs.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(15, 20);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(770, 360);
            dgvHistory.TabIndex = 0;
            // 
            // btnRefreshLogs
            // 
            btnRefreshLogs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRefreshLogs.Location = new Point(605, 395);
            btnRefreshLogs.Name = "btnRefreshLogs";
            btnRefreshLogs.Size = new Size(180, 45);
            btnRefreshLogs.TabIndex = 1;
            btnRefreshLogs.Text = "Refresh History";
            btnRefreshLogs.UseVisualStyleBackColor = true;
            btnRefreshLogs.Click += btnRefreshLogs_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 55);
            btnBack.TabIndex = 47;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RecycleBinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 580);
            Controls.Add(btnBack);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RecycleBinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recycle Bin";
            Load += RecycleBinForm_Load;
            tabControl1.ResumeLayout(false);
            tabDeletedRecords.ResumeLayout(false);
            tabDeletedRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).EndInit();
            tabActivityLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeletedRecords;
        private System.Windows.Forms.Label lblRecordType;
        private System.Windows.Forms.ComboBox cboRecordType;
        private System.Windows.Forms.DataGridView dgvDeletedRecords;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TabPage tabActivityLogs;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnRefreshLogs;
    }
}

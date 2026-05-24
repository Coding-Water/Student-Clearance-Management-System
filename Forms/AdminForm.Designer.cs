using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Forms
{
    partial class AdminForm
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
            tabControl = new TabControl();
            tabUsers = new TabPage();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            btnUserAdd = new Button();
            btnUserUpdate = new Button();
            btnUserDelete = new Button();
            btnUserClear = new Button();
            dgvUsers = new DataGridView();
            tabRecycle = new TabPage();
            lblRecordType = new Label();
            cboRecordType = new ComboBox();
            lblDeletedTitle = new Label();
            dgvDeletedRecords = new DataGridView();
            btnRestore = new Button();
            btnDeletePermanently = new Button();
            lblHistoryTitle = new Label();
            dgvHistory = new DataGridView();
            btnRefreshHistory = new Button();
            tabMaster = new TabPage();
            lblSelectTable = new Label();
            cboMasterTables = new ComboBox();
            dgvMasterRecords = new DataGridView();
            btnMasterRefresh = new Button();
            btnMasterDelete = new Button();
            btnBack = new Button();
            tabControl.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabRecycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            tabMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMasterRecords).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(79, 70, 229);
            lblTitle.Location = new Point(340, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Administrative Panel";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabUsers);
            tabControl.Controls.Add(tabRecycle);
            tabControl.Controls.Add(tabMaster);
            tabControl.Location = new Point(20, 75);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(920, 580);
            tabControl.TabIndex = 1;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(lblUsername);
            tabUsers.Controls.Add(txtUsername);
            tabUsers.Controls.Add(lblPassword);
            tabUsers.Controls.Add(txtPassword);
            tabUsers.Controls.Add(lblRole);
            tabUsers.Controls.Add(cboRole);
            tabUsers.Controls.Add(btnUserAdd);
            tabUsers.Controls.Add(btnUserUpdate);
            tabUsers.Controls.Add(btnUserDelete);
            tabUsers.Controls.Add(btnUserClear);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(15);
            tabUsers.Size = new Size(912, 552);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "Users Management";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(240, 20);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(240, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(460, 20);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 20);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role:";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Items.AddRange(new object[] { "student", "staff", "admin" });
            cboRole.Location = new Point(460, 45);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(150, 23);
            cboRole.TabIndex = 3;
            // 
            // btnUserAdd
            // 
            btnUserAdd.Location = new Point(640, 38);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new Size(80, 32);
            btnUserAdd.TabIndex = 4;
            btnUserAdd.Text = "ADD";
            btnUserAdd.Click += btnUserAdd_Click;
            // 
            // btnUserUpdate
            // 
            btnUserUpdate.Location = new Point(730, 38);
            btnUserUpdate.Name = "btnUserUpdate";
            btnUserUpdate.Size = new Size(80, 32);
            btnUserUpdate.TabIndex = 5;
            btnUserUpdate.Text = "UPDATE";
            btnUserUpdate.Click += btnUserUpdate_Click;
            // 
            // btnUserDelete
            // 
            btnUserDelete.Location = new Point(820, 38);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(80, 32);
            btnUserDelete.TabIndex = 6;
            btnUserDelete.Text = "DELETE";
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // btnUserClear
            // 
            btnUserClear.Location = new Point(820, 80);
            btnUserClear.Name = "btnUserClear";
            btnUserClear.Size = new Size(80, 32);
            btnUserClear.TabIndex = 7;
            btnUserClear.Text = "CLEAR";
            btnUserClear.Click += btnUserClear_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.Location = new Point(20, 130);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvUsers.Size = new Size(880, 410);
            dgvUsers.TabIndex = 4;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // tabRecycle
            // 
            tabRecycle.Controls.Add(lblRecordType);
            tabRecycle.Controls.Add(cboRecordType);
            tabRecycle.Controls.Add(lblDeletedTitle);
            tabRecycle.Controls.Add(dgvDeletedRecords);
            tabRecycle.Controls.Add(btnRestore);
            tabRecycle.Controls.Add(btnDeletePermanently);
            tabRecycle.Controls.Add(lblHistoryTitle);
            tabRecycle.Controls.Add(dgvHistory);
            tabRecycle.Controls.Add(btnRefreshHistory);
            tabRecycle.Location = new Point(4, 24);
            tabRecycle.Name = "tabRecycle";
            tabRecycle.Padding = new Padding(15);
            tabRecycle.Size = new Size(912, 552);
            tabRecycle.TabIndex = 1;
            tabRecycle.Text = "Audit & Recycle Bin";
            // 
            // lblRecordType
            // 
            lblRecordType.Location = new Point(20, 15);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Size = new Size(180, 20);
            lblRecordType.TabIndex = 0;
            lblRecordType.Text = "Filter Soft-Deleted Tables:";
            // 
            // cboRecordType
            // 
            cboRecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecordType.Location = new Point(200, 12);
            cboRecordType.Name = "cboRecordType";
            cboRecordType.Size = new Size(200, 23);
            cboRecordType.TabIndex = 1;
            cboRecordType.SelectedIndexChanged += cboRecordType_SelectedIndexChanged;
            // 
            // lblDeletedTitle
            // 
            lblDeletedTitle.AutoSize = true;
            lblDeletedTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeletedTitle.Location = new Point(20, 55);
            lblDeletedTitle.Name = "lblDeletedTitle";
            lblDeletedTitle.Size = new Size(119, 19);
            lblDeletedTitle.TabIndex = 2;
            lblDeletedTitle.Text = "Deleted Records";
            // 
            // dgvDeletedRecords
            // 
            dgvDeletedRecords.Location = new Point(20, 80);
            dgvDeletedRecords.Name = "dgvDeletedRecords";
            dgvDeletedRecords.Size = new Size(420, 390);
            dgvDeletedRecords.TabIndex = 3;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(20, 485);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(200, 38);
            btnRestore.TabIndex = 4;
            btnRestore.Text = "RESTORE SELECTED";
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDeletePermanently
            // 
            btnDeletePermanently.Location = new Point(240, 485);
            btnDeletePermanently.Name = "btnDeletePermanently";
            btnDeletePermanently.Size = new Size(200, 38);
            btnDeletePermanently.TabIndex = 5;
            btnDeletePermanently.Text = "PURGE (DELETE PERM)";
            btnDeletePermanently.Click += btnDeletePermanently_Click;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHistoryTitle.Location = new Point(470, 55);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(134, 19);
            lblHistoryTitle.TabIndex = 6;
            lblHistoryTitle.Text = "Audit History Logs";
            // 
            // dgvHistory
            // 
            dgvHistory.Location = new Point(470, 80);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(430, 390);
            dgvHistory.TabIndex = 7;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.Location = new Point(700, 485);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(200, 38);
            btnRefreshHistory.TabIndex = 8;
            btnRefreshHistory.Text = "REFRESH LOGS";
            btnRefreshHistory.Click += btnRefreshLogs_Click;
            // 
            // tabMaster
            // 
            tabMaster.Controls.Add(lblSelectTable);
            tabMaster.Controls.Add(cboMasterTables);
            tabMaster.Controls.Add(dgvMasterRecords);
            tabMaster.Controls.Add(btnMasterRefresh);
            tabMaster.Controls.Add(btnMasterDelete);
            tabMaster.Location = new Point(4, 24);
            tabMaster.Name = "tabMaster";
            tabMaster.Padding = new Padding(15);
            tabMaster.Size = new Size(912, 552);
            tabMaster.TabIndex = 2;
            tabMaster.Text = "Direct Master Editor";
            // 
            // lblSelectTable
            // 
            lblSelectTable.Location = new Point(20, 20);
            lblSelectTable.Name = "lblSelectTable";
            lblSelectTable.Size = new Size(150, 20);
            lblSelectTable.TabIndex = 0;
            lblSelectTable.Text = "Select System Table:";
            // 
            // cboMasterTables
            // 
            cboMasterTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasterTables.Location = new Point(170, 17);
            cboMasterTables.Name = "cboMasterTables";
            cboMasterTables.Size = new Size(250, 23);
            cboMasterTables.TabIndex = 1;
            cboMasterTables.SelectedIndexChanged += cboMasterTables_SelectedIndexChanged;
            // 
            // dgvMasterRecords
            // 
            dgvMasterRecords.Location = new Point(20, 65);
            dgvMasterRecords.Name = "dgvMasterRecords";
            dgvMasterRecords.Size = new Size(880, 420);
            dgvMasterRecords.TabIndex = 2;
            // 
            // btnMasterRefresh
            // 
            btnMasterRefresh.Location = new Point(560, 500);
            btnMasterRefresh.Name = "btnMasterRefresh";
            btnMasterRefresh.Size = new Size(160, 40);
            btnMasterRefresh.TabIndex = 3;
            btnMasterRefresh.Text = "REFRESH TABLE";
            btnMasterRefresh.Click += btnMasterRefresh_Click;
            // 
            // btnMasterDelete
            // 
            btnMasterDelete.Location = new Point(740, 500);
            btnMasterDelete.Name = "btnMasterDelete";
            btnMasterDelete.Size = new Size(160, 40);
            btnMasterDelete.TabIndex = 4;
            btnMasterDelete.Text = "SOFT DELETE RECORD";
            btnMasterDelete.Click += btnMasterDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "BACK";
            btnBack.Click += btnBack_Click;
            // 
            // AdminForm
            // 
            ClientSize = new Size(968, 680);
            Controls.Add(btnBack);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Security & Admin Panel";
            tabControl.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabRecycle.ResumeLayout(false);
            tabRecycle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeletedRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            tabMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMasterRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl;

        // Tab 1: Users CRUD
        private TabPage tabUsers;
        private DataGridView dgvUsers;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cboRole;
        private Button btnUserAdd;
        private Button btnUserUpdate;
        private Button btnUserDelete;
        private Button btnUserClear;

        // Tab 2: Recycle Bin
        private TabPage tabRecycle;
        private Label lblRecordType;
        private ComboBox cboRecordType;
        private DataGridView dgvDeletedRecords;
        private Button btnRestore;
        private Button btnDeletePermanently;
        private DataGridView dgvHistory;
        private Button btnRefreshHistory;
        private Label lblDeletedTitle;
        private Label lblHistoryTitle;

        // Tab 3: Master Data Editor
        private TabPage tabMaster;
        private Label lblSelectTable;
        private ComboBox cboMasterTables;
        private DataGridView dgvMasterRecords;
        private Button btnMasterRefresh;
        private Button btnMasterDelete;

        private Button btnBack;
    }
}

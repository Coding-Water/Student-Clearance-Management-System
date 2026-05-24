using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public class AdminForm : Form
    {
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
        private int selectedUserID = 0;

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

        public AdminForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);

            // Tab 1 Load
            LoadUsers();

            // Tab 2 Setup
            cboRecordType.Items.Clear();
            cboRecordType.Items.Add("Students");
            cboRecordType.Items.Add("Courses");
            cboRecordType.Items.Add("Departments");
            cboRecordType.Items.Add("Academic Terms");
            cboRecordType.SelectedIndex = 0;
            LoadDeletedRecords();
            LoadActivityLogs();

            // Tab 3 Setup
            cboMasterTables.Items.Clear();
            cboMasterTables.Items.Add("Students");
            cboMasterTables.Items.Add("Courses");
            cboMasterTables.Items.Add("Departments");
            cboMasterTables.Items.Add("Academic Terms");
            cboMasterTables.Items.Add("Clearance Records");
            cboMasterTables.Items.Add("Course Requirements");
            cboMasterTables.SelectedIndex = 0;
            LoadMasterRecords();
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ================== TAB 1 LOGIC ==================
        private void LoadUsers()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT UserID, Username, Password, Role FROM Users WHERE IsDeleted = 0 ORDER BY UserID DESC";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
                if (dgvUsers.Columns["UserID"] != null) dgvUsers.Columns["UserID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all user fields.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Check duplicate
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
                    check.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role, IsDeleted) VALUES (@username, @password, @role, 0)", conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all user fields.");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Check username availability
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND UserID != @userID", conn);
                    check.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    check.Parameters.AddWithValue("@userID", selectedUserID);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Username already taken.");
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Username = @username, Password = @password, Role = @role WHERE UserID = @userID", conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user login profile?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET IsDeleted = 1 WHERE UserID = @userID", conn);
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            ClearUserFields();
        }

        private void ClearUserFields()
        {
            selectedUserID = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
            txtUsername.Focus();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cboRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }


        // ================== TAB 2 LOGIC ==================
        private void cboRecordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeletedRecords();
        }

        private void LoadDeletedRecords()
        {
            if (cboRecordType.SelectedItem == null) return;

            string selectedType = cboRecordType.SelectedItem.ToString();
            string query = "";

            switch (selectedType)
            {
                case "Students":
                    query = @"SELECT s.StudentID, s.FirstName, s.LastName, c.CourseCode, s.YearLevel, s.Section, s.ContactNumber
                             FROM Students s LEFT JOIN Courses c ON s.CourseID = c.CourseID WHERE s.IsDeleted = 1";
                    break;
                case "Courses":
                    query = "SELECT CourseID, CourseCode, CourseName FROM Courses WHERE IsDeleted = 1";
                    break;
                case "Departments":
                    query = "SELECT DepartmentID, DepartmentName FROM Departments WHERE IsDeleted = 1";
                    break;
                case "Academic Terms":
                    query = "SELECT TermID, SchoolYear, Semester, IsActive FROM AcademicTerms WHERE IsDeleted = 1";
                    break;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDeletedRecords.DataSource = dt;
                    }
                }
                foreach (DataGridViewColumn col in dgvDeletedRecords.Columns)
                {
                    if (col.Name.EndsWith("ID") && col.Name != "StudentID") col.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading deleted records: " + ex.Message);
            }
        }

        private void LoadActivityLogs()
        {
            string query = "SELECT LogID, RecordType AS [Record Type], RecordID AS [Record ID], RecordDetails AS [Details], ActionType AS [Action], ActionDate AS [Date], PerformedBy AS [Performed By] FROM RecycleBinLogs ORDER BY LogID DESC";
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistory.DataSource = dt;
                    }
                }
                if (dgvHistory.Columns["LogID"] != null) dgvHistory.Columns["LogID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to restore.");
                return;
            }

            string selectedType = cboRecordType.SelectedItem.ToString();
            DataGridViewRow row = dgvDeletedRecords.SelectedRows[0];
            string recordId = "";
            string displayDetails = "";

            switch (selectedType)
            {
                case "Students":
                    recordId = row.Cells["StudentID"].Value.ToString();
                    displayDetails = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                    break;
                case "Courses":
                    recordId = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString() + " - " + row.Cells["CourseName"].Value.ToString();
                    break;
                case "Departments":
                    recordId = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    recordId = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show($"Restore {selectedType.ToLower().TrimEnd('s')} '{displayDetails}'?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            DBConnection db = new DBConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        if (selectedType == "Students")
                        {
                            // Integrity Check course
                            SqlCommand c = new SqlCommand("SELECT c.IsDeleted FROM Students s INNER JOIN Courses c ON s.CourseID = c.CourseID WHERE s.StudentID = @studentID", conn, transaction);
                            c.Parameters.AddWithValue("@studentID", recordId);
                            object val = c.ExecuteScalar();
                            if (val != null && Convert.ToBoolean(val))
                            {
                                throw new InvalidOperationException("Cannot restore student because their course is soft-deleted. Please restore the course first.");
                            }

                            SqlCommand cmd1 = new SqlCommand("UPDATE Students SET IsDeleted = 0 WHERE StudentID = @id", conn, transaction);
                            cmd1.Parameters.AddWithValue("@id", recordId);
                            cmd1.ExecuteNonQuery();

                            SqlCommand cmd2 = new SqlCommand("UPDATE ClearanceRecords SET IsDeleted = 0 WHERE StudentID = @id", conn, transaction);
                            cmd2.Parameters.AddWithValue("@id", recordId);
                            cmd2.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Courses SET IsDeleted = 0 WHERE CourseID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Departments SET IsDeleted = 0 WHERE DepartmentID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE AcademicTerms SET IsDeleted = 0 WHERE TermID = @id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", recordId);
                            cmd.ExecuteNonQuery();
                        }

                        // Log activity
                        SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Restore', GETDATE(), @u)", conn, transaction);
                        log.Parameters.AddWithValue("@t", selectedType.TrimEnd('s'));
                        log.Parameters.AddWithValue("@id", recordId);
                        log.Parameters.AddWithValue("@d", displayDetails);
                        log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                        log.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record restored successfully.");
                        LoadDeletedRecords();
                        LoadActivityLogs();
                        LoadMasterRecords(); // Refresh editor
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Restore failed: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void btnDeletePermanently_Click(object sender, EventArgs e)
        {
            if (dgvDeletedRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to purge.");
                return;
            }

            string selectedType = cboRecordType.SelectedItem.ToString();
            DataGridViewRow row = dgvDeletedRecords.SelectedRows[0];
            string recordId = "";
            string displayDetails = "";

            switch (selectedType)
            {
                case "Students":
                    recordId = row.Cells["StudentID"].Value.ToString();
                    displayDetails = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                    break;
                case "Courses":
                    recordId = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString() + " - " + row.Cells["CourseName"].Value.ToString();
                    break;
                case "Departments":
                    recordId = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    recordId = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show($"WARNING: PERMANENTLY purge '{displayDetails}'? This action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            DBConnection db = new DBConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        if (selectedType == "Students")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE StudentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteUser = new SqlCommand("DELETE FROM Users WHERE Username = @id", conn, transaction);
                            deleteUser.Parameters.AddWithValue("@id", recordId);
                            deleteUser.ExecuteNonQuery();

                            SqlCommand deleteStudent = new SqlCommand("DELETE FROM Students WHERE StudentID = @id", conn, transaction);
                            deleteStudent.Parameters.AddWithValue("@id", recordId);
                            deleteStudent.ExecuteNonQuery();
                        }
                        else if (selectedType == "Courses")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE StudentID IN (SELECT StudentID FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteUsers = new SqlCommand("DELETE FROM Users WHERE Username IN (SELECT CAST(StudentID AS VARCHAR) FROM Students WHERE CourseID = @id)", conn, transaction);
                            deleteUsers.Parameters.AddWithValue("@id", recordId);
                            deleteUsers.ExecuteNonQuery();

                            SqlCommand deleteStudents = new SqlCommand("DELETE FROM Students WHERE CourseID = @id", conn, transaction);
                            deleteStudents.Parameters.AddWithValue("@id", recordId);
                            deleteStudents.ExecuteNonQuery();

                            SqlCommand deleteReqs = new SqlCommand("DELETE FROM CourseDepartmentRequirements WHERE CourseID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            SqlCommand deleteCourse = new SqlCommand("DELETE FROM Courses WHERE CourseID = @id", conn, transaction);
                            deleteCourse.Parameters.AddWithValue("@id", recordId);
                            deleteCourse.ExecuteNonQuery();
                        }
                        else if (selectedType == "Departments")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE DepartmentID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteReqs = new SqlCommand("DELETE FROM CourseDepartmentRequirements WHERE DepartmentID = @id", conn, transaction);
                            deleteReqs.Parameters.AddWithValue("@id", recordId);
                            deleteReqs.ExecuteNonQuery();

                            SqlCommand deleteDept = new SqlCommand("DELETE FROM Departments WHERE DepartmentID = @id", conn, transaction);
                            deleteDept.Parameters.AddWithValue("@id", recordId);
                            deleteDept.ExecuteNonQuery();
                        }
                        else if (selectedType == "Academic Terms")
                        {
                            SqlCommand deleteClearances = new SqlCommand("DELETE FROM ClearanceRecords WHERE TermID = @id", conn, transaction);
                            deleteClearances.Parameters.AddWithValue("@id", recordId);
                            deleteClearances.ExecuteNonQuery();

                            SqlCommand deleteTerm = new SqlCommand("DELETE FROM AcademicTerms WHERE TermID = @id", conn, transaction);
                            deleteTerm.Parameters.AddWithValue("@id", recordId);
                            deleteTerm.ExecuteNonQuery();
                        }

                        SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Purge', GETDATE(), @u)", conn, transaction);
                        log.Parameters.AddWithValue("@t", selectedType.TrimEnd('s'));
                        log.Parameters.AddWithValue("@id", recordId);
                        log.Parameters.AddWithValue("@d", displayDetails);
                        log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                        log.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Record purged permanently.");
                        LoadDeletedRecords();
                        LoadActivityLogs();
                        LoadMasterRecords(); // Refresh editor
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Purge failed: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void btnRefreshLogs_Click(object sender, EventArgs e)
        {
            LoadActivityLogs();
        }


        // ================== TAB 3 LOGIC ==================
        private void cboMasterTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMasterRecords();
        }

        private void LoadMasterRecords()
        {
            if (cboMasterTables.SelectedItem == null) return;

            string table = cboMasterTables.SelectedItem.ToString();
            string query = "";

            switch (table)
            {
                case "Students":
                    query = "SELECT StudentID, FirstName, LastName, YearLevel, Section, ContactNumber FROM Students WHERE IsDeleted = 0";
                    break;
                case "Courses":
                    query = "SELECT CourseID, CourseCode, CourseName FROM Courses WHERE IsDeleted = 0";
                    break;
                case "Departments":
                    query = "SELECT DepartmentID, DepartmentName FROM Departments WHERE IsDeleted = 0";
                    break;
                case "Academic Terms":
                    query = "SELECT TermID, SchoolYear, Semester, IsActive FROM AcademicTerms WHERE IsDeleted = 0";
                    break;
                case "Clearance Records":
                    query = @"SELECT cr.ClearanceID, s.StudentID, s.FirstName + ' ' + s.LastName AS Student, d.DepartmentName AS Department, cr.Status, cr.Remarks 
                             FROM ClearanceRecords cr 
                             INNER JOIN Students s ON cr.StudentID = s.StudentID 
                             INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID 
                             WHERE cr.IsDeleted = 0 AND s.IsDeleted = 0 AND d.IsDeleted = 0";
                    break;
                case "Course Requirements":
                    query = @"SELECT cdr.RequirementID, c.CourseCode, d.DepartmentName, cdr.IsRequired 
                             FROM CourseDepartmentRequirements cdr 
                             INNER JOIN Courses c ON cdr.CourseID = c.CourseID 
                             INNER JOIN Departments d ON cdr.DepartmentID = d.DepartmentID 
                             WHERE cdr.IsDeleted = 0 AND c.IsDeleted = 0 AND d.IsDeleted = 0";
                    break;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMasterRecords.DataSource = dt;
                    }
                }

                // Hide Database ID columns programmatically while maintaining StudentID visibility
                foreach (DataGridViewColumn col in dgvMasterRecords.Columns)
                {
                    if (col.Name.EndsWith("ID") && col.Name != "StudentID")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading master records: " + ex.Message);
            }
        }

        private void btnMasterRefresh_Click(object sender, EventArgs e)
        {
            LoadMasterRecords();
            MessageBox.Show("Table records reloaded successfully.");
        }

        private void btnMasterDelete_Click(object sender, EventArgs e)
        {
            if (dgvMasterRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record in the table first.");
                return;
            }

            string table = cboMasterTables.SelectedItem.ToString();
            DataGridViewRow row = dgvMasterRecords.SelectedRows[0];
            string keyName = "";
            string recordVal = "";
            string dbTable = "";
            string displayDetails = "";

            switch (table)
            {
                case "Students":
                    keyName = "StudentID";
                    dbTable = "Students";
                    recordVal = row.Cells["StudentID"].Value.ToString();
                    displayDetails = "Student ID: " + recordVal;
                    break;
                case "Courses":
                    keyName = "CourseID";
                    dbTable = "Courses";
                    recordVal = row.Cells["CourseID"].Value.ToString();
                    displayDetails = row.Cells["CourseCode"].Value.ToString();
                    break;
                case "Departments":
                    keyName = "DepartmentID";
                    dbTable = "Departments";
                    recordVal = row.Cells["DepartmentID"].Value.ToString();
                    displayDetails = row.Cells["DepartmentName"].Value.ToString();
                    break;
                case "Academic Terms":
                    keyName = "TermID";
                    dbTable = "AcademicTerms";
                    recordVal = row.Cells["TermID"].Value.ToString();
                    displayDetails = row.Cells["SchoolYear"].Value.ToString() + " - " + row.Cells["Semester"].Value.ToString();
                    break;
                case "Clearance Records":
                    keyName = "ClearanceID";
                    dbTable = "ClearanceRecords";
                    recordVal = row.Cells["ClearanceID"].Value.ToString();
                    displayDetails = "Clearance Record (Student ID: " + row.Cells["StudentID"].Value.ToString() + ")";
                    break;
                case "Course Requirements":
                    keyName = "RequirementID";
                    dbTable = "CourseDepartmentRequirements";
                    recordVal = row.Cells["RequirementID"].Value.ToString();
                    displayDetails = "Requirement for course: " + row.Cells["CourseCode"].Value.ToString();
                    break;
            }

            DialogResult confirm = MessageBox.Show($"Soft-delete the selected record '{displayDetails}' and move it to Recycle Bin?", "Confirm Soft Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE {dbTable} SET IsDeleted = 1 WHERE {keyName} = @id", conn);
                    cmd.Parameters.AddWithValue("@id", recordVal);
                    cmd.ExecuteNonQuery();

                    // Log soft delete
                    SqlCommand log = new SqlCommand("INSERT INTO RecycleBinLogs (RecordType, RecordID, RecordDetails, ActionType, ActionDate, PerformedBy) VALUES (@t, @id, @d, 'Delete', GETDATE(), @u)", conn);
                    log.Parameters.AddWithValue("@t", table.TrimEnd('s'));
                    log.Parameters.AddWithValue("@id", recordVal);
                    log.Parameters.AddWithValue("@d", displayDetails);
                    log.Parameters.AddWithValue("@u", AppSession.LoggedInUsername);
                    log.ExecuteNonQuery();
                }

                MessageBox.Show("Record soft-deleted and moved to Recycle Bin.");
                LoadMasterRecords();
                LoadDeletedRecords();
                LoadActivityLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Soft delete failed: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class StaffDashboard : Form
    {
        private bool _isLoadingTerms = false;
        private List<int> _assignedDeptIDs = new List<int>();

        public StaffDashboard()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"📋  Staff Clearance Portal - {AppSession.LoggedInUsername}";
            SetupChecklistGrid();
            LoadAssignedDepartments();
            LoadAcademicTerms();
            LoadStudentsAutoComplete();
            LoadAllClearanceRecords();
        }

        private void SetupChecklistGrid()
        {
            dgvChecklistGrid.Columns.Clear();

            // ClearanceID Column
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "ClearanceID";
            colId.HeaderText = "Clearance ID";
            colId.ReadOnly = true;
            colId.Visible = false;
            dgvChecklistGrid.Columns.Add(colId);

            // DepartmentID Column
            var colDeptId = new DataGridViewTextBoxColumn();
            colDeptId.Name = "DepartmentID";
            colDeptId.HeaderText = "Department ID";
            colDeptId.ReadOnly = true;
            colDeptId.Visible = false;
            dgvChecklistGrid.Columns.Add(colDeptId);

            // DepartmentName Column
            var colDeptName = new DataGridViewTextBoxColumn();
            colDeptName.Name = "DepartmentName";
            colDeptName.HeaderText = "Department Name";
            colDeptName.ReadOnly = true;
            dgvChecklistGrid.Columns.Add(colDeptName);

            // Status Column (ComboBox)
            var colStatus = new DataGridViewComboBoxColumn();
            colStatus.Name = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Items.Add("Pending");
            colStatus.Items.Add("Cleared");
            dgvChecklistGrid.Columns.Add(colStatus);

            // Remarks Column
            var colRemarks = new DataGridViewTextBoxColumn();
            colRemarks.Name = "Remarks";
            colRemarks.HeaderText = "Remarks";
            dgvChecklistGrid.Columns.Add(colRemarks);

            dgvChecklistGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChecklistGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChecklistGrid.AllowUserToAddRows = false;
            dgvChecklistGrid.AllowUserToDeleteRows = false;
            dgvChecklistGrid.MultiSelect = false;
            dgvChecklistGrid.ReadOnly = false;
        }

        private void LoadAssignedDepartments()
        {
            try
            {
                _assignedDeptIDs.Clear();
                List<string> deptNames = new List<string>();

                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT sda.DepartmentID, d.DepartmentName 
                        FROM StaffDepartmentAssignments sda
                        INNER JOIN Departments d ON sda.DepartmentID = d.DepartmentID
                        WHERE sda.UserID = @userID AND sda.IsDeleted = 0 AND d.IsDeleted = 0";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", AppSession.LoggedInUserID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _assignedDeptIDs.Add(Convert.ToInt32(reader["DepartmentID"]));
                                deptNames.Add(reader["DepartmentName"].ToString());
                            }
                        }
                    }
                }

                if (_assignedDeptIDs.Count == 0)
                {
                    lblAssignedDepts.Text = "Assigned Departments: None (Access Restricted)";
                    lblAssignedDepts.ForeColor = Color.Red;
                    btnLoadChecklist.Enabled = false;
                    btnSaveChanges.Enabled = false;
                    this.BeginInvoke(new Action(() => {
                        MessageBox.Show("You have not been assigned to any department. Please contact the administrator.", "No Department Assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
                }
                else
                {
                    lblAssignedDepts.Text = "Assigned Departments: " + string.Join(", ", deptNames);
                    lblAssignedDepts.ForeColor = Color.FromArgb(75, 85, 99);
                    btnLoadChecklist.Enabled = true;
                    btnSaveChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAcademicTerms()
        {
            try
            {
                _isLoadingTerms = true;
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT TermID, SchoolYear + ' - ' + Semester AS TermDisplay, IsActive 
                                     FROM AcademicTerms 
                                     WHERE IsDeleted = 0 
                                     ORDER BY TermID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cboAcademicTerm.DataSource = dt;
                            cboAcademicTerm.DisplayMember = "TermDisplay";
                            cboAcademicTerm.ValueMember = "TermID";

                            DataRow[] activeRows = dt.Select("IsActive = True");
                            if (activeRows.Length > 0)
                            {
                                cboAcademicTerm.SelectedValue = activeRows[0]["TermID"];
                            }
                            else if (dt.Rows.Count > 0)
                            {
                                cboAcademicTerm.SelectedIndex = 0;
                            }
                        }
                    }
                }
                _isLoadingTerms = false;
            }
            catch (Exception ex)
            {
                _isLoadingTerms = false;
                MessageBox.Show("Error loading academic terms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentsAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection allowedStudents = new AutoCompleteStringCollection();
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT s.StudentID, s.FirstName, s.LastName, c.CourseCode 
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.IsDeleted = 0 AND c.IsDeleted = 0";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string display = $"{reader["StudentID"]} - {reader["FirstName"]} {reader["LastName"]} ({reader["CourseCode"]})";
                                allowedStudents.Add(display);
                            }
                        }
                    }
                }
                txtStudentSearch.AutoCompleteCustomSource = allowedStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student autocomplete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllClearanceRecords()
        {
            if (cboAcademicTerm.SelectedValue == null) return;
            if (!int.TryParse(cboAcademicTerm.SelectedValue.ToString(), out int termID)) return;

            // Only show records for this staff's assigned departments
            if (_assignedDeptIDs.Count == 0)
            {
                dgvAllRecords.DataSource = null;
                return;
            }

            try
            {
                // Build parameterised IN clause for assigned departments
                List<string> paramNames = new List<string>();
                for (int i = 0; i < _assignedDeptIDs.Count; i++)
                    paramNames.Add("@dept" + i);
                string deptFilter = string.Join(",", paramNames);

                string query = $@"
                    SELECT
                        s.StudentID          AS [Student ID],
                        s.FirstName + ' ' + s.LastName AS [Student Name],
                        c.CourseCode         AS [Course],
                        d.DepartmentName     AS [Department Name],
                        cr.Status            AS [Status]
                    FROM ClearanceRecords cr
                    INNER JOIN Students    s  ON cr.StudentID    = s.StudentID
                    INNER JOIN Courses     c  ON s.CourseID      = c.CourseID
                    INNER JOIN Departments d  ON cr.DepartmentID = d.DepartmentID
                    WHERE cr.TermID    = @termID
                      AND cr.IsDeleted = 0
                      AND s.IsDeleted  = 0
                      AND d.IsDeleted  = 0
                      AND cr.DepartmentID IN ({deptFilter})
                    ORDER BY s.StudentID, d.DepartmentName";

                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@termID", termID);
                        for (int i = 0; i < _assignedDeptIDs.Count; i++)
                            cmd.Parameters.AddWithValue("@dept" + i, _assignedDeptIDs[i]);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAllRecords.DataSource = dt;
                        }
                    }
                }
                ApplySearchFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearchFilter()
        {
            if (dgvAllRecords.DataSource is DataTable dt)
            {
                string search = txtRecordsSearch.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(search))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format(
                        "Convert([Student ID], 'System.String') LIKE '%{0}%' OR [Student Name] LIKE '%{0}%' OR [Course] LIKE '%{0}%' OR [Department Name] LIKE '%{0}%' OR [Status] LIKE '%{0}%'",
                        search);
                }
            }
        }

        private int GetSelectedStudentID()
        {
            string searchText = txtStudentSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText)) return 0;

            if (searchText.Contains("-"))
            {
                string[] parts = searchText.Split('-');
                if (int.TryParse(parts[0].Trim(), out int parsedId))
                {
                    if (StudentExists(parsedId)) return parsedId;
                }
            }

            if (int.TryParse(searchText, out int id))
            {
                if (StudentExists(id)) return id;
            }

            return 0;
        }

        private bool StudentExists(int studentID)
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Students WHERE StudentID = @id AND IsDeleted = 0";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentID);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void EnsureChecklistExists(int studentID, int termID)
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO ClearanceRecords (StudentID, DepartmentID, TermID, Status, Remarks, IsDeleted)
                        SELECT 
                            s.StudentID,
                            d.DepartmentID,
                            @termID,
                            'Pending',
                            '',
                            0
                        FROM Students s
                        INNER JOIN CourseDepartmentRequirements cdr ON s.CourseID = cdr.CourseID
                        INNER JOIN Departments d ON cdr.DepartmentID = d.DepartmentID
                        WHERE s.StudentID = @studentID
                        AND s.IsDeleted = 0
                        AND cdr.IsRequired = 1
                        AND cdr.IsDeleted = 0
                        AND d.IsDeleted = 0
                        AND NOT EXISTS (
                            SELECT 1 FROM ClearanceRecords cr 
                            WHERE cr.StudentID = s.StudentID 
                            AND cr.DepartmentID = d.DepartmentID 
                            AND cr.TermID = @termID
                            AND cr.IsDeleted = 0
                        )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@termID", termID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing clearance requirements checklist: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadChecklist_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == 0)
            {
                MessageBox.Show("Please select a valid student from the search box autocomplete list.", "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAcademicTerm.SelectedValue == null) return;
            int termID = Convert.ToInt32(cboAcademicTerm.SelectedValue);

            if (_assignedDeptIDs.Count == 0)
            {
                MessageBox.Show("Access Denied: You have not been assigned to any department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                EnsureChecklistExists(studentID, termID);
                dgvChecklistGrid.Rows.Clear();

                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    List<string> paramNames = new List<string>();
                    for (int i = 0; i < _assignedDeptIDs.Count; i++)
                    {
                        paramNames.Add("@dept" + i);
                    }
                    string deptFilter = string.Join(",", paramNames);

                    string query = $@"SELECT
                                        cr.ClearanceID,
                                        d.DepartmentID,
                                        d.DepartmentName,
                                        cr.Status,
                                        cr.Remarks
                                     FROM ClearanceRecords cr
                                     INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                     INNER JOIN Students s ON cr.StudentID = s.StudentID
                                     INNER JOIN CourseDepartmentRequirements cdr
                                        ON cdr.CourseID = s.CourseID
                                        AND cdr.DepartmentID = d.DepartmentID
                                     WHERE cr.StudentID = @studentID
                                     AND cr.TermID = @termID
                                     AND cr.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     AND s.IsDeleted = 0
                                     AND cdr.IsRequired = 1
                                     AND cdr.IsDeleted = 0
                                     AND cr.DepartmentID IN ({deptFilter})
                                     ORDER BY d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@termID", termID);
                        for (int i = 0; i < _assignedDeptIDs.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@dept" + i, _assignedDeptIDs[i]);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string remarks = reader["Remarks"] == DBNull.Value ? "" : reader["Remarks"].ToString();
                                dgvChecklistGrid.Rows.Add(
                                    reader["ClearanceID"].ToString(),
                                    reader["DepartmentID"].ToString(),
                                    reader["DepartmentName"].ToString(),
                                    reader["Status"].ToString(),
                                    remarks
                                );
                            }
                        }
                    }
                }
                
                if (dgvChecklistGrid.Rows.Count == 0)
                {
                    MessageBox.Show("This student has no required clearance departments for their course that correspond to your assigned department(s).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student clearance checklist: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (dgvChecklistGrid.Rows.Count == 0)
            {
                MessageBox.Show("Please load a student checklist first.", "No Checklist Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvChecklistGrid.EndEdit();
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in dgvChecklistGrid.Rows)
                            {
                                if (row.IsNewRow || row.Cells["ClearanceID"].Value == null) continue;

                                int clearanceID = Convert.ToInt32(row.Cells["ClearanceID"].Value);
                                int departmentID = Convert.ToInt32(row.Cells["DepartmentID"].Value);
                                string newStatus = row.Cells["Status"].Value == null ? "Pending" : row.Cells["Status"].Value.ToString();
                                string newRemarks = row.Cells["Remarks"].Value == null ? "" : row.Cells["Remarks"].Value.ToString();

                                // Security: enforce that the departmentID must be in _assignedDeptIDs
                                if (!_assignedDeptIDs.Contains(departmentID))
                                {
                                    continue; // Block unauthorized department updates
                                }

                                // Fetch old values for audit logging
                                string oldStatus = "Pending";
                                string oldRemarks = "";
                                string deptName = "";

                                string selectOld = @"
                                    SELECT cr.Status, cr.Remarks, d.DepartmentName 
                                    FROM ClearanceRecords cr
                                    INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                    WHERE cr.ClearanceID = @clearanceID AND cr.IsDeleted = 0";
                                
                                using (SqlCommand cmdOld = new SqlCommand(selectOld, conn, transaction))
                                {
                                    cmdOld.Parameters.AddWithValue("@clearanceID", clearanceID);
                                    using (SqlDataReader rdr = cmdOld.ExecuteReader())
                                    {
                                        if (rdr.Read())
                                        {
                                            oldStatus = rdr["Status"].ToString();
                                            oldRemarks = rdr["Remarks"] == DBNull.Value ? "" : rdr["Remarks"].ToString();
                                            deptName = rdr["DepartmentName"].ToString();
                                        }
                                    }
                                }

                                // Update ClearanceRecord
                                string updateQuery = @"
                                    UPDATE ClearanceRecords 
                                    SET Status = @status, Remarks = @remarks 
                                    WHERE ClearanceID = @clearanceID AND IsDeleted = 0";
                                
                                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn, transaction))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@status", newStatus);
                                    cmdUpdate.Parameters.AddWithValue("@remarks", newRemarks);
                                    cmdUpdate.Parameters.AddWithValue("@clearanceID", clearanceID);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                // Log changes
                                bool statusChanged = !oldStatus.Equals(newStatus, StringComparison.OrdinalIgnoreCase);
                                bool remarksChanged = !oldRemarks.Equals(newRemarks, StringComparison.OrdinalIgnoreCase);

                                if (statusChanged || remarksChanged)
                                {
                                    System.Text.StringBuilder details = new System.Text.StringBuilder();
                                    details.Append($"Department: {deptName}");
                                    if (statusChanged)
                                        details.Append($" | Status: \"{oldStatus}\" ➔ \"{newStatus}\"");
                                    if (remarksChanged)
                                        details.Append($" | Remarks: \"{oldRemarks}\" ➔ \"{newRemarks}\"");

                                    string logQuery = @"
                                        INSERT INTO UpdateLogs (RecordType, RecordID, UpdateDetails, PerformedBy, UserRole, ActionDate)
                                        VALUES ('ClearanceRecord', @recordID, @details, @user, 'staff', GETDATE())";
                                    
                                    using (SqlCommand cmdLog = new SqlCommand(logQuery, conn, transaction))
                                    {
                                        cmdLog.Parameters.AddWithValue("@recordID", clearanceID.ToString());
                                        cmdLog.Parameters.AddWithValue("@details", details.ToString());
                                        cmdLog.Parameters.AddWithValue("@user", AppSession.LoggedInUsername);
                                        cmdLog.ExecuteNonQuery();
                                    }
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadAllClearanceRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentSearch.Clear();
            dgvChecklistGrid.Rows.Clear();
        }

        private void cboAcademicTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingTerms) return;
            LoadAllClearanceRecords();
        }

        private void txtRecordsSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void txtStudentSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoadChecklist_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppSession.LoggedInUserID = 0;
                AppSession.LoggedInUsername = "";
                AppSession.LoggedInRole = "";
                AppSession.SelectedTermID = 0;
                AppSession.SelectedTermText = "";

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Close();
            }
        }

        private void dgvChecklistGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress combobox data source or value mismatched errors
            e.ThrowException = false;
        }
    }
}

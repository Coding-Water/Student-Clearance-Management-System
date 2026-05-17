using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;

namespace Student_Clearance_Management_System.Forms
{
    public partial class ClearanceForm : Form
    {
        private bool isLoadingTerms = false;
        private System.Windows.Forms.Timer searchTimer;

        public ClearanceForm()
        {
            InitializeComponent();
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400; // 400 milliseconds debounce
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            SearchClearanceRecords();
        }

        private void ClearanceForm_Load(object sender, EventArgs e)
        {
            LoadAcademicTerms();
            LoadStudents();
            SetupChecklistGrid();
            LoadClearanceRecords();
        }

        private void LoadAcademicTerms()
        {
            try
            {
                isLoadingTerms = true;

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        TermID,
                                        SchoolYear + ' - ' + Semester AS TermDisplay,
                                        IsActive
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

                            if (dt.Rows.Count > 0)
                            {
                                bool activeFound = false;

                                foreach (DataRow row in dt.Rows)
                                {
                                    if (Convert.ToBoolean(row["IsActive"]))
                                    {
                                        cboAcademicTerm.SelectedValue = row["TermID"];
                                        activeFound = true;
                                        break;
                                    }
                                }

                                if (!activeFound)
                                {
                                    cboAcademicTerm.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }

                isLoadingTerms = false;
            }
            catch (Exception ex)
            {
                isLoadingTerms = false;

                MessageBox.Show(
                    "Error loading academic terms: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetSelectedTermID()
        {
            if (cboAcademicTerm.SelectedValue == null)
            {
                return 0;
            }

            if (int.TryParse(cboAcademicTerm.SelectedValue.ToString(), out int termID))
            {
                return termID;
            }

            return 0;
        }

        private void LoadStudents()
        {
            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        s.StudentID,
                                        CAST(s.StudentID AS VARCHAR) + ' - ' +
                                        s.FirstName + ' ' + s.LastName +
                                        ' (' + c.CourseCode + ')' AS StudentDisplay
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.IsDeleted = 0
                                     AND c.IsDeleted = 0
                                     ORDER BY s.LastName, s.FirstName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            cboStudent.DataSource = dt;
                            cboStudent.DisplayMember = "StudentDisplay";
                            cboStudent.ValueMember = "StudentID";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetSelectedStudentID()
        {
            if (cboStudent.SelectedValue == null)
            {
                return 0;
            }

            if (int.TryParse(cboStudent.SelectedValue.ToString(), out int studentID))
            {
                return studentID;
            }

            return 0;
        }

        private void SetupChecklistGrid()
        {
            dgvClearanceDepartments.Columns.Clear();

            DataGridViewTextBoxColumn colClearanceID = new DataGridViewTextBoxColumn();
            colClearanceID.Name = "ClearanceID";
            colClearanceID.HeaderText = "ClearanceID";
            colClearanceID.Visible = false;
            dgvClearanceDepartments.Columns.Add(colClearanceID);

            DataGridViewTextBoxColumn colDepartmentID = new DataGridViewTextBoxColumn();
            colDepartmentID.Name = "DepartmentID";
            colDepartmentID.HeaderText = "DepartmentID";
            colDepartmentID.Visible = false;
            dgvClearanceDepartments.Columns.Add(colDepartmentID);

            DataGridViewTextBoxColumn colDepartmentName = new DataGridViewTextBoxColumn();
            colDepartmentName.Name = "DepartmentName";
            colDepartmentName.HeaderText = "Department";
            colDepartmentName.ReadOnly = true;
            dgvClearanceDepartments.Columns.Add(colDepartmentName);

            DataGridViewComboBoxColumn colStatus = new DataGridViewComboBoxColumn();
            colStatus.Name = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Items.Add("Pending");
            colStatus.Items.Add("Cleared");
            colStatus.Items.Add("Not Cleared");
            dgvClearanceDepartments.Columns.Add(colStatus);

            DataGridViewTextBoxColumn colRemarks = new DataGridViewTextBoxColumn();
            colRemarks.Name = "Remarks";
            colRemarks.HeaderText = "Remarks";
            dgvClearanceDepartments.Columns.Add(colRemarks);

            dgvClearanceDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceDepartments.AllowUserToAddRows = false;
            dgvClearanceDepartments.AllowUserToDeleteRows = false;
            dgvClearanceDepartments.MultiSelect = false;
            dgvClearanceDepartments.ReadOnly = false;
        }

        private void EnsureChecklistExists(int studentID, int termID)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO ClearanceRecords
                                 (StudentID, DepartmentID, TermID, Status, Remarks, IsDeleted)
                                 SELECT
                                    s.StudentID,
                                    d.DepartmentID,
                                    @termID,
                                    'Pending',
                                    '',
                                    0
                                 FROM Students s
                                 INNER JOIN CourseDepartmentRequirements cdr
                                    ON s.CourseID = cdr.CourseID
                                 INNER JOIN Departments d
                                    ON cdr.DepartmentID = d.DepartmentID
                                 WHERE s.StudentID = @studentID
                                 AND s.IsDeleted = 0
                                 AND cdr.IsRequired = 1
                                 AND cdr.IsDeleted = 0
                                 AND d.IsDeleted = 0
                                 AND NOT EXISTS (
                                    SELECT 1
                                    FROM ClearanceRecords cr
                                    WHERE cr.StudentID = s.StudentID
                                    AND cr.DepartmentID = d.DepartmentID
                                    AND cr.TermID = @termID
                                    AND cr.IsDeleted = 0
                                 )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@termID", termID);

                cmd.ExecuteNonQuery();
            }
        }

        private void LoadChecklist()
        {
            int studentID = GetSelectedStudentID();
            int termID = GetSelectedTermID();

            if (studentID == 0)
            {
                MessageBox.Show("Please select a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (termID == 0)
            {
                MessageBox.Show("Please select an academic term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                EnsureChecklistExists(studentID, termID);
                dgvClearanceDepartments.Rows.Clear();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
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
                                     ORDER BY d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@termID", termID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string remarks = reader["Remarks"] == DBNull.Value ? "" : reader["Remarks"].ToString();

                                dgvClearanceDepartments.Rows.Add(
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading checklist: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAllChecklist()
        {
            if (dgvClearanceDepartments.Rows.Count == 0)
            {
                MessageBox.Show("Please load a checklist first.", "No Checklist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvClearanceDepartments.EndEdit();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow row in dgvClearanceDepartments.Rows)
                        {
                            if (row.IsNewRow || row.Cells["ClearanceID"].Value == null)
                            {
                                continue;
                            }

                            int clearanceID = Convert.ToInt32(row.Cells["ClearanceID"].Value);
                            string status = row.Cells["Status"].Value == null ? "Pending" : row.Cells["Status"].Value.ToString();
                            string remarks = row.Cells["Remarks"].Value == null ? "" : row.Cells["Remarks"].Value.ToString();

                            string query = @"UPDATE ClearanceRecords
                                             SET Status = @status,
                                                 Remarks = @remarks
                                             WHERE ClearanceID = @clearanceID
                                             AND IsDeleted = 0";

                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@remarks", remarks);
                            cmd.Parameters.AddWithValue("@clearanceID", clearanceID);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Clearance checklist saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving checklist: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadClearanceRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClearanceRecords()
        {
            try
            {
                int termID = GetSelectedTermID();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        cr.ClearanceID,
                                        s.StudentID,
                                        s.FirstName + ' ' + s.LastName AS StudentName,
                                        c.CourseCode,
                                        s.YearLevel,
                                        s.Section,
                                        d.DepartmentName,
                                        at.SchoolYear,
                                        at.Semester,
                                        cr.Status,
                                        cr.Remarks
                                     FROM ClearanceRecords cr
                                     INNER JOIN Students s ON cr.StudentID = s.StudentID
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                     INNER JOIN AcademicTerms at ON cr.TermID = at.TermID
                                     WHERE cr.IsDeleted = 0
                                     AND s.IsDeleted = 0
                                     AND c.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     AND at.IsDeleted = 0";

                    if (termID > 0)
                    {
                        query += " AND cr.TermID = @termID";
                    }

                    query += " ORDER BY s.LastName, s.FirstName, d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (termID > 0)
                        {
                            cmd.Parameters.AddWithValue("@termID", termID);
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvClearanceRecords.DataSource = dt;
                            FormatRecordsGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clearance records: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatRecordsGrid()
        {
            dgvClearanceRecords.ReadOnly = true;
            dgvClearanceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClearanceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearanceRecords.AllowUserToAddRows = false;
            dgvClearanceRecords.AllowUserToDeleteRows = false;
            dgvClearanceRecords.MultiSelect = false;

            dgvClearanceRecords.Columns["ClearanceID"].Visible = false;
        }

        private void SearchClearanceRecords()
        {
            try
            {
                int termID = GetSelectedTermID();

                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        cr.ClearanceID,
                                        s.StudentID,
                                        s.FirstName + ' ' + s.LastName AS StudentName,
                                        c.CourseCode,
                                        s.YearLevel,
                                        s.Section,
                                        d.DepartmentName,
                                        at.SchoolYear,
                                        at.Semester,
                                        cr.Status,
                                        cr.Remarks
                                     FROM ClearanceRecords cr
                                     INNER JOIN Students s ON cr.StudentID = s.StudentID
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                     INNER JOIN AcademicTerms at ON cr.TermID = at.TermID
                                     WHERE cr.IsDeleted = 0
                                     AND s.IsDeleted = 0
                                     AND c.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     AND at.IsDeleted = 0";

                    if (termID > 0)
                    {
                        query += " AND cr.TermID = @termID";
                    }

                    query += @" AND (
                                CAST(s.StudentID AS VARCHAR) LIKE @search OR
                                s.FirstName LIKE @search OR
                                s.LastName LIKE @search OR
                                c.CourseCode LIKE @search OR
                                s.YearLevel LIKE @search OR
                                s.Section LIKE @search OR
                                d.DepartmentName LIKE @search OR
                                cr.Status LIKE @search OR
                                cr.Remarks LIKE @search
                             )
                             ORDER BY s.LastName, s.FirstName, d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (termID > 0)
                        {
                            cmd.Parameters.AddWithValue("@termID", termID);
                        }
                        cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvClearanceRecords.DataSource = dt;
                            FormatRecordsGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching clearance records: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSelectedRecord()
        {
            if (dgvClearanceRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a clearance record from the report table.", "No Selected Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvClearanceRecords.SelectedRows[0];

            if (row.Cells["ClearanceID"].Value == null)
            {
                return;
            }

            int clearanceID = Convert.ToInt32(row.Cells["ClearanceID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this clearance record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE ClearanceRecords
                                     SET IsDeleted = 1
                                     WHERE ClearanceID = @clearanceID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@clearanceID", clearanceID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Clearance record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadClearanceRecords();
                dgvClearanceDepartments.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting clearance record: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtSearch.Clear();
            dgvClearanceDepartments.Rows.Clear();

            if (cboStudent.Items.Count > 0)
            {
                cboStudent.SelectedIndex = 0;
            }

            LoadClearanceRecords();
        }

        private void cboAcademicTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingTerms)
            {
                return;
            }

            dgvClearanceDepartments.Rows.Clear();
            LoadClearanceRecords();
        }

        private void btnLoadChecklist_Click(object sender, EventArgs e)
        {
            LoadChecklist();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveAllChecklist();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecord();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void dgvClearanceDepartments_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvClearanceDepartments.IsCurrentCellDirty)
            {
                dgvClearanceDepartments.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvClearanceDepartments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}

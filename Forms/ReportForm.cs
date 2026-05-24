using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    // OBJECT-ORIENTED PRINCIPLES (OOP):
    // 1. INHERITANCE: ReportForm inherits standard GUI functionality from the Form base class.
    // 2. ENCAPSULATION: We protect control states and internal fields such as isInitializing and searchTimer using 'private'.
    // 3. POLYMORPHISM & ABSTRACTION: We abstract raw SQL data into structured DataTable grids and handle varying row formatting dynamically.
    public partial class ReportForm : Form
    {
        private bool isInitializing = true;
        private System.Windows.Forms.Timer searchTimer;

        public ReportForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400; // 400ms debounce
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            isInitializing = true;

            LoadAcademicTerms();
            LoadCourses();
            LoadStatuses();
            LoadReportModes();

            // Set default active academic term from AppSession
            if (AppSession.SelectedTermID > 0)
            {
                cboAcademicTerm.SelectedValue = AppSession.SelectedTermID;
            }

            isInitializing = false;
            LoadReportData();
        }

        private void LoadAcademicTerms()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        TermID, 
                                        SchoolYear + ' - ' + Semester AS TermDisplay
                                     FROM AcademicTerms
                                     WHERE IsDeleted = 0
                                     ORDER BY TermID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cboAcademicTerm.DisplayMember = "TermDisplay";
                            cboAcademicTerm.ValueMember = "TermID";
                            cboAcademicTerm.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading academic terms: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        CourseID, 
                                        CourseCode + ' - ' + CourseName AS CourseDisplay,
                                        CourseCode
                                     FROM Courses
                                     WHERE IsDeleted = 0
                                     ORDER BY CourseCode";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Insert an "All Courses" row at the top
                            DataRow row = dt.NewRow();
                            row["CourseID"] = 0;
                            row["CourseDisplay"] = "All Courses";
                            row["CourseCode"] = "ALL";
                            dt.Rows.InsertAt(row, 0);

                            cboCourse.DisplayMember = "CourseDisplay";
                            cboCourse.ValueMember = "CourseCode";
                            cboCourse.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatuses()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("All Statuses");
            cboStatus.Items.Add("Cleared");
            cboStatus.Items.Add("Pending");
            cboStatus.Items.Add("Not Cleared");
            cboStatus.SelectedIndex = 0;
        }

        private void LoadReportModes()
        {
            cboReportMode.Items.Clear();
            cboReportMode.Items.Add("Summary (Per Student)");
            cboReportMode.Items.Add("Detailed (Per Department)");
            cboReportMode.SelectedIndex = 0;
        }

        private void LoadReportData()
        {
            if (isInitializing) return;

            int termID = 0;
            if (cboAcademicTerm.SelectedValue != null)
            {
                object val = cboAcademicTerm.SelectedValue;
                if (val is DataRowView drv)
                {
                    val = drv["TermID"];
                }
                
                if (val != null && int.TryParse(val.ToString(), out int parsedTerm))
                {
                    termID = parsedTerm;
                }
            }

            if (termID == 0) return;

            string courseCode = "ALL";
            if (cboCourse.SelectedValue != null)
            {
                object val = cboCourse.SelectedValue;
                if (val is DataRowView drv)
                {
                    val = drv["CourseCode"];
                }
                courseCode = val?.ToString() ?? "ALL";
            }

            string statusFilter = cboStatus.SelectedItem?.ToString() ?? "All Statuses";
            string mode = cboReportMode.SelectedItem?.ToString() ?? "Summary (Per Student)";
            string searchText = txtSearch.Text.Trim();

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    DataTable dt = new DataTable();

                    if (mode.StartsWith("Summary"))
                    {
                        // Summary Report per Student
                        // Calculate total department clearance checklists and cleared checklists per student for the term
                        string query = @"
                            SELECT 
                                s.StudentID AS [Student ID],
                                s.LastName + ', ' + s.FirstName AS [Student Name],
                                c.CourseCode AS [Course],
                                s.YearLevel AS [Year],
                                s.Section AS [Section],
                                ISNULL(stats.TotalReq, 0) AS [Total Req],
                                ISNULL(stats.ClearedCount, 0) AS [Cleared Req],
                                CASE 
                                    WHEN ISNULL(stats.TotalReq, 0) = 0 THEN 'No Checklist'
                                    WHEN ISNULL(stats.TotalReq, 0) = ISNULL(stats.ClearedCount, 0) THEN 'Cleared'
                                    ELSE 'Pending'
                                END AS [Overall Status]
                            FROM Students s
                            INNER JOIN Courses c ON s.CourseID = c.CourseID
                            LEFT JOIN (
                                SELECT 
                                    cr.StudentID,
                                    COUNT(cr.ClearanceID) AS TotalReq,
                                    SUM(CASE WHEN cr.Status = 'Cleared' THEN 1 ELSE 0 END) AS ClearedCount
                                FROM ClearanceRecords cr
                                WHERE cr.IsDeleted = 0 AND cr.TermID = @termID
                                GROUP BY cr.StudentID
                            ) stats ON s.StudentID = stats.StudentID
                            WHERE s.IsDeleted = 0 AND c.IsDeleted = 0";

                        if (courseCode != "ALL")
                        {
                            query += " AND c.CourseCode = @courseCode";
                        }

                        if (!string.IsNullOrEmpty(searchText))
                        {
                            query += @" AND (
                                CAST(s.StudentID AS VARCHAR) LIKE @search OR
                                s.FirstName LIKE @search OR
                                s.LastName LIKE @search OR
                                c.CourseCode LIKE @search OR
                                s.YearLevel LIKE @search OR
                                s.Section LIKE @search
                            )";
                        }

                        // Wrap in a subquery to filter by dynamic status cleanly
                        string outerQuery = "SELECT * FROM (" + query + ") AS Temp WHERE 1=1";
                        if (statusFilter == "Cleared")
                        {
                            outerQuery += " AND [Overall Status] = 'Cleared'";
                        }
                        else if (statusFilter == "Pending")
                        {
                            outerQuery += " AND [Overall Status] = 'Pending'";
                        }
                        else if (statusFilter == "Not Cleared")
                        {
                            outerQuery += " AND [Overall Status] = 'Not Cleared' OR [Overall Status] = 'Pending'";
                        }

                        outerQuery += " ORDER BY [Student Name]";

                        using (SqlCommand cmd = new SqlCommand(outerQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@termID", termID);
                            if (courseCode != "ALL") cmd.Parameters.AddWithValue("@courseCode", courseCode);
                            if (!string.IsNullOrEmpty(searchText)) cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                            }
                        }
                    }
                    else
                    {
                        // Detailed Report per Department
                        string query = @"
                            SELECT 
                                cr.ClearanceID AS [Clearance ID],
                                s.StudentID AS [Student ID],
                                s.LastName + ', ' + s.FirstName AS [Student Name],
                                c.CourseCode AS [Course],
                                s.YearLevel AS [Year],
                                s.Section AS [Section],
                                d.DepartmentName AS [Department],
                                cr.Status AS [Status],
                                cr.Remarks AS [Remarks]
                            FROM ClearanceRecords cr
                            INNER JOIN Students s ON cr.StudentID = s.StudentID
                            INNER JOIN Courses c ON s.CourseID = c.CourseID
                            INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                            WHERE cr.IsDeleted = 0 
                              AND s.IsDeleted = 0 
                              AND c.IsDeleted = 0 
                              AND d.IsDeleted = 0
                              AND cr.TermID = @termID";

                        if (courseCode != "ALL")
                        {
                            query += " AND c.CourseCode = @courseCode";
                        }

                        if (statusFilter != "All Statuses")
                        {
                            query += " AND cr.Status = @status";
                        }

                        if (!string.IsNullOrEmpty(searchText))
                        {
                            query += @" AND (
                                CAST(s.StudentID AS VARCHAR) LIKE @search OR
                                s.FirstName LIKE @search OR
                                s.LastName LIKE @search OR
                                c.CourseCode LIKE @search OR
                                s.YearLevel LIKE @search OR
                                s.Section LIKE @search OR
                                d.DepartmentName LIKE @search OR
                                cr.Remarks LIKE @search
                            )";
                        }

                        query += " ORDER BY [Student Name], d.DepartmentName";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@termID", termID);
                            if (courseCode != "ALL") cmd.Parameters.AddWithValue("@courseCode", courseCode);
                            if (statusFilter != "All Statuses") cmd.Parameters.AddWithValue("@status", statusFilter);
                            if (!string.IsNullOrEmpty(searchText)) cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                            }
                        }
                    }

                    dgvReports.DataSource = dt;
                    FormatReportsGrid(mode);
                    CalculateStats(dt, mode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatReportsGrid(string mode)
        {
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;

            if (mode.StartsWith("Summary"))
            {
                if (dgvReports.Columns["Total Req"] != null)
                {
                    dgvReports.Columns["Total Req"].HeaderText = "Total Depts Required";
                    dgvReports.Columns["Total Req"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvReports.Columns["Cleared Req"] != null)
                {
                    dgvReports.Columns["Cleared Req"].HeaderText = "Cleared Depts";
                    dgvReports.Columns["Cleared Req"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvReports.Columns["Overall Status"] != null)
                {
                    dgvReports.Columns["Overall Status"].HeaderText = "Overall Status";
                    dgvReports.Columns["Overall Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            else
            {
                if (dgvReports.Columns["Clearance ID"] != null)
                {
                    dgvReports.Columns["Clearance ID"].Visible = false;
                }
                if (dgvReports.Columns["Status"] != null)
                {
                    dgvReports.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            dgvReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvReports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dgvReports.EnableHeadersVisualStyles = false;
        }

        private void CalculateStats(DataTable dt, string mode)
        {
            if (dt.Rows.Count == 0)
            {
                lblTotalVal.Text = "0";
                lblClearedVal.Text = "0";
                lblPendingVal.Text = "0";
                lblRateVal.Text = "0.0%";
                return;
            }

            int totalStudents = 0;
            int clearedStudents = 0;
            int pendingStudents = 0;

            if (mode.StartsWith("Summary"))
            {
                totalStudents = dt.Rows.Count;
                foreach (DataRow row in dt.Rows)
                {
                    string status = row["Overall Status"].ToString();
                    if (status == "Cleared")
                        clearedStudents++;
                    else
                        pendingStudents++;
                }
            }
            else
            {
                // In Detailed Mode, aggregate unique students based on 'Student ID'
                var studentGroup = dt.AsEnumerable()
                    .GroupBy(r => r.Field<int>("Student ID"));

                totalStudents = studentGroup.Count();

                foreach (var group in studentGroup)
                {
                    bool isCleared = true;
                    foreach (var row in group)
                    {
                        string status = row.Field<string>("Status");
                        if (status != "Cleared")
                        {
                            isCleared = false;
                            break;
                        }
                    }

                    if (isCleared)
                        clearedStudents++;
                    else
                        pendingStudents++;
                }
            }

            double rate = totalStudents > 0 ? ((double)clearedStudents / totalStudents) * 100 : 0.0;

            lblTotalVal.Text = totalStudents.ToString();
            lblClearedVal.Text = clearedStudents.ToString();
            lblPendingVal.Text = pendingStudents.ToString();
            lblRateVal.Text = rate.ToString("F1") + "%";
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvReports.Columns[e.ColumnIndex].Name;

            if (columnName == "Overall Status" || columnName == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    if (status == "Cleared")
                    {
                        e.CellStyle.ForeColor = Color.DarkGreen;
                        e.CellStyle.BackColor = Color.FromArgb(230, 245, 230); // Soft Green
                        e.CellStyle.Font = new Font(dgvReports.Font, FontStyle.Bold);
                    }
                    else if (status == "Pending")
                    {
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.CellStyle.BackColor = Color.FromArgb(255, 243, 230); // Soft Orange
                        e.CellStyle.Font = new Font(dgvReports.Font, FontStyle.Bold);
                    }
                    else if (status == "Not Cleared")
                    {
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.BackColor = Color.FromArgb(255, 230, 230); // Soft Red
                        e.CellStyle.Font = new Font(dgvReports.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void FilterControl_Changed(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            LoadReportData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isInitializing = true;

            txtSearch.Clear();
            if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            if (cboReportMode.Items.Count > 0) cboReportMode.SelectedIndex = 0;

            if (AppSession.SelectedTermID > 0)
            {
                cboAcademicTerm.SelectedValue = AppSession.SelectedTermID;
            }
            else if (cboAcademicTerm.Items.Count > 0)
            {
                cboAcademicTerm.SelectedIndex = 0;
            }

            isInitializing = false;
            LoadReportData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "Export Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Clearance_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                sfd.Title = "Export Report data as CSV";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        int columnCount = dgvReports.Columns.Count;
                        string[] headers = new string[columnCount];
                        int visibleCount = 0;

                        // Retrieve headers of visible columns
                        for (int i = 0; i < columnCount; i++)
                        {
                            if (dgvReports.Columns[i].Visible)
                            {
                                headers[visibleCount] = EscapeCSV(dgvReports.Columns[i].HeaderText);
                                visibleCount++;
                            }
                        }

                        Array.Resize(ref headers, visibleCount);
                        sb.AppendLine(string.Join(",", headers));

                        // Retrieve row details for visible columns
                        foreach (DataGridViewRow row in dgvReports.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string[] cells = new string[visibleCount];
                            int cellIndex = 0;

                            for (int i = 0; i < columnCount; i++)
                            {
                                if (dgvReports.Columns[i].Visible)
                                {
                                    object val = row.Cells[i].Value;
                                    cells[cellIndex] = EscapeCSV(val == null ? "" : val.ToString());
                                    cellIndex++;
                                }
                            }

                            sb.AppendLine(string.Join(",", cells));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Clearance report exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during file export: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string EscapeCSV(string val)
        {
            if (string.IsNullOrEmpty(val)) return "";

            // If value contains formatting characters, wrap in double quotes and escape internal quotes
            if (val.Contains(",") || val.Contains("\"") || val.Contains("\n") || val.Contains("\r"))
            {
                return "\"" + val.Replace("\"", "\"\"") + "\"";
            }

            return val;
        }
    }
}

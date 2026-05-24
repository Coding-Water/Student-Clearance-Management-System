using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;
using System;
using System.Data;
using System.Windows.Forms;


namespace Student_Clearance_Management_System.Forms
{
    public partial class Dashboard : Form
    {
        private bool isLoadingTerms = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = "Logged in as: " +
                                   AppSession.LoggedInUsername +
                                   " (" + AppSession.LoggedInRole + ")";

            // Show Recycle Bin button only for Admin role (case-insensitive and trimmed)
            string role = AppSession.LoggedInRole?.Trim().ToLower() ?? "";

            // Ensure the button exists and set visibility
            if (btnRecycleBin != null)
            {
                btnRecycleBin.Visible = (role == "admin");
            }

            LoadAcademicTerms();
            LoadDashboard();
        }

        private void LoadAcademicTerms()
        {
            try
            {
                isLoadingTerms = true;

                    DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
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

                            // Automatically select the active academic term
                            DataRow[] activeRows = dt.Select("IsActive = True");

                            if (activeRows.Length > 0)
                            {
                                cboAcademicTerm.SelectedValue = activeRows[0]["TermID"];
                            }
                            else if (dt.Rows.Count > 0)
                            {
                                cboAcademicTerm.SelectedIndex = 0;
                            }

                            SetSelectedTermSession();
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

        private void SetSelectedTermSession()
        {
            if (cboAcademicTerm.SelectedValue == null)
            {
                AppSession.SelectedTermID = 0;
                AppSession.SelectedTermText = "";
                return;
            }

            if (int.TryParse(cboAcademicTerm.SelectedValue.ToString(), out int termID))
            {
                AppSession.SelectedTermID = termID;
                AppSession.SelectedTermText = cboAcademicTerm.Text;
            }
        }

        private void LoadDashboard()
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection conn = db.GetConnection();
                {
                    conn.Open();

                    lblTotalStudents.Text = GetCount(conn,
                        "SELECT COUNT(*) FROM Students WHERE IsDeleted = 0").ToString();

                    lblTotalCourses.Text = GetCount(conn,
                        "SELECT COUNT(*) FROM Courses WHERE IsDeleted = 0").ToString();

                    lblTotalDepartments.Text = GetCount(conn,
                        "SELECT COUNT(*) FROM Departments WHERE IsDeleted = 0").ToString();

                    lblPending.Text = GetClearanceCountByStatus(conn, "Pending").ToString();

                    lblCleared.Text = GetClearanceCountByStatus(conn, "Cleared").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dashboard data: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetCount(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToInt32(result);
            }
        }

        private int GetClearanceCountByStatus(SqlConnection conn, string status)
        {
            if (AppSession.SelectedTermID == 0)
            {
                return 0;
            }

            using (SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*)
                  FROM ClearanceRecords
                  WHERE Status = @status
                  AND IsDeleted = 0
                  AND TermID = @termID", conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@termID", AppSession.SelectedTermID);

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToInt32(result);
            }
        }

        private void cboAcademicTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingTerms)
            {
                return;
            }

            SetSelectedTermSession();
            LoadDashboard();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnAcademicTerms_Click(object sender, EventArgs e)
        {
            AcademicTermForm form = new AcademicTermForm();
            form.ShowDialog();

            LoadAcademicTerms();
            LoadDashboard();
        }

        private void btnCourseRequirements_Click(object sender, EventArgs e)
        {
            CourseRequirementForm form = new CourseRequirementForm();
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnClearance_Click(object sender, EventArgs e)
        {
            ClearanceForm form = new ClearanceForm();
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
            LoadDashboard();
        }


        private void btnRecycleBin_Click(object sender, EventArgs e)
        {
            RecycleBinForm form = new RecycleBinForm();
            form.ShowDialog();
            LoadDashboard();
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
    }
}


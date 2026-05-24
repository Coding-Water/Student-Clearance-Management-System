using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public class StudentDashboard : Form
    {
        private Label lblHeader;
        private Label lblWelcome;
        private Label lblTerm;
        private ComboBox cboAcademicTerm;
        private DataGridView dgvChecklist;
        private Button btnRefresh;
        private Button btnLogout;

        // Profile labels
        private Label lblStudentID;
        private Label lblCourse;
        private Label lblYearSection;

        private int studentID;
        private string studentName = "";
        private bool isInitializing = true;

        public StudentDashboard()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);

            if (int.TryParse(AppSession.LoggedInUsername, out int parsedID))
            {
                studentID = parsedID;
            }

            LoadStudentProfile();
            LoadAcademicTerms();
            isInitializing = false;
            LoadChecklist();
        }

        private void InitializeComponent()
        {
            this.lblHeader = new Label();
            this.lblWelcome = new Label();
            this.lblTerm = new Label();
            this.cboAcademicTerm = new ComboBox();
            this.dgvChecklist = new DataGridView();
            this.btnRefresh = new Button();
            this.btnLogout = new Button();

            this.lblStudentID = new Label();
            this.lblCourse = new Label();
            this.lblYearSection = new Label();

            this.SuspendLayout();

            // Form Properties
            this.ClientSize = new Size(820, 560);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard - Clearance Checklist";

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeader.ForeColor = UIHelper.ColorPrimary;
            this.lblHeader.Location = new Point(20, 20);
            this.lblHeader.Size = new Size(350, 30);
            this.lblHeader.Text = "My Clearance Checklist";

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(22, 60);
            this.lblWelcome.Size = new Size(400, 21);
            this.lblWelcome.Text = "Welcome, Student";

            // Profile info box (Labels)
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new Point(22, 95);
            this.lblStudentID.Text = "Student ID: ";

            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new Point(250, 95);
            this.lblCourse.Text = "Course: ";

            this.lblYearSection.AutoSize = true;
            this.lblYearSection.Location = new Point(550, 95);
            this.lblYearSection.Text = "Year / Section: ";

            // lblTerm
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new Point(22, 140);
            this.lblTerm.Text = "Academic Term:";

            // cboAcademicTerm
            this.cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboAcademicTerm.Location = new Point(145, 137);
            this.cboAcademicTerm.Size = new Size(300, 25);
            this.cboAcademicTerm.TabIndex = 1;
            this.cboAcademicTerm.SelectedIndexChanged += new EventHandler(this.cboAcademicTerm_SelectedIndexChanged);

            // dgvChecklist
            this.dgvChecklist.AllowUserToAddRows = false;
            this.dgvChecklist.AllowUserToDeleteRows = false;
            this.dgvChecklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChecklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChecklist.Location = new Point(22, 185);
            this.dgvChecklist.MultiSelect = false;
            this.dgvChecklist.Name = "dgvChecklist";
            this.dgvChecklist.ReadOnly = true;
            this.dgvChecklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvChecklist.Size = new Size(776, 290);
            this.dgvChecklist.TabIndex = 2;

            // btnRefresh
            this.btnRefresh.Location = new Point(480, 495);
            this.btnRefresh.Size = new Size(150, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH STATUS";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            // btnLogout
            this.btnLogout.Location = new Point(648, 495);
            this.btnLogout.Size = new Size(150, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // Adding controls
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblYearSection);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.cboAcademicTerm);
            this.Controls.Add(this.dgvChecklist);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadStudentProfile()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT s.FirstName, s.LastName, s.YearLevel, s.Section, c.CourseCode, c.CourseName
                                     FROM Students s
                                     INNER JOIN Courses c ON s.CourseID = c.CourseID
                                     WHERE s.StudentID = @studentID
                                     AND s.IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        studentName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        lblWelcome.Text = "Welcome, " + studentName + "!";
                        lblStudentID.Text = "Student ID: " + studentID.ToString();
                        lblCourse.Text = "Course: " + reader["CourseCode"].ToString() + " - " + reader["CourseName"].ToString();
                        lblYearSection.Text = "Year / Section: " + reader["YearLevel"].ToString() + " Year - " + reader["Section"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAcademicTerms()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT TermID, SchoolYear + ' - ' + Semester AS TermDisplay, IsActive
                                     FROM AcademicTerms
                                     WHERE IsDeleted = 0
                                     ORDER BY TermID DESC";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboAcademicTerm.DataSource = dt;
                        cboAcademicTerm.DisplayMember = "TermDisplay";
                        cboAcademicTerm.ValueMember = "TermID";

                        // Select active term by default
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading terms: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChecklist()
        {
            if (cboAcademicTerm.SelectedValue == null) return;

            try
            {
                int termID = Convert.ToInt32(cboAcademicTerm.SelectedValue);

                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT 
                                        d.DepartmentName AS [Department],
                                        cr.Status AS [Status],
                                        cr.Remarks AS [Remarks]
                                     FROM ClearanceRecords cr
                                     INNER JOIN Departments d ON cr.DepartmentID = d.DepartmentID
                                     WHERE cr.StudentID = @studentID
                                     AND cr.TermID = @termID
                                     AND cr.IsDeleted = 0
                                     AND d.IsDeleted = 0
                                     ORDER BY d.DepartmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@termID", termID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvChecklist.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading checklist: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAcademicTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            LoadChecklist();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadChecklist();
            MessageBox.Show("Clearance checklist refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                StudentLoginForm loginForm = new StudentLoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}

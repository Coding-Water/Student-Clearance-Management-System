using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
            LoadYearLevels();
            LoadCourses();
            CustomStyling();
        }

        private void CustomStyling()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void LoadYearLevels()
        {
            cboYearLevel.Items.Clear();
            cboYearLevel.Items.Add("1st");
            cboYearLevel.Items.Add("2nd");
            cboYearLevel.Items.Add("3rd");
            cboYearLevel.Items.Add("4th");
            cboYearLevel.Items.Add("Masteral");
            cboYearLevel.Items.Add("PhD");
            cboYearLevel.SelectedIndex = 0;
        }

        private void LoadCourses()
        {
            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT CourseID, CourseCode + ' - ' + CourseName AS CourseDisplay FROM Courses WHERE IsDeleted = 0";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboCourse.DataSource = dt;
                        cboCourse.DisplayMember = "CourseDisplay";
                        cboCourse.ValueMember = "CourseID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validations
            if (txtStudentID.Text.Trim() == "" ||
                txtFirstName.Text.Trim() == "" ||
                txtLastName.Text.Trim() == "" ||
                txtSection.Text.Trim() == "" ||
                txtPassword.Text == "" ||
                cboCourse.SelectedValue == null)
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStudentID.Text.Trim(), out int studentID))
            {
                MessageBox.Show("Student ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection db = new DBConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check if Student ID already exists in Students
                    SqlCommand checkID = new SqlCommand(
                        "SELECT COUNT(*) FROM Students WHERE StudentID = @id", conn);
                    checkID.Parameters.AddWithValue("@id", studentID);
                    if (Convert.ToInt32(checkID.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("This Student ID is already registered in the system.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if Username already exists in Users
                    SqlCommand checkUser = new SqlCommand(
                        "SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
                    checkUser.Parameters.AddWithValue("@username", txtStudentID.Text.Trim());
                    if (Convert.ToInt32(checkUser.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("This Student ID is already registered as a login user.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        // 1. Insert into Students
                        SqlCommand cmdStudent = new SqlCommand(
                            @"INSERT INTO Students (StudentID, FirstName, LastName, CourseID, YearLevel, Section, ContactNumber, IsDeleted)
                              VALUES (@id, @first, @last, @courseID, @year, @section, @contact, 0)",
                            conn, transaction);
                        cmdStudent.Parameters.AddWithValue("@id", studentID);
                        cmdStudent.Parameters.AddWithValue("@first", txtFirstName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@last", txtLastName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@courseID", cboCourse.SelectedValue);
                        cmdStudent.Parameters.AddWithValue("@year", cboYearLevel.Text);
                        cmdStudent.Parameters.AddWithValue("@section", txtSection.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmdStudent.ExecuteNonQuery();

                        // 2. Insert into Users
                        SqlCommand cmdUser = new SqlCommand(
                            @"INSERT INTO Users (Username, Password, Role, IsDeleted)
                              VALUES (@username, @password, 'student', 0)",
                            conn, transaction);
                        cmdUser.Parameters.AddWithValue("@username", txtStudentID.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmdUser.ExecuteNonQuery();

                        // 3. Check for Active Term and Auto-Generate Clearances
                        SqlCommand cmdActiveTerm = new SqlCommand(
                            "SELECT TermID FROM AcademicTerms WHERE IsActive = 1 AND IsDeleted = 0", conn, transaction);
                        object activeTermVal = cmdActiveTerm.ExecuteScalar();

                        bool checklistGenerated = false;
                        if (activeTermVal != null && activeTermVal != DBNull.Value)
                        {
                            int activeTermID = Convert.ToInt32(activeTermVal);

                            SqlCommand cmdGenChecklist = new SqlCommand(
                                @"INSERT INTO ClearanceRecords (StudentID, DepartmentID, TermID, Status, Remarks, IsDeleted)
                                  SELECT 
                                      @studentID,
                                      d.DepartmentID,
                                      @termID,
                                      'Pending',
                                      '',
                                      0
                                  FROM Departments d
                                  INNER JOIN CourseDepartmentRequirements cdr ON d.DepartmentID = cdr.DepartmentID
                                  WHERE cdr.CourseID = @courseID
                                  AND cdr.IsRequired = 1
                                  AND cdr.IsDeleted = 0
                                  AND d.IsDeleted = 0",
                                conn, transaction);

                            cmdGenChecklist.Parameters.AddWithValue("@studentID", studentID);
                            cmdGenChecklist.Parameters.AddWithValue("@termID", activeTermID);
                            cmdGenChecklist.Parameters.AddWithValue("@courseID", cboCourse.SelectedValue);
                            cmdGenChecklist.ExecuteNonQuery();

                            checklistGenerated = true;
                        }

                        transaction.Commit();

                        string message = "Registration successful! You can now log in.";
                        if (checklistGenerated)
                        {
                            message += "\n\nYour clearance checklist has been automatically generated for the active academic term.";
                        }
                        else
                        {
                            message += "\n\nNote: There is currently no active academic term. Your clearance checklist will be generated once an academic term is activated by the administrator.";
                        }

                        MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        StudentLoginForm login = new StudentLoginForm();
                        login.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Registration database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            StudentLoginForm login = new StudentLoginForm();
            login.Show();
            this.Close();
        }
    }
}

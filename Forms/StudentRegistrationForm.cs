using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public class StudentRegistrationForm : Form
    {
        private Label lblTitle;
        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblYearLevel;
        private Label lblSection;
        private Label lblContact;
        private Label lblCourse;
        private Label lblPassword;
        private Label lblConfirmPassword;

        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cboYearLevel;
        private TextBox txtSection;
        private TextBox txtContact;
        private ComboBox cboCourse;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private Button btnRegister;
        private Button btnBackToLogin;

        public StudentRegistrationForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
            LoadYearLevels();
            LoadCourses();
            CustomStyling();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblYearLevel = new Label();
            lblSection = new Label();
            lblContact = new Label();
            lblCourse = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cboYearLevel = new ComboBox();
            txtSection = new TextBox();
            txtContact = new TextBox();
            cboCourse = new ComboBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(79, 70, 229);
            lblTitle.Location = new Point(140, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Self Registration";
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(40, 80);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(150, 20);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID (Number):";
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(40, 155);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(150, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(298, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(150, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblYearLevel
            // 
            lblYearLevel.Location = new Point(40, 230);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(150, 20);
            lblYearLevel.TabIndex = 5;
            lblYearLevel.Text = "Year Level:";
            // 
            // lblSection
            // 
            lblSection.Location = new Point(298, 155);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(150, 20);
            lblSection.TabIndex = 6;
            lblSection.Text = "Section:";
            // 
            // lblContact
            // 
            lblContact.Location = new Point(31, 355);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(150, 20);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Number:";
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(40, 290);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(150, 20);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Select Course:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(31, 430);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Choose Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Location = new Point(31, 505);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(200, 20);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(40, 105);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(230, 23);
            txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(40, 180);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(298, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 23);
            txtLastName.TabIndex = 4;
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Location = new Point(40, 255);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(230, 23);
            cboYearLevel.TabIndex = 5;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(298, 180);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(230, 23);
            txtSection.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(31, 380);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(500, 23);
            txtContact.TabIndex = 7;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Location = new Point(40, 315);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(491, 23);
            cboCourse.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 455);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(500, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(31, 530);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(500, 23);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(31, 590);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(500, 45);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "CREATE STUDENT ACCOUNT";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(31, 650);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(500, 45);
            btnBackToLogin.TabIndex = 11;
            btnBackToLogin.Text = "CANCEL AND GO BACK";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // StudentRegistrationForm
            // 
            ClientSize = new Size(580, 703);
            Controls.Add(lblTitle);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblYearLevel);
            Controls.Add(cboYearLevel);
            Controls.Add(lblSection);
            Controls.Add(txtSection);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnBackToLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Self Registration";
            ResumeLayout(false);
            PerformLayout();
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

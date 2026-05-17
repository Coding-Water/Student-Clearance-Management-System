using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT UserID, Username, Password, Role
                                     FROM Users
                                     WHERE Username = @username
                                     AND Password = @password
                                     AND IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        AppSession.LoggedInUserID = Convert.ToInt32(reader["UserID"]);
                        AppSession.LoggedInUsername = reader["Username"].ToString();
                        AppSession.LoggedInRole = reader["Role"].ToString();

                        Admin admin = new Admin();
                        admin.UserID = AppSession.LoggedInUserID;
                        admin.Username = AppSession.LoggedInUsername;
                        admin.Role = AppSession.LoggedInRole;

                        MessageBox.Show(
                            "Login successful! Welcome " + AppSession.LoggedInUsername + ".",
                            "Login Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid username or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
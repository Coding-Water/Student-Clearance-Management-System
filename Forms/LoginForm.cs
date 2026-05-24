using System;
using System.Drawing;
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
            ApplyCardStyling();
        }

        /// <summary>
        /// Applies additional styling that cannot be expressed in the Designer,
        /// such as drop-shadow simulation, hover effects, and centering the card.
        /// </summary>
        private void ApplyCardStyling()
        {
            // Background gradient-like off-white
            this.BackColor = UIHelper.ColorBackground;

            // Center the card panel within the form
            pnlCard.Location = new Point(
                (this.ClientSize.Width - pnlCard.Width) / 2,
                (this.ClientSize.Height - pnlCard.Height) / 2);

            // Card visual: white background + subtle border
            pnlCard.BackColor = UIHelper.ColorCard;
            pnlCard.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, pnlCard.ClientRectangle,
                    UIHelper.ColorBorder, 1, ButtonBorderStyle.Solid,
                    UIHelper.ColorBorder, 1, ButtonBorderStyle.Solid,
                    UIHelper.ColorBorder, 1, ButtonBorderStyle.Solid,
                    UIHelper.ColorBorder, 1, ButtonBorderStyle.Solid);
            };

            // Style the LOGIN button
            btnLogin.BackColor = UIHelper.ColorPrimary;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = UIHelper.ColorPrimaryHover;
            btnLogin.Cursor = Cursors.Hand;

            // Student link hover effects
            lblStudentLink.ForeColor = UIHelper.ColorPrimary;
            lblStudentLink.MouseEnter += (s, e) => lblStudentLink.ForeColor = UIHelper.ColorPrimaryHover;
            lblStudentLink.MouseLeave += (s, e) => lblStudentLink.ForeColor = UIHelper.ColorPrimary;

            // Allow pressing Enter to submit
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter your username and password.",
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
                                     AND IsDeleted = 0
                                     AND Role IN ('Admin', 'Staff', 'admin', 'staff')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        AppSession.LoggedInUserID = Convert.ToInt32(reader["UserID"]);
                        AppSession.LoggedInUsername = reader["Username"].ToString();
                        AppSession.LoggedInRole = reader["Role"].ToString();

                        reader.Close();

                        MessageBox.Show(
                            $"Welcome back, {AppSession.LoggedInUsername}!",
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show(
                            "Invalid username or password. Please try again.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "A database error occurred:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Navigate to the Student Login portal.
        /// </summary>
        private void lblStudentLink_Click(object sender, EventArgs e)
        {
            StudentLoginForm studentLogin = new StudentLoginForm();
            studentLogin.Show();
            this.Hide();
        }
    }
}
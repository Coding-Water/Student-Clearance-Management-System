using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Clearance_Management_System.Database;
using Student_Clearance_Management_System.Models;

namespace Student_Clearance_Management_System.Forms
{
    public class ReEnterPasswordForm : Form
    {
        private Label lblWarning;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnVerify;
        private Button btnCancel;

        public ReEnterPasswordForm()
        {
            InitializeComponent();
            UIHelper.ApplyModernStyle(this);
        }

        private void InitializeComponent()
        {
            this.lblWarning = new Label();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnVerify = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Form properties
            this.ClientSize = new Size(400, 240);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReEnterPasswordForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Security Verification";

            // lblWarning
            this.lblWarning.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblWarning.ForeColor = UIHelper.ColorDelete;
            this.lblWarning.Location = new Point(30, 20);
            this.lblWarning.Size = new Size(340, 50);
            this.lblWarning.Text = "Attention: You are attempting to access administrative settings. Please re-enter your password to proceed.";
            this.lblWarning.TextAlign = ContentAlignment.MiddleCenter;

            // lblPassword
            this.lblPassword.Location = new Point(40, 90);
            this.lblPassword.Size = new Size(150, 20);
            this.lblPassword.Text = "Admin Password:";

            // txtPassword
            this.txtPassword.Location = new Point(40, 115);
            this.txtPassword.Size = new Size(320, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnVerify
            this.btnVerify.Location = new Point(40, 170);
            this.btnVerify.Size = new Size(150, 38);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new EventHandler(this.btnVerify_Click);

            // btnCancel
            this.btnCancel.Location = new Point(210, 170);
            this.btnCancel.Size = new Size(150, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // Controls
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM Users 
                                     WHERE Username = @username 
                                     AND Password = @password 
                                     AND Role = 'admin' 
                                     AND IsDeleted = 0";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", AppSession.LoggedInUsername);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Verification failed. Incorrect admin password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during verification: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

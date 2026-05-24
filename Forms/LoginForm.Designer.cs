namespace Student_Clearance_Management_System.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlCard = new Panel();
            lblAppName = new Label();
            lblTagline = new Label();
            lblDivider = new Label();
            lblPortalTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblStudentLink = new Label();
            pnlCard.SuspendLayout();
            SuspendLayout();

            // ──────────────────────────────────────────
            // pnlCard  (centered white card)
            // ──────────────────────────────────────────
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Location = new System.Drawing.Point(40, 40);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(30, 30, 30, 30);
            pnlCard.Size = new System.Drawing.Size(440, 460);
            pnlCard.Controls.Add(lblAppName);
            pnlCard.Controls.Add(lblTagline);
            pnlCard.Controls.Add(lblDivider);
            pnlCard.Controls.Add(lblPortalTitle);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblStudentLink);

            // ──────────────────────────────────────────
            // lblAppName  (large branding title)
            // ──────────────────────────────────────────
            lblAppName.AutoSize = false;
            lblAppName.Dock = DockStyle.None;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblAppName.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            lblAppName.Location = new System.Drawing.Point(20, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(400, 32);
            lblAppName.Text = "🎓  STUDENT CLEARANCE SYSTEM";
            lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ──────────────────────────────────────────
            // lblTagline
            // ──────────────────────────────────────────
            lblTagline.AutoSize = false;
            lblTagline.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            lblTagline.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            lblTagline.Location = new System.Drawing.Point(20, 58);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new System.Drawing.Size(400, 20);
            lblTagline.Text = "Paperless · Efficient · Transparent";
            lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ──────────────────────────────────────────
            // lblDivider  (thin visual separator line)
            // ──────────────────────────────────────────
            lblDivider.AutoSize = false;
            lblDivider.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            lblDivider.Location = new System.Drawing.Point(20, 90);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new System.Drawing.Size(400, 1);
            lblDivider.Text = "";

            // ──────────────────────────────────────────
            // lblPortalTitle  (section heading)
            // ──────────────────────────────────────────
            lblPortalTitle.AutoSize = false;
            lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPortalTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            lblPortalTitle.Location = new System.Drawing.Point(20, 108);
            lblPortalTitle.Name = "lblPortalTitle";
            lblPortalTitle.Size = new System.Drawing.Size(400, 26);
            lblPortalTitle.Text = "Staff / Admin Login";
            lblPortalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ──────────────────────────────────────────
            // lblUsername
            // ──────────────────────────────────────────
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblUsername.Location = new System.Drawing.Point(20, 156);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username";

            // ──────────────────────────────────────────
            // txtUsername
            // ──────────────────────────────────────────
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUsername.Location = new System.Drawing.Point(20, 178);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(400, 30);
            txtUsername.TabIndex = 1;
            txtUsername.PlaceholderText = "Enter your username";

            // ──────────────────────────────────────────
            // lblPassword
            // ──────────────────────────────────────────
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblPassword.Location = new System.Drawing.Point(20, 228);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password";

            // ──────────────────────────────────────────
            // txtPassword
            // ──────────────────────────────────────────
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPassword.Location = new System.Drawing.Point(20, 250);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(400, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PlaceholderText = "Enter your password";

            // ──────────────────────────────────────────
            // btnLogin
            // ──────────────────────────────────────────
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            btnLogin.Location = new System.Drawing.Point(20, 305);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(400, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // ──────────────────────────────────────────
            // lblStudentLink  (link to StudentLoginForm)
            // ──────────────────────────────────────────
            lblStudentLink.AutoSize = false;
            lblStudentLink.Cursor = Cursors.Hand;
            lblStudentLink.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Underline);
            lblStudentLink.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            lblStudentLink.Location = new System.Drawing.Point(20, 370);
            lblStudentLink.Name = "lblStudentLink";
            lblStudentLink.Size = new System.Drawing.Size(400, 22);
            lblStudentLink.Text = "Are you a student? Click here to login";
            lblStudentLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblStudentLink.Click += lblStudentLink_Click;

            // ──────────────────────────────────────────
            // LoginForm
            // ──────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 540);
            Controls.Add(pnlCard);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff / Admin Login — Student Clearance System";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblAppName;
        private Label lblTagline;
        private Label lblDivider;
        private Label lblPortalTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblStudentLink;
    }
}
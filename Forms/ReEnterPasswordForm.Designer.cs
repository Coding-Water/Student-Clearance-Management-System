using System;
using System.Drawing;
using System.Windows.Forms;
using Student_Clearance_Management_System.Database;

namespace Student_Clearance_Management_System.Forms
{
    partial class ReEnterPasswordForm
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

        #endregion

        private Label lblWarning;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnVerify;
        private Button btnCancel;
    }
}

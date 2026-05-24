using System;
using System.Drawing;
using System.Windows.Forms;
using Student_Clearance_Management_System.Models;
using Student_Clearance_Management_System.Database;

namespace Student_Clearance_Management_System.Forms
{
    partial class StudentDashboard
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

        #endregion

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
    }
}

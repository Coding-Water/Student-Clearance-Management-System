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
            lblHeader = new Label();
            lblWelcome = new Label();
            lblTerm = new Label();
            cboAcademicTerm = new ComboBox();
            dgvChecklist = new DataGridView();
            btnRefresh = new Button();
            btnLogout = new Button();
            lblStudentID = new Label();
            lblCourse = new Label();
            lblYearSection = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChecklist).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(79, 70, 229);
            lblHeader.Location = new Point(20, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(252, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "My Clearance Checklist";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(22, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(150, 21);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Student";
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(22, 153);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(93, 15);
            lblTerm.TabIndex = 5;
            lblTerm.Text = "Academic Term:";
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Location = new Point(145, 150);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(300, 23);
            cboAcademicTerm.TabIndex = 1;
            cboAcademicTerm.SelectedIndexChanged += cboAcademicTerm_SelectedIndexChanged;
            // 
            // dgvChecklist
            // 
            dgvChecklist.AllowUserToAddRows = false;
            dgvChecklist.AllowUserToDeleteRows = false;
            dgvChecklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChecklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChecklist.Location = new Point(22, 185);
            dgvChecklist.MultiSelect = false;
            dgvChecklist.Name = "dgvChecklist";
            dgvChecklist.ReadOnly = true;
            dgvChecklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChecklist.Size = new Size(776, 290);
            dgvChecklist.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(480, 495);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH STATUS";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(648, 495);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(22, 95);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(68, 15);
            lblStudentID.TabIndex = 2;
            lblStudentID.Text = "Student ID: ";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(250, 95);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(50, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course: ";
            // 
            // lblYearSection
            // 
            lblYearSection.AutoSize = true;
            lblYearSection.Location = new Point(250, 123);
            lblYearSection.Name = "lblYearSection";
            lblYearSection.Size = new Size(85, 15);
            lblYearSection.TabIndex = 4;
            lblYearSection.Text = "Year / Section: ";
            // 
            // StudentDashboard
            // 
            ClientSize = new Size(820, 560);
            Controls.Add(lblHeader);
            Controls.Add(lblWelcome);
            Controls.Add(lblStudentID);
            Controls.Add(lblCourse);
            Controls.Add(lblYearSection);
            Controls.Add(lblTerm);
            Controls.Add(cboAcademicTerm);
            Controls.Add(dgvChecklist);
            Controls.Add(btnRefresh);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard - Clearance Checklist";
            ((System.ComponentModel.ISupportInitialize)dgvChecklist).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

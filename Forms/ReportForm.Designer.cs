using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Forms
{
    partial class ReportForm
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            btnBack = new Button();
            grpFilters = new GroupBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblReportMode = new Label();
            cboReportMode = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblCourse = new Label();
            cboCourse = new ComboBox();
            lblAcademicTerm = new Label();
            cboAcademicTerm = new ComboBox();
            pnlStats = new Panel();
            pnlStatRate = new Panel();
            lblRateVal = new Label();
            lblRateTitle = new Label();
            pnlStatPending = new Panel();
            lblPendingVal = new Label();
            lblPendingTitle = new Label();
            pnlStatCleared = new Panel();
            lblClearedVal = new Label();
            lblClearedTitle = new Label();
            pnlStatTotal = new Panel();
            lblTotalVal = new Label();
            lblTotalTitle = new Label();
            dgvReports = new DataGridView();
            btnExport = new Button();
            btnReset = new Button();
            pnlHeader.SuspendLayout();
            grpFilters.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlStatRate.SuspendLayout();
            pnlStatPending.SuspendLayout();
            pnlStatCleared.SuspendLayout();
            pnlStatTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(896, 45);
            pnlHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(70, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(826, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "📊  Clearance Reports & Analytics";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(67, 56, 202);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 45);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // grpFilters
            // 
            grpFilters.Controls.Add(lblSearch);
            grpFilters.Controls.Add(txtSearch);
            grpFilters.Controls.Add(lblReportMode);
            grpFilters.Controls.Add(cboReportMode);
            grpFilters.Controls.Add(lblStatus);
            grpFilters.Controls.Add(cboStatus);
            grpFilters.Controls.Add(lblCourse);
            grpFilters.Controls.Add(cboCourse);
            grpFilters.Controls.Add(lblAcademicTerm);
            grpFilters.Controls.Add(cboAcademicTerm);
            grpFilters.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFilters.Location = new Point(10, 52);
            grpFilters.Margin = new Padding(3, 2, 3, 2);
            grpFilters.Name = "grpFilters";
            grpFilters.Padding = new Padding(3, 2, 3, 2);
            grpFilters.Size = new Size(875, 75);
            grpFilters.TabIndex = 1;
            grpFilters.TabStop = false;
            grpFilters.Text = "Report Filter Criteria";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(652, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(124, 17);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search Student/Rec:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(652, 36);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblReportMode
            // 
            lblReportMode.AutoSize = true;
            lblReportMode.Location = new Point(481, 19);
            lblReportMode.Name = "lblReportMode";
            lblReportMode.Size = new Size(82, 17);
            lblReportMode.TabIndex = 7;
            lblReportMode.Text = "Report Type:";
            // 
            // cboReportMode
            // 
            cboReportMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboReportMode.FormattingEnabled = true;
            cboReportMode.Location = new Point(481, 36);
            cboReportMode.Margin = new Padding(3, 2, 3, 2);
            cboReportMode.Name = "cboReportMode";
            cboReportMode.Size = new Size(158, 28);
            cboReportMode.TabIndex = 6;
            cboReportMode.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(337, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(107, 17);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Clearance Status:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(337, 36);
            cboStatus.Margin = new Padding(3, 2, 3, 2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(132, 28);
            cboStatus.TabIndex = 4;
            cboStatus.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(175, 19);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(52, 17);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(175, 36);
            cboCourse.Margin = new Padding(3, 2, 3, 2);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(149, 28);
            cboCourse.TabIndex = 2;
            cboCourse.SelectedIndexChanged += FilterControl_Changed;
            // 
            // lblAcademicTerm
            // 
            lblAcademicTerm.AutoSize = true;
            lblAcademicTerm.Location = new Point(13, 19);
            lblAcademicTerm.Name = "lblAcademicTerm";
            lblAcademicTerm.Size = new Size(100, 17);
            lblAcademicTerm.TabIndex = 1;
            lblAcademicTerm.Text = "Academic Term:";
            // 
            // cboAcademicTerm
            // 
            cboAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicTerm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAcademicTerm.FormattingEnabled = true;
            cboAcademicTerm.Location = new Point(13, 36);
            cboAcademicTerm.Margin = new Padding(3, 2, 3, 2);
            cboAcademicTerm.Name = "cboAcademicTerm";
            cboAcademicTerm.Size = new Size(149, 28);
            cboAcademicTerm.TabIndex = 0;
            cboAcademicTerm.SelectedIndexChanged += FilterControl_Changed;
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlStatRate);
            pnlStats.Controls.Add(pnlStatPending);
            pnlStats.Controls.Add(pnlStatCleared);
            pnlStats.Controls.Add(pnlStatTotal);
            pnlStats.Location = new Point(10, 135);
            pnlStats.Margin = new Padding(3, 2, 3, 2);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(875, 60);
            pnlStats.TabIndex = 2;
            // 
            // pnlStatRate
            // 
            pnlStatRate.BorderStyle = BorderStyle.FixedSingle;
            pnlStatRate.Controls.Add(lblRateVal);
            pnlStatRate.Controls.Add(lblRateTitle);
            pnlStatRate.Location = new Point(667, 0);
            pnlStatRate.Margin = new Padding(3, 2, 3, 2);
            pnlStatRate.Name = "pnlStatRate";
            pnlStatRate.Size = new Size(208, 60);
            pnlStatRate.TabIndex = 3;
            // 
            // lblRateVal
            // 
            lblRateVal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRateVal.ForeColor = Color.DarkBlue;
            lblRateVal.Location = new Point(3, 22);
            lblRateVal.Name = "lblRateVal";
            lblRateVal.Size = new Size(201, 28);
            lblRateVal.TabIndex = 1;
            lblRateVal.Text = "0.0%";
            lblRateVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRateTitle
            // 
            lblRateTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRateTitle.ForeColor = Color.DarkBlue;
            lblRateTitle.Location = new Point(3, 6);
            lblRateTitle.Name = "lblRateTitle";
            lblRateTitle.Size = new Size(201, 14);
            lblRateTitle.TabIndex = 0;
            lblRateTitle.Text = "CLEARANCE RATE";
            lblRateTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatPending
            // 
            pnlStatPending.BorderStyle = BorderStyle.FixedSingle;
            pnlStatPending.Controls.Add(lblPendingVal);
            pnlStatPending.Controls.Add(lblPendingTitle);
            pnlStatPending.Location = new Point(444, 0);
            pnlStatPending.Margin = new Padding(3, 2, 3, 2);
            pnlStatPending.Name = "pnlStatPending";
            pnlStatPending.Size = new Size(208, 60);
            pnlStatPending.TabIndex = 2;
            // 
            // lblPendingVal
            // 
            lblPendingVal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingVal.ForeColor = Color.DarkOrange;
            lblPendingVal.Location = new Point(3, 22);
            lblPendingVal.Name = "lblPendingVal";
            lblPendingVal.Size = new Size(201, 28);
            lblPendingVal.TabIndex = 1;
            lblPendingVal.Text = "0";
            lblPendingVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingTitle.ForeColor = Color.DarkOrange;
            lblPendingTitle.Location = new Point(3, 6);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(201, 14);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "PENDING STUDENTS";
            lblPendingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatCleared
            // 
            pnlStatCleared.BorderStyle = BorderStyle.FixedSingle;
            pnlStatCleared.Controls.Add(lblClearedVal);
            pnlStatCleared.Controls.Add(lblClearedTitle);
            pnlStatCleared.Location = new Point(222, 0);
            pnlStatCleared.Margin = new Padding(3, 2, 3, 2);
            pnlStatCleared.Name = "pnlStatCleared";
            pnlStatCleared.Size = new Size(208, 60);
            pnlStatCleared.TabIndex = 1;
            // 
            // lblClearedVal
            // 
            lblClearedVal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClearedVal.ForeColor = Color.DarkGreen;
            lblClearedVal.Location = new Point(3, 22);
            lblClearedVal.Name = "lblClearedVal";
            lblClearedVal.Size = new Size(201, 28);
            lblClearedVal.TabIndex = 1;
            lblClearedVal.Text = "0";
            lblClearedVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClearedTitle
            // 
            lblClearedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClearedTitle.ForeColor = Color.DarkGreen;
            lblClearedTitle.Location = new Point(3, 6);
            lblClearedTitle.Name = "lblClearedTitle";
            lblClearedTitle.Size = new Size(201, 14);
            lblClearedTitle.TabIndex = 0;
            lblClearedTitle.Text = "FULLY CLEARED";
            lblClearedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatTotal
            // 
            pnlStatTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlStatTotal.Controls.Add(lblTotalVal);
            pnlStatTotal.Controls.Add(lblTotalTitle);
            pnlStatTotal.Location = new Point(0, 0);
            pnlStatTotal.Margin = new Padding(3, 2, 3, 2);
            pnlStatTotal.Name = "pnlStatTotal";
            pnlStatTotal.Size = new Size(208, 60);
            pnlStatTotal.TabIndex = 0;
            // 
            // lblTotalVal
            // 
            lblTotalVal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVal.ForeColor = Color.Black;
            lblTotalVal.Location = new Point(3, 22);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(201, 28);
            lblTotalVal.TabIndex = 1;
            lblTotalVal.Text = "0";
            lblTotalVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.ForeColor = Color.Gray;
            lblTotalTitle.Location = new Point(3, 6);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(201, 14);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "TOTAL STUDENTS";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = SystemColors.Window;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvReports.Location = new Point(10, 202);
            dgvReports.Margin = new Padding(3, 2, 3, 2);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersWidth = 35;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(875, 262);
            dgvReports.TabIndex = 3;
            dgvReports.CellFormatting += dgvReports_CellFormatting;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(22, 163, 74);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(10, 472);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 28);
            btnExport.TabIndex = 4;
            btnExport.Text = "📤  Export to CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(107, 114, 128);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(159, 472);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 28);
            btnReset.TabIndex = 5;
            btnReset.Text = "↺  Reset Filters";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 508);
            Controls.Add(btnReset);
            Controls.Add(btnExport);
            Controls.Add(dgvReports);
            Controls.Add(pnlStats);
            Controls.Add(grpFilters);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(790, 460);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports & Analytics — Clearance System";
            Load += ReportForm_Load;
            pnlHeader.ResumeLayout(false);
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlStatRate.ResumeLayout(false);
            pnlStatPending.ResumeLayout(false);
            pnlStatCleared.ResumeLayout(false);
            pnlStatTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private GroupBox grpFilters;
        private ComboBox cboAcademicTerm;
        private Label lblAcademicTerm;
        private Label lblCourse;
        private ComboBox cboCourse;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblReportMode;
        private ComboBox cboReportMode;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlStats;
        private Panel pnlStatTotal;
        private Label lblTotalVal;
        private Label lblTotalTitle;
        private Panel pnlStatCleared;
        private Label lblClearedVal;
        private Label lblClearedTitle;
        private Panel pnlStatPending;
        private Label lblPendingVal;
        private Label lblPendingTitle;
        private Panel pnlStatRate;
        private Label lblRateVal;
        private Label lblRateTitle;
        private DataGridView dgvReports;
        private Button btnExport;
        private Button btnReset;
        private Panel pnlHeader;
        private Button btnBack;
        private Button button1;
    }
}
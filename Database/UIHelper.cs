using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Clearance_Management_System.Database
{
    public static class UIHelper
    {
        // Premium HSL and Tailored Colors
        public static readonly Color ColorPrimary = Color.FromArgb(79, 70, 229);      // Premium Indigo
        public static readonly Color ColorPrimaryHover = Color.FromArgb(67, 56, 202); // Darker Indigo
        public static readonly Color ColorSecondary = Color.FromArgb(107, 114, 128);  // Slate Gray
        public static readonly Color ColorSecondaryHover = Color.FromArgb(75, 85, 99);
        public static readonly Color ColorDelete = Color.FromArgb(220, 38, 38);       // Modern Red
        public static readonly Color ColorDeleteHover = Color.FromArgb(185, 28, 28);
        public static readonly Color ColorBackground = Color.FromArgb(249, 250, 251);  // Off-white background
        public static readonly Color ColorCard = Color.White;
        public static readonly Color ColorTextDark = Color.FromArgb(17, 24, 39);      // Slate 900
        public static readonly Color ColorBorder = Color.FromArgb(229, 231, 235);     // Gray 200

        public static void ApplyModernStyle(Form form)
        {
            form.BackColor = ColorBackground;
            form.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // Set Form padding or visual border style if applicable
            foreach (Control ctrl in form.Controls)
            {
                StyleControl(ctrl);
            }
        }

        private static void StyleControl(Control ctrl)
        {
            // Set default font
            if (!(ctrl is DataGridView))
            {
                ctrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }

            if (ctrl is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
                btn.Height = Math.Max(btn.Height, 38); // Ensure comfortable height

                string text = btn.Text.ToLower();
                if (text.Contains("delete") || text.Contains("permanently") || text.Contains("remove"))
                {
                    btn.BackColor = ColorDelete;
                    btn.FlatAppearance.MouseOverBackColor = ColorDeleteHover;
                }
                else if (text.Contains("clear") || text.Contains("reset") || text.Contains("back") || text.Contains("cancel") || text.Contains("close"))
                {
                    btn.BackColor = ColorSecondary;
                    btn.FlatAppearance.MouseOverBackColor = ColorSecondaryHover;
                }
                else
                {
                    btn.BackColor = ColorPrimary;
                    btn.FlatAppearance.MouseOverBackColor = ColorPrimaryHover;
                }
            }
            else if (ctrl is TextBox txt)
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.ForeColor = ColorTextDark;
            }
            else if (ctrl is ComboBox cbo)
            {
                cbo.FlatStyle = FlatStyle.Flat;
                cbo.ForeColor = ColorTextDark;
            }
            else if (ctrl is DataGridView dgv)
            {
                FormatModernGrid(dgv);
            }
            else if (ctrl is Panel pnl)
            {
                foreach (Control subCtrl in pnl.Controls)
                {
                    StyleControl(subCtrl);
                }
            }
            else if (ctrl is TabControl tab)
            {
                foreach (TabPage page in tab.TabPages)
                {
                    page.BackColor = ColorCard;
                    foreach (Control pageCtrl in page.Controls)
                    {
                        StyleControl(pageCtrl);
                    }
                }
            }
            else if (ctrl is GroupBox grp)
            {
                grp.ForeColor = ColorSecondary;
                foreach (Control grpCtrl in grp.Controls)
                {
                    StyleControl(grpCtrl);
                }
            }
        }

        public static void FormatModernGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ColorBorder;
            dgv.BackgroundColor = ColorCard;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            // Row Template styling
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = ColorTextDark;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255); // Indigo selection light
            dgv.DefaultCellStyle.SelectionForeColor = ColorPrimary;

            // Headers formatting
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246); // Light slate
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(55, 65, 81);     // Text dark slate
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 38;

            // Hook the status color formatting automatically
            dgv.CellFormatting -= Dgv_CellFormatting; // Prevent multiple hookups
            dgv.CellFormatting += Dgv_CellFormatting;
        }

        private static void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var dgv = (DataGridView)sender;
            string colName = dgv.Columns[e.ColumnIndex].Name;

            if (colName == "Status" || colName == "Overall Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Cleared")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);     // Dark Green
                        e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);  // Soft Green
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                    }
                    else if (status == "Pending")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(154, 52, 18);     // Dark Orange
                        e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);  // Soft Orange
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                    }
                    else if (status == "Not Cleared")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);     // Dark Red
                        e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);  // Soft Red
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                    }
                }
            }
        }
    }
}

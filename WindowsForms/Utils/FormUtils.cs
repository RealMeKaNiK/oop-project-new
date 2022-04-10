using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Utils
{
    public static class FormUtils
    {
        public static void PrintDataGridView(DataGridView grid, string title)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = title;
            printer.SubTitle = "OOPNET Project";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Alan Dautovic APP";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(grid);
        }

        public static void CheckIfListCountZero<T>(List<T> neceg )
        {
            if (neceg.Count == 0)
            {
                MessageBox.Show("Please go to settings and setup your configuration. \nNeeded Config: Competition Type, Language, Selected Team", "Config Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DialogResult DisplayMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) => MessageBox.Show(text, caption, buttons, icon);
    }
}

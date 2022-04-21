using DataAccessLayer;
using DataAccessLayer.Model;
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
        public static void SetFormLanguage()
        {
            DataProvider.LoadConfiguration();
            switch (DataProvider.GetLanguage())
            {
                case DataAccessLayer.Model.Language.NotSet:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
                case DataAccessLayer.Model.Language.English:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
                case DataAccessLayer.Model.Language.Croatian:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("hr-HR");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("hr-HR");
                    break;
                default:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
            }
        }

        public static void SetFormLanguage(Language language)
        {
            switch (language)
            {
                case DataAccessLayer.Model.Language.NotSet:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
                case DataAccessLayer.Model.Language.English:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
                case DataAccessLayer.Model.Language.Croatian:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("hr-HR");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("hr-HR");
                    break;
                default:
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                    break;
            }
        }
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
                DisplayErrorMessageBox("Configuration missing, go setup your config", "Config Error");
            }
        }

        public static void DisplayErrorMessageBox(string description, string title) 
            => MessageBox.Show(description, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void DisplaySuccessMessageBox(string description, string title)
            => MessageBox.Show(description, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

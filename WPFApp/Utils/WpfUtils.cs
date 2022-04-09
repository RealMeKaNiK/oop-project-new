using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFApp.Utils
{
    public static class WpfUtils
    {
        public static void ChangeResolution(ResolutionType type)
        {
            switch (type)
            {
                case ResolutionType.Fullscreen:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.None;
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    break;
                case ResolutionType.Big:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.Width = 1700;
                    Application.Current.MainWindow.Height = 960;
                    break;
                case ResolutionType.Normal:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    break;
                default:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    break;
            }
        }
    }
}

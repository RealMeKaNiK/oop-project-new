using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPFApp.Utils
{
    public static class WpfUtils
    {
        private static double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
        private static double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
        private static double windowWidth = Application.Current.MainWindow.Width;
        private static double windowHeight = Application.Current.MainWindow.Height;
        private static void CenterWindowOnScreen()
        {
            Application.Current.MainWindow.Left = (screenWidth / 2) - (windowWidth / 2);
            Application.Current.MainWindow.Top = (screenHeight / 2) - (windowHeight / 2);
        }
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
                    Application.Current.MainWindow.Width = 1500;
                    Application.Current.MainWindow.Height = 900;
                    break;
                case ResolutionType.Normal:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.Width = 1200;
                    Application.Current.MainWindow.Height = 800;
                    break;
                default:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.Width = 1200;
                    Application.Current.MainWindow.Height = 800;
                    break;
            }
        }

        public static BitmapImage ConvertBitmap(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }
}

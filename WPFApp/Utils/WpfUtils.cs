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

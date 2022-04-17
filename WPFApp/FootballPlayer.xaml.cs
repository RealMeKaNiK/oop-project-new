using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFApp.Utils;
using WPFApp.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for FootballPlayer.xaml
    /// </summary>
    public partial class FootballPlayer : UserControl
    {
        private Player Player;
        public FootballPlayer(Player player)
        {
            InitializeComponent();
            Player = player;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.lblPlayerInfo.Content = $"{Player.name.Replace(' ', '\n')}{System.Environment.NewLine}{Player.shirt_number}";
            this.imgPlayer.Source = ConvertImageForWpf(Player.Picture);
        }

        private BitmapImage ConvertImageForWpf(Bitmap picture)
        {
            MemoryStream ms = new MemoryStream();
            picture.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            BitmapImage newImage = new BitmapImage();
            newImage.BeginInit();
            newImage.CacheOption = BitmapCacheOption.OnLoad;
            newImage.StreamSource = ms;
            newImage.EndInit();

            return newImage;
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e) => new ShowInfoAboutPlayer(Player).Show();       
    }
}

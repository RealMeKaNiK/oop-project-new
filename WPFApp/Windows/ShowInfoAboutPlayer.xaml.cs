using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WPFApp.Utils;

namespace WPFApp.Windows
{
    /// <summary>
    /// Interaction logic for ShowInfoAboutPlayer.xaml
    /// </summary>
    public partial class ShowInfoAboutPlayer : Window
    {
        private Player Player;
        public ShowInfoAboutPlayer(Player player)
        {
            InitializeComponent();
            Player = player;
        }

        private void Button_Click(object sender, RoutedEventArgs e) => this.Close();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.imgPlayer.Source = WpfUtils.ConvertBitmap(Player.Picture);
            this.lblPlayerInfo.Content = Player;
        }
    }
}

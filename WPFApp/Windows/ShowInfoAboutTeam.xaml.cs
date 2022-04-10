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

namespace WPFApp.Windows
{
    /// <summary>
    /// Interaction logic for ShowInfoAboutTeam.xaml
    /// </summary>
    public partial class ShowInfoAboutTeam : Window
    {
        private string TeamStatistics;
        public ShowInfoAboutTeam(string teamStats)
        {
            InitializeComponent();
            TeamStatistics = teamStats;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) => this.lblTeamInfo.Content = TeamStatistics;

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}

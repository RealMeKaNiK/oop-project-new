using DataAccessLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFApp.Windows;

namespace WPFApp.Pages
{
    /// <summary>
    /// Interaction logic for MatchChooserPage.xaml
    /// </summary>
    public partial class MatchChooserPage : Page
    {
        public MatchChooserPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e) => this.cbSelectedTeam.ItemsSource = await DataProvider.GetTeams();

        private async void cbSelectedTeam_SelectionChanged(object sender, SelectionChangedEventArgs e) => this.cbSelectedTeamOpponents.ItemsSource = await DataProvider.GetTeamOpponents(((Team)this.cbSelectedTeam.SelectedItem).Fifa_Code);

        private async void btnShowResults_Click(object sender, RoutedEventArgs e) => this.lblResult.Content = await DataProvider.GetMatchWinner(((Team)this.cbSelectedTeam.SelectedItem).Fifa_Code, ((Team)this.cbSelectedTeamOpponents.SelectedItem).Fifa_Code);

        private void btmShowFavTeamInfo_Click(object sender, RoutedEventArgs e) => ShowInformationAboutTeam(((Team)this.cbSelectedTeam.SelectedItem));

        private void btnShowOppTeamInfo_Click(object sender, RoutedEventArgs e) => ShowInformationAboutTeam(((Team)this.cbSelectedTeamOpponents.SelectedItem));        

        private async void ShowInformationAboutTeam(Team team)
        {
            if (team == null)
            {
                MessageBox.Show("Please select a team first, before showing statisctics", "TEAM SELECT", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            List<Team> tim = await DataProvider.GetTeamStatistics(team.Fifa_Code);
            new ShowInfoAboutTeam(tim.First<Team>().PrepareForDisplayOutput()).Show();
        }
    }
}

using DataAccessLayer;
using DataAccessLayer.Dal;
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

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.spOppTeam.Visibility = Visibility.Collapsed;
            this.cbSelectedTeam.ItemsSource = await DataProvider.GetTeams();
        }

        private async void cbSelectedTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.spOppTeam.Visibility = Visibility.Visible;
            this.cbSelectedTeamOpponents.ItemsSource = await DataProvider.GetTeamOpponents(((Team)this.cbSelectedTeam.SelectedItem).Fifa_Code);
        } 

        private async void btnShowResults_Click(object sender, RoutedEventArgs e)
        {
            if (this.cbSelectedTeam.SelectedItem == null || this.cbSelectedTeamOpponents.SelectedItem == null)
            {
                MessageBox.Show("Please select both options before getting result", "Select Two Teams", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            this.imgLoadingAnimation.Visibility = Visibility.Visible;
            CleanBoard();
            Match selectedMatch = await DataProvider.GetMatchWinner(((Team)this.cbSelectedTeam.SelectedItem).Fifa_Code, ((Team)this.cbSelectedTeamOpponents.SelectedItem).Fifa_Code);
            this.lblResult.Content = selectedMatch;
            DisplayFootballPlayersOnTheField(selectedMatch);
            this.imgLoadingAnimation.Visibility= Visibility.Collapsed;
            this.spStatButtons.Visibility = Visibility.Visible;
            this.btmShowFavTeamInfo.Content = $"{((Team)this.cbSelectedTeam.SelectedItem).Country} STATS";
            this.btnShowOppTeamInfo.Content = $"{((Team)this.cbSelectedTeamOpponents.SelectedItem).Country} STATS";
        }

        private void CleanBoard()
        {
            this.spDefenderPosition.Children.Clear();
            this.spDefenderPositionOpp.Children.Clear();
            this.spForwardPosition.Children.Clear();
            this.spForwardPositionOpp.Children.Clear();
            this.spMiddlePosition.Children.Clear();
            this.spMiddlePositionOpp.Children.Clear();
            this.spGoaliePosition.Children.Clear();
            this.spGoaliePositionOpp.Children.Clear();
        }

        private void DisplayFootballPlayersOnTheField(Match match)
        {
            IRepo imgLoader = FileRepoFactory.GetRepo();

            List<Player> homeTeam = imgLoader.LoadPicutres(match.home_team_statistics.starting_eleven, match.home_team.code);
            List<Player> awayTeam = imgLoader.LoadPicutres(match.away_team_statistics.starting_eleven, match.away_team.code);

            homeTeam.ForEach(player =>
            {
                switch (player.position)
                {
                    case "Goalie":
                        this.spGoaliePosition.Children.Add(new FootballPlayer(player));
                        break;
                    case "Defender":
                        this.spDefenderPosition.Children.Add(new FootballPlayer(player));
                        break;
                    case "Midfield":
                        this.spMiddlePosition.Children.Add(new FootballPlayer(player));
                        break;
                    case "Forward":
                        this.spForwardPosition.Children.Add(new FootballPlayer(player));
                        break;
                    default:
                        break;
                }
            });
            awayTeam.ForEach(player =>
            {
                switch (player.position)
                {
                    case "Goalie":
                        this.spGoaliePositionOpp.Children.Add(new FootballPlayer(player));
                        break;
                    case "Defender":
                        this.spDefenderPositionOpp.Children.Add(new FootballPlayer(player));
                        break;
                    case "Midfield":
                        this.spMiddlePositionOpp.Children.Add(new FootballPlayer(player));
                        break;
                    case "Forward":
                        this.spForwardPositionOpp.Children.Add(new FootballPlayer(player));
                        break;
                    default:
                        break;
                }
            });

        }

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
            new ShowInfoAboutTeam(tim.FirstOrDefault<Team>().PrepareForDisplayOutput()).Show();
        }
    }
}

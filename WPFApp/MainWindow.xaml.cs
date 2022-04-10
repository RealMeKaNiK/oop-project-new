using DataAccessLayer;
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
using WPFApp.Pages;
using WPFApp.Utils;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChooseTeam_Click(object sender, RoutedEventArgs e) => this.MainFrame.Content = new MatchChooserPage();

        private void btnSettings_Click(object sender, RoutedEventArgs e) => this.MainFrame.Content = new SettingsPage();

        private void btnQuitApp_Click(object sender, RoutedEventArgs e)
        {
            if (ShowClosingProcess() == MessageBoxResult.Yes)
            {
                DataProvider.SaveConfig();
                Application.Current.Shutdown();
                return;
            }            
        }

        private MessageBoxResult ShowClosingProcess() => MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!DataProvider.LoadConfiguration())
            {
                WpfUtils.ChangeResolution(DataProvider.GetResolutionType());
                this.MainFrame.Content = new SettingsPage();
                return;
            }
            WpfUtils.ChangeResolution(DataProvider.GetResolutionType());
            this.MainFrame.Content = new MatchChooserPage();
        }
    }
}

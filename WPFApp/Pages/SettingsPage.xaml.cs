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
using WPFApp.Utils;

namespace WPFApp.Pages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void btnSaveConfig_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(this.cbTeam.Text) || String.IsNullOrEmpty(this.cbLanguage.Text) || String.IsNullOrEmpty(this.cbResolution.Text))
            {
                MessageBox.Show("Please select all settings before saving", "Choose All Settings", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to change settings?", "Settings Change", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                DataProvider.UpdateConfig((TeamType)Enum.Parse(typeof(TeamType), this.cbTeam.Text), (Language)Enum.Parse(typeof(Language), this.cbLanguage.Text), (ResolutionType)Enum.Parse(typeof(ResolutionType), this.cbResolution.Text));
                WpfUtils.ChangeResolution((ResolutionType)Enum.Parse(typeof(ResolutionType), this.cbResolution.Text));
                WpfUtils.SetFormLanguage((Language)Enum.Parse(typeof(Language), this.cbLanguage.Text));
                //UpdateUI();
            }
                
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SetupUI();
        }       

        private void SetupUI()
        {
            this.lblCurrentSettings.Content = DataProvider.GetConfigInfo();
        }

        private void UpdateUI()
        {
           this.mainGridSettings.Children.Clear();
           InitializeComponent();
           SetupUI();
        }
    }
}

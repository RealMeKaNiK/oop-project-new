using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Utils;

namespace WindowsForms.Forms
{
    public partial class SettingsForm : Form
    {
        private MainForm mainFormRef;
        public SettingsForm(MainForm form)
        {
            InitializeComponent();
            mainFormRef = form;
        }

        private void SetupUI()
        {
            this.cbTeamType.Items.Add(TeamType.Men);
            this.cbTeamType.Items.Add(TeamType.Women);
            this.cbLanguage.Items.Add(Language.Croatian);
            this.cbLanguage.Items.Add(Language.English);
            this.lblCurrentSettings.Text = DataProvider.GetConfigInfo();

            this.cbTeamType.SelectedItem = DataProvider.GetTeamType();
            this.cbLanguage.SelectedItem = DataProvider.GetLanguage();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {            
            SetupUI();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.cbLanguage.Text) || String.IsNullOrEmpty(this.cbLanguage.Text))
            {
                FormUtils.DisplayErrorMessageBox(Properties.Resources.selectBothValues, "Error");                
                return;
            }
            if (MessageBox.Show(Properties.Resources.settingsChange, Properties.Resources.change, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider.UpdateConfig((TeamType)Enum.Parse(typeof(TeamType), this.cbTeamType.Text), (Language)Enum.Parse(typeof(Language), this.cbLanguage.Text));
                this.lblCurrentSettings.Text = DataProvider.GetConfigInfo();
                FormUtils.SetFormLanguage((Language)Enum.Parse(typeof(Language), this.cbLanguage.Text));
                UpdateUI();
            }                            
                
        }
        private void UpdateUI()
        {
            mainFormRef.UpdateUI();            
            this.Controls.Clear();
            InitializeComponent();
            SetupUI();
        }
    }
}

using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Forms;
using WindowsForms.Utils;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            FormUtils.SetFormLanguage();
            InitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOpenSetPicutres = new System.Windows.Forms.Button();
            this.btnOpenEventsRang = new System.Windows.Forms.Button();
            this.btnOpenPlayersRang = new System.Windows.Forms.Button();
            this.btnOpenPlayers = new System.Windows.Forms.Button();
            this.btnOpenTeams = new System.Windows.Forms.Button();
            this.btnOpenSettingsForm = new System.Windows.Forms.Button();

            this.pnlNavigation.BackColor = System.Drawing.Color.Lime;
            this.pnlNavigation.Controls.Add(this.btnOpenSetPicutres);
            this.pnlNavigation.Controls.Add(this.btnOpenEventsRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayersRang);
            this.pnlNavigation.Controls.Add(this.btnOpenPlayers);
            this.pnlNavigation.Controls.Add(this.btnOpenTeams);
            this.pnlNavigation.Controls.Add(this.btnOpenSettingsForm);
            this.pnlNavigation.Name = "pnlNavigation";

            resources.ApplyResources(this.btnOpenSetPicutres, "btnOpenSetPicutres");
            this.btnOpenSetPicutres.Name = "btnOpenSetPicutres";
            this.btnOpenSetPicutres.UseVisualStyleBackColor = true;
            this.btnOpenSetPicutres.Click += new System.EventHandler(this.btnOpenSetPicutres_Click);
            // 
            // btnOpenEventsRang
            // 
            resources.ApplyResources(this.btnOpenEventsRang, "btnOpenEventsRang");
            this.btnOpenEventsRang.Name = "btnOpenEventsRang";
            this.btnOpenEventsRang.UseVisualStyleBackColor = true;
            this.btnOpenEventsRang.Click += new System.EventHandler(this.btnOpenEventsRang_Click);
            // 
            // btnOpenPlayersRang
            // 
            resources.ApplyResources(this.btnOpenPlayersRang, "btnOpenPlayersRang");
            this.btnOpenPlayersRang.Name = "btnOpenPlayersRang";
            this.btnOpenPlayersRang.UseVisualStyleBackColor = true;
            this.btnOpenPlayersRang.Click += new System.EventHandler(this.btnOpenPlayersRang_Click);
            // 
            // btnOpenPlayers
            // 
            resources.ApplyResources(this.btnOpenPlayers, "btnOpenPlayers");
            this.btnOpenPlayers.Name = "btnOpenPlayers";
            this.btnOpenPlayers.UseVisualStyleBackColor = true;
            this.btnOpenPlayers.Click += new System.EventHandler(this.btnOpenPlayers_Click);
            // 
            // btnOpenTeams
            // 
            resources.ApplyResources(this.btnOpenTeams, "btnOpenTeams");
            this.btnOpenTeams.Name = "btnOpenTeams";
            this.btnOpenTeams.UseVisualStyleBackColor = true;
            this.btnOpenTeams.Click += new System.EventHandler(this.btnOpenTeams_Click);
            // 
            // btnOpenSettingsForm
            // 
            resources.ApplyResources(this.btnOpenSettingsForm, "btnOpenSettingsForm");
            this.btnOpenSettingsForm.Name = "btnOpenSettingsForm";
            this.btnOpenSettingsForm.UseVisualStyleBackColor = true;
            this.btnOpenSettingsForm.Click += new System.EventHandler(this.btnOpenSettingsForm_Click);
        }

        public void UpdateUI()
        {
            this.pnlNavigation.Controls.Clear();
            CustomInitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DataProvider.LoadConfiguration())
            {
                LoadForm(new SettingsForm(this));
                return;
            }
            LoadForm(new SelectTeamForm());            
        }

        public void LoadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.Width = this.pnlMain.Width;
            f.Height = this.pnlMain.Height;
            f.TopLevel = false;
            f.Anchor = AnchorStyles.None;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        private void btnOpenTeams_Click(object sender, EventArgs e) => LoadForm(new SelectTeamForm());

        private void btnOpenEventsRang_Click(object sender, EventArgs e) => LoadForm(new EventRangListForm());

        private void btnOpenPlayersRang_Click(object sender, EventArgs e) => LoadForm(new PlayersRangListForm());

        private void btnOpenPlayers_Click(object sender, EventArgs e) => LoadForm(new SelectPlayersForm());

        private void btnOpenSetPicutres_Click(object sender, EventArgs e) => LoadForm(new SetPlayerPictureForm());

        private void btnOpenSettingsForm_Click(object sender, EventArgs e) => LoadForm(new SettingsForm(this));

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
                DataProvider.SaveConfig();
                DataProvider.SaveFavoritePlayers();
                DataProvider.SaveAllPicutres();                
                return;
            }
            e.Cancel = true;
        }
    }
}

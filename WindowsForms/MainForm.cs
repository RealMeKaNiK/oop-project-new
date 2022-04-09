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

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataProvider.LoadConfiguration();
        }

        private void LoadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.Width = this.Width;
            f.Height = this.Height;
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

        private void btnOpenSettingsForm_Click(object sender, EventArgs e) => LoadForm(new SettingsForm());

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataProvider.SaveConfig();
                DataProvider.SaveFavoritePlayers();
                Application.ExitThread();
            }
            e.Cancel = true;
        }
    }
}

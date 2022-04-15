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
using WindowsForms.User_Controls;
using WindowsForms.Utils;

namespace WindowsForms.Forms
{
    public partial class SetPlayerPictureForm : Form
    {
        public SetPlayerPictureForm()
        {
            InitializeComponent();
        }

        private void SetPlayerPictureForm_Load(object sender, EventArgs e) => LoadPlayers();

        private async void LoadPlayers()
        {
            try
            {
                List<Player> players = await DataProvider.GetPlayers();
                FormUtils.CheckIfListCountZero<Player>(players);
                players.ForEach(p => this.flpPlayers.Controls.Add(new PlayerUserControl(p)));
            }
            catch (Exception err)
            {
                FormUtils.DisplayErrorMessageBox(err.Message, "Error");
                return;
            }
        }
    }
}

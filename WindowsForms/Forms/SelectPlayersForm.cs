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
    public partial class SelectPlayersForm : Form
    {
        private const byte MAX_FAV_PLAYERS = 3;
        public SelectPlayersForm()
        {
            InitializeComponent();
        }

        private bool IsThreeSelected(int selectedPlayersCount) => selectedPlayersCount == MAX_FAV_PLAYERS; 
        private void InsertControlInPanel(PlayerUserControl control)
        {
            if (!(control is PlayerUserControl))
                return;
            control.SetAsFavorite();
            this.flpFavoritePlayers.Controls.Add(control);
            AddPlayerToFavorites(control.GetUserControlPlayer());
        }

        private void SelectPlayersForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            LoadFavoritePlayers();
        }

        private void flpFavoritePlayers_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void flpFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (IsThreeSelected(this.flpFavoritePlayers.Controls.Count))
            {
                FormUtils.DisplayMessageBox("You can only have 3 selected players", "Max 3 Favorite players", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            InsertControlInPanel((PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl)));
        }

        private void btnRemoveFavorites_Click(object sender, EventArgs e)
        {
            this.flpFavoritePlayers.Controls.Clear();
            DataProvider.DeleteFavoritePlayers();
            LoadPlayers();
        }

        private void AddPlayerToFavorites(Player player) => DataProvider.InsertFavoritePlayer(player);

        private async void LoadPlayers()
        {
            this.flpLoadedPlayers.Controls.Clear();
            List<Player> players = await DataProvider.GetPlayers();
            players.ForEach(player => this.flpLoadedPlayers.Controls.Add(new PlayerUserControl(player)));
        }

        private void LoadFavoritePlayers()
        {
            this.flpFavoritePlayers.Controls.Clear();
            List<Player> players = DataProvider.GetFavoritePlayers();
            players.ForEach(player => this.flpFavoritePlayers.Controls.Add(new PlayerUserControl(player)));
        }
    }
}

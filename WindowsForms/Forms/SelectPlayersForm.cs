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
using System.Resources;

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
            if (!(control is PlayerUserControl)) { return; }                           
            control.Hide();
            control.isCheckedForTransfer = false;
            DataProvider.InsertFavoritePlayer(control.GetUserControlPlayer());
            this.flpFavoritePlayers.Controls.Add(new PlayerUserControl(control.GetUserControlPlayer()));
        }
        private void SelectPlayersForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.pbLoadingAnimation.Show();
                LoadFavoritePlayers();
                LoadPlayers();                
                this.pbLoadingAnimation.Hide();
            }
            catch (Exception err)
            {
                FormUtils.DisplayErrorMessageBox(err.Message, "Error");
                return;
            }
        }
        private void flpFavoritePlayers_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;
        private void flpFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (IsThreeSelected(this.flpFavoritePlayers.Controls.Count))
            {
                FormUtils.DisplayErrorMessageBox(Properties.Resources.maxPlayersError, Properties.Resources.maxPlayer);
                return;
            }
            if (IsMultiSelecet(this.flpLoadedPlayers.Controls))
            {
                List<PlayerUserControl> selectedPlayers = this.flpLoadedPlayers.Controls.Cast<PlayerUserControl>().ToList().FindAll(singleControl => singleControl.isCheckedForTransfer);
                if (selectedPlayers.Count > 3)
                {
                    FormUtils.DisplayErrorMessageBox(Properties.Resources.maxPlayer, Properties.Resources.maxPlayer);
                    return;
                }
                selectedPlayers.ForEach(singleControl => InsertControlInPanel(singleControl));
            }
            else
            {
                InsertControlInPanel((PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl)));
            }            
        }
        private bool IsMultiSelecet(Control.ControlCollection controls) => controls.Cast<PlayerUserControl>().ToList().FindAll(singleControl => singleControl.isCheckedForTransfer).Count() > 0;        
        private void btnRemoveFavorites_Click(object sender, EventArgs e)
        {
            this.flpFavoritePlayers.Controls.Clear();
            DataProvider.DeleteFavoritePlayers();
            LoadPlayers();
        }
        private async void LoadPlayers()
        {
            this.flpLoadedPlayers.Controls.Clear();
            try
            {
                List<Player> players = await DataProvider.GetPlayers();
                players.ForEach(player =>
                {
                    if (!DataProvider.GetFavoritePlayers().Exists(somePlayer => somePlayer.name == player.name))
                        this.flpLoadedPlayers.Controls.Add(new PlayerUserControl(player, this.flpFavoritePlayers) { isCheckedForTransfer = false });
                });
            }
            catch (Exception err) { FormUtils.DisplayErrorMessageBox(err.Message, "Error"); }
            
        }
        private void LoadFavoritePlayers()
        {
            this.flpFavoritePlayers.Controls.Clear();
            List<Player> players = DataProvider.GetFavoritePlayers();
            players.ForEach(player => this.flpFavoritePlayers.Controls.Add(new PlayerUserControl(player, this.flpFavoritePlayers)));
        }    
    }
}

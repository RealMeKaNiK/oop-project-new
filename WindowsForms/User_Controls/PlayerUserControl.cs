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

namespace WindowsForms.User_Controls
{
    public partial class PlayerUserControl : UserControl
    {
        private const string PICTURE_FILTER = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        private Player Player;

        public bool isCheckedForTransfer = false;
        public PlayerUserControl(Player player )
        {
            InitializeComponent();
            this.Player = player;
            this.ContextMenuStrip = cmsAddPlayerToFav;
        }

        private FlowLayoutPanel favoritePanelRef;
        public PlayerUserControl(Player player, FlowLayoutPanel flpFavoritePlayers)
        {
            InitializeComponent();
            this.Player = player;
            this.favoritePanelRef = flpFavoritePlayers;
            this.ContextMenuStrip = cmsAddPlayerToFav;
        }

        public Player GetUserControlPlayer() => Player;

        public void SetAsFavorite()
        {
            Player.FavoritePlayer = true;
            this.lblFavorite.Text = "ZVEZDAN";
        }

        private void PlayerUserControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Player.name;
            this.lblShirtNumber.Text = Player.shirt_number.ToString();
            this.lblPosition.Text = Player.position;
            this.lblCaptain.Text = Player.captain ? "CAPTAIN" : "";
            this.lblFavorite.Text = Player.FavoritePlayer ? "★" : "";
            this.pictureBox1.Image = Player.Picture;
        }

        private void PlayerUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DoDragDrop(this, DragDropEffects.All);
        }
        
        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataProvider.InsertFavoritePlayer(Player))
            {
                FormUtils.DisplayErrorMessageBox("Already in favorites!", "Already chosen");
                return;
            }
            this.favoritePanelRef.Controls.Add(this);
            SetAsFavorite();
        }

        private void cbTransfer_CheckedChanged(object sender, EventArgs e) => isCheckedForTransfer = cbTransfer.Checked;

    }
}

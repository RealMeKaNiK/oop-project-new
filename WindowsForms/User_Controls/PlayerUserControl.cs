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

namespace WindowsForms.User_Controls
{
    public partial class PlayerUserControl : UserControl
    {
        private readonly Player Player;
        public PlayerUserControl(Player player)
        {
            InitializeComponent();
            this.Player = player;
        }

        private void PlayerUserControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Player.name;
            this.lblShirtNumber.Text = Player.shirt_number.ToString();
            this.lblPosition.Text = Player.position;
            this.lblCaptain.Text = Player.captain ? "KAPETAN" : "";
            this.lblFavorite.Text = Player.FavoritePlayer ? "ZVEZDA" : "";
        }

        private void PlayerUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DoDragDrop(this, DragDropEffects.All);
        }
    }
}

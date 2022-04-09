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
        private const string PICTURE_FILTER = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        private Player Player;
        public PlayerUserControl(Player player)
        {
            InitializeComponent();
            this.Player = player;
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
            this.lblCaptain.Text = Player.captain ? "KAPETAN" : "";
            this.lblFavorite.Text = Player.FavoritePlayer ? "ZVEZDA" : "";
        }

        private void PlayerUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DoDragDrop(this, DragDropEffects.All);
        }

        private void PlayerUserControl_DoubleClick(object sender, EventArgs e) => this.pictureBox1.Image = LoadPicture();

        private Image LoadPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = PICTURE_FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return Image.FromFile(openFileDialog.FileName);
            return null;
        }
        
    }
}

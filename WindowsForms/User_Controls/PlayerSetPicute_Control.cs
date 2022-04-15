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

namespace WindowsForms.User_Controls
{
    public partial class PlayerSetPicute_Control : UserControl
    {
        private const string PICTURE_FILTER = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

        private Player Player;
        public PlayerSetPicute_Control(Player player)
        {
            InitializeComponent();
            Player = player;
        }

        private Image SetPlayerPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = PICTURE_FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataProvider.SetPictureForPlayer(Player, new Bitmap(openFileDialog.FileName));
                return Image.FromFile(openFileDialog.FileName);
            }
            return null;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e) => this.pictureBox1.Image = SetPlayerPicture();

        private void PlayerSetPicute_Control_Load(object sender, EventArgs e)
        {
            this.lblPlayerName.Text = Player.name;
            this.lblPlayerNumber.Text = Player.shirt_number.ToString();
            this.pictureBox1.Image = Player.Picture;
        }
    }
}

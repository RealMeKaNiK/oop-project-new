﻿using DataAccessLayer;
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
            List<Player> players = await DataProvider.GetPlayers();
            players.ForEach(p => this.flpPlayers.Controls.Add(new PlayerUserControl(p)));
        }
    }
}

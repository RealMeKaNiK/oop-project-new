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
using WindowsForms.Utils;

namespace WindowsForms.Forms
{
    public partial class SelectTeamForm : Form
    {
        public SelectTeamForm()
        {
            InitializeComponent();
        }

        private async void SelectTeamForm_Load(object sender, EventArgs e)
        {
            if (DataProvider.GetFavoriteTeam() != null)
            {
                this.lblCurrentTeam.Text = DataProvider.GetFavoriteTeam().ToString();
            }
            this.cbAllTeams.DataSource = await DataProvider.GetTeams();
            FormUtils.CheckIfListCountZero<Team>((List<Team>)this.cbAllTeams.DataSource);
        }

        private void btnSaveFavoriteTeam_Click(object sender, EventArgs e)
        {
            DataProvider.SaveFavoriteTeam(this.cbAllTeams.SelectedValue as Team);
            FormUtils.DisplayMessageBox($"Uspjesno ste odabrali favorit team: {this.cbAllTeams.SelectedValue}", "Promjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

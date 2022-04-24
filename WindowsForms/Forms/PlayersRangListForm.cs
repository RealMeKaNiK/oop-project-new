using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Utils;

namespace WindowsForms.Forms
{
    public partial class PlayersRangListForm : Form
    {
        public PlayersRangListForm()
        {
            InitializeComponent();
        }

        private Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {            
            bmp = new Bitmap(dgvPlayerStats.Width, dgvPlayerStats.Height);
            dgvPlayerStats.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPlayerStats.Width, dgvPlayerStats.Height));
            printPreviewDialog1.ShowDialog();
        } 

        private async void PlayersRangListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.pbLoadingAnimation.Show();
                this.dgvPlayerStats.DataSource = await DataProvider.GetPlayers();
                this.pbLoadingAnimation.Hide();
            }
            catch (Exception err)
            {
                FormUtils.DisplayErrorMessageBox(err.Message, "Error");
                return;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

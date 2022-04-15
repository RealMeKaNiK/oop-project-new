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

namespace WindowsForms.Forms
{
    public partial class EventRangListForm : Form
    {
        public EventRangListForm()
        {
            InitializeComponent();             
        }

        private void btnPrint_Click(object sender, EventArgs e) => FormUtils.PrintDataGridView(this.dgvEventStats, "Event stats");

        private async void EventRangListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvEventStats.DataSource = await DataProvider.GetMatchEvents();
                FormUtils.CheckIfListCountZero<Match>((List<Match>)this.dgvEventStats.DataSource);
            }
            catch (Exception err)
            {
                FormUtils.DisplayErrorMessageBox(err.Message, "Error");
                return;
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportProje
{
    public partial class RaporCekici : Form
    {
        public RaporCekici()
        {
            InitializeComponent();
        }

        private void RaporCekici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Trucks' table. You can move, or remove it, as needed.
            this.TrucksTableAdapter.Fill(this.DataDataSet.Trucks);

            this.reportViewer1.RefreshReport();
        }
    }
}

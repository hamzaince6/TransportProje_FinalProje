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
    public partial class RaporYakitTakip : Form
    {
        public RaporYakitTakip()
        {
            InitializeComponent();
        }

        private void RaporYakitTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.YakitTakip' table. You can move, or remove it, as needed.
            this.YakitTakipTableAdapter.Fill(this.DataDataSet.YakitTakip);

            this.reportViewer1.RefreshReport();
        }
    }
}

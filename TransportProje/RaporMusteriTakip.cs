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
    public partial class RaporMusteriTakip : Form
    {
        public RaporMusteriTakip()
        {
            InitializeComponent();
        }

        private void RaporMusteriTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.MusteriTakip' table. You can move, or remove it, as needed.
            this.MusteriTakipTableAdapter.Fill(this.DataDataSet.MusteriTakip);

            this.reportViewer1.RefreshReport();
        }
    }
}

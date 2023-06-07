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
    public partial class DetaylıRaporYakitTakip : Form
    {
        public DetaylıRaporYakitTakip()
        {
            InitializeComponent();
        }

        private void DetaylıRaporYakitTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.YakitTakip' table. You can move, or remove it, as needed.
            this.YakitTakipTableAdapter.Fill(this.DataDataSet.YakitTakip);
            // TODO: This line of code loads data into the 'DataDataSet.Giris' table. You can move, or remove it, as needed.
            this.GirisTableAdapter.Fill(this.DataDataSet.Giris);

            this.reportViewer1.RefreshReport();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            YakitTakipBindingSource.Filter = "YakitTipi='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}

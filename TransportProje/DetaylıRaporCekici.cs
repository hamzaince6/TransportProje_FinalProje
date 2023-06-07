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
    public partial class DetaylıRaporCekici : Form
    {
        public DetaylıRaporCekici()
        {
            InitializeComponent();
        }

        private void DetaylıRaporCekici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Trucks' table. You can move, or remove it, as needed.
            this.TrucksTableAdapter.Fill(this.DataDataSet.Trucks);

            this.reportViewer1.RefreshReport();
        }

        private void txtsoyadara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            TrucksBindingSource.Filter = "Plaka='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            TrucksBindingSource.Filter = "Plaka='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}

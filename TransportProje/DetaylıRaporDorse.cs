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
    public partial class DetaylıRaporDorse : Form
    {
        public DetaylıRaporDorse()
        {
            InitializeComponent();
        }

        private void DetaylıRaporDorse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Trailer' table. You can move, or remove it, as needed.
            this.TrailerTableAdapter.Fill(this.DataDataSet.Trailer);

            this.reportViewer1.RefreshReport();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            TrailerBindingSource.Filter = "KullimAlani='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class DetaylıRaporPersonel : Form
    {
        public DetaylıRaporPersonel()
        {
            InitializeComponent();
        }

        private void DetaylıRaporPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.DataDataSet.Personel);

            this.reportViewer1.RefreshReport();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            PersonelBindingSource.Filter = "Soyadı='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsoyadara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

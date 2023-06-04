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
    public partial class RaporMusteriKarti : Form
    {
        public RaporMusteriKarti()
        {
            InitializeComponent();
        }

        private void RaporMusteriKarti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.MusteriKarti' table. You can move, or remove it, as needed.
            this.MusteriKartiTableAdapter.Fill(this.DataDataSet.MusteriKarti);

            this.reportViewer1.RefreshReport();
        }
    }
}

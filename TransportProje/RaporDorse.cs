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
    public partial class RaporDorse : Form
    {
        public RaporDorse()
        {
            InitializeComponent();
        }

        private void RaporDorse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Trailer' table. You can move, or remove it, as needed.
            this.TrailerTableAdapter.Fill(this.DataDataSet.Trailer);

            this.reportViewer1.RefreshReport();
        }
    }
}

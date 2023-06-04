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
    public partial class RaporUye : Form
    {
        public RaporUye()
        {
            InitializeComponent();
        }

        private void RaporUye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Giris' table. You can move, or remove it, as needed.
            this.GirisTableAdapter.Fill(this.DataDataSet.Giris);

            this.reportViewer1.RefreshReport();
           
        }
    }
}

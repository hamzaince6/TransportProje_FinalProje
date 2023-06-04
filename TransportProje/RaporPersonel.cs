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
    public partial class RaporPersonel : Form
    {
        public RaporPersonel()
        {
            InitializeComponent();
        }

        private void RaporPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.DataDataSet.Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}

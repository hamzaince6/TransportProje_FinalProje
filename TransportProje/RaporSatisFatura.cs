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
    public partial class RaporSatisFatura : Form
    {
        public RaporSatisFatura()
        {
            InitializeComponent();
        }

        private void RaporSatisFatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.SatisFatura' table. You can move, or remove it, as needed.
            this.SatisFaturaTableAdapter.Fill(this.DataDataSet.SatisFatura);

            this.reportViewer1.RefreshReport();
        }
    }
}

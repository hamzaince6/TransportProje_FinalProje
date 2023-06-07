﻿using System;
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
    public partial class DetaylıRaporSofor : Form
    {
        public DetaylıRaporSofor()
        {
            InitializeComponent();
        }

        private void DetaylıRaporSofor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDataSet.Sofor' table. You can move, or remove it, as needed.
            this.SoforTableAdapter.Fill(this.DataDataSet.Sofor);

            this.reportViewer1.RefreshReport();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            SoforBindingSource.Filter = "TcKimlikNo='" + txtsoyadara.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}

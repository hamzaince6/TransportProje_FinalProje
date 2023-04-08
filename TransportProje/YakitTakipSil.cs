using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace TransportProje
{
    public partial class YakitTakipSil : Form
    {
        public YakitTakipSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Delete from YakitTakip where Kimlik=" + txtkimlik.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtkimlik.Text + "Kayıt Silindi", "UYARI");
                Tanimlamalar.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Sil Hata Penceresi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtkimlik.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkimlik.Text = "";
            txtplaka.Text = "";
            txtdepohacmi.Text = "";
            txtyakittipi.Text = "";
            txtkimlik.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Close();
        }
    }
}

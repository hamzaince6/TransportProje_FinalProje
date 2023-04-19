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
    public partial class YakitTakipGuncelle : Form
    {
        public YakitTakipGuncelle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayıtDegistir();
        }

        public void KayıtDegistir()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Update YakitTakip Set Plaka=@Plaka,DepoHacmi=@DepoHacmi,YakitTipi=@YakitTipi,GunlukHak=@GunlukHak,OrtalamaYakit=@OrtalamaYakit where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                DegistirKomut.Parameters.AddWithValue("@DepoHacmi", cmbdepohacmi.Text);
                DegistirKomut.Parameters.AddWithValue("@YakitTipi", cmbyakit.Text);
                DegistirKomut.Parameters.AddWithValue("@GunlukHak", cmbgunlukhak.Text);
                DegistirKomut.Parameters.AddWithValue("@OrtalamaYakit", txtortalama.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtplaka.Text + "" + cmbdepohacmi.Text + "isimli kayıt Değiştirildi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir Hata Penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtid.BackColor = Color.White;
            txtplaka.BackColor = Color.White;
            cmbdepohacmi.BackColor = Color.White;
            cmbyakit.BackColor = Color.White;
            cmbgunlukhak.BackColor = Color.White;
            txtortalama.BackColor = Color.White;

            if (txtplaka.Text == "")
            {
                txtplaka.BackColor = Color.DarkRed;
                txtplaka.Focus();
                bos = true;

            }

            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
                bos = true;

            }

            if (txtortalama.Text == "")
            {
                txtortalama.BackColor = Color.DarkRed;
                txtortalama.Focus();
                bos = true;

            }

            if (cmbdepohacmi.Text == "Depo Hacmi Seçiniz" || cmbdepohacmi.Text == "")
            {
                cmbdepohacmi.BackColor = Color.DarkRed;
                cmbdepohacmi.Focus();
                bos = true;

            }



            if (cmbyakit.Text == "Yakıt Tipi Seçiniz" || cmbyakit.Text == "")
            {
                cmbyakit.BackColor = Color.DarkRed;
                cmbyakit.Focus();
                bos = true;

            }

            if (cmbgunlukhak.Text == "Günlük Hak Seçiniz" || cmbgunlukhak.Text == "")
            {
                cmbgunlukhak.BackColor = Color.DarkRed;
                cmbgunlukhak.Focus();
                bos = true;

            }


            return bos;

        }








    }
}

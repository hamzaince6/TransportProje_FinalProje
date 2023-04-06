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
    public partial class YakitTakipEkle : Form
    {
        public YakitTakipEkle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtplaka.Text = "";
            cmbdepohacmi.Text = "";
            cmbyakit.Text = "";
            cmbgunlukhak.Text = "";
            txtortalama.Text = "";
            txtplaka.Focus();
        }

        public void KayitEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into YakitTakip (Plaka,DepoHacmi,YakitTipi,GunlukHak,OrtalamaYakit) Values (@Plaka,@DepoHacmi,@YakitTipi,@GunlukHak,@OrtalamaYakit)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                EkleKomut.Parameters.AddWithValue("@DepoHacmi", cmbdepohacmi.Text);
                EkleKomut.Parameters.AddWithValue("@YakitTipi", cmbyakit.Text);
                EkleKomut.Parameters.AddWithValue("@GunlukHak", cmbgunlukhak.Text);
                EkleKomut.Parameters.AddWithValue("@OrtalamaYakit", txtortalama.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Personel Kayıt Ekleme Hata Penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }
    }
}

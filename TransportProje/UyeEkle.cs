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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
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
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        public void KayitEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into Giris (Kullaniciadi,Sifre,Mail) Values (@Kullaniciadi,@Sifre,@Mail)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Kullaniciadi", txtkullanici.Text);
                EkleKomut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                EkleKomut.Parameters.AddWithValue("@Mail", txtmail.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Personel Kayıt Ekleme Hata Penceresi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkullanici.Text = "";
            txtsifre.Text = "";
            txtmail.Text = "";
            txtkullanici.Focus();
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtkullanici.BackColor = Color.White;
            txtsifre.BackColor = Color.White;
            txtmail.BackColor = Color.White;
           
            if (txtkullanici.Text == "")
            {
                txtkullanici.BackColor = Color.DarkRed;
                txtkullanici.Focus();
                bos = true;

            }

            if (txtsifre.Text == "")
            {
                txtsifre.BackColor = Color.DarkRed;
                txtsifre.Focus();
                bos = true;

            }

            if (txtmail.Text == "")
            {
                txtmail.BackColor = Color.DarkRed;
                txtmail.Focus();
                bos = true;

            }


            return bos;

        }


    }
}

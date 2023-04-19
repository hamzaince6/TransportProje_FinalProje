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
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
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
                string Sorgu = "Update Giris Set Kullaniciadi=@Kullaniciadi,Sifre=@Sifre,Mail=@Mail where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Kullaniciadi", txtkullanici.Text);
                DegistirKomut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                DegistirKomut.Parameters.AddWithValue("@Mail", txtmail.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtkullanici.Text + "" + txtsifre.Text + "isimli kayıt Değiştirildi");
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
            txtkullanici.BackColor = Color.White;
            txtsifre.BackColor = Color.White;
            txtmail.BackColor = Color.White;


            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
                bos = true;

            }


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

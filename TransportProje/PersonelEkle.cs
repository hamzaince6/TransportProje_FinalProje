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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
                string Sorgu = "Insert Into Personel (Adı,Soyadı,TcNo,Cinsiyet,Adres,Telefon,OgrenimDurumu,Birimi,ibanBilgisi,Maas,Prim,Avans,CalismaYili,IseBaslamaTarihi,AyrilmaTarihi,AyrilmaNedeni) Values (@Adı,@Soyadı,@TcNo,@Cinsiyet,@Adres,@Telefon,@OgrenimDurumu,@Birimi,@ibanBilgisi,@Maas,@Prim,@Avans,@CalismaYili,@IseBaslamaTarihi,@AyrilmaTarihi,@AyrilmaNedeni)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Adı", txtad.Text);
                EkleKomut.Parameters.AddWithValue("@Soyadı", txtsoyad.Text);
                EkleKomut.Parameters.AddWithValue("@TcNo", txttc.Text);
                if (raderkek.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radkadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadin");
                EkleKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                EkleKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbogrenimdurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Birimi", cmbbirim.Text);
                EkleKomut.Parameters.AddWithValue("@ibanBilgisi", txtiban.Text);
                EkleKomut.Parameters.AddWithValue("@Maas", txtmaas.Text);
                EkleKomut.Parameters.AddWithValue("@Prim", txtprim.Text);
                EkleKomut.Parameters.AddWithValue("@Avans", txtavans.Text);
                EkleKomut.Parameters.AddWithValue("@CalismaYili", txtcalisma.Text);
                EkleKomut.Parameters.AddWithValue("@IseBaslamaTarihi", txtbaslama.Text);
                EkleKomut.Parameters.AddWithValue("@AyrilmaTarihi", txtayrilmatarihi.Text);
                EkleKomut.Parameters.AddWithValue("@AyrilmaNedeni", txtayrilma.Text);
                

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
            txtad.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";
            cmbogrenimdurumu.Text = "";
            cmbbirim.Text = "";
            txtiban.Text = "";
            txtmaas.Text = "";
            txtprim.Text = "";
            txtavans.Text = "";
            txtcalisma.Text = "";
            txtbaslama.Text = "";
            txtad.Focus();
        }


        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtad.BackColor = Color.White;
            txtsoyad.BackColor = Color.White;
            txttc.BackColor = Color.White;
            txtadres.BackColor = Color.White;
            txttelefon.BackColor = Color.White;
            cmbogrenimdurumu.BackColor = Color.White;
            cmbbirim.BackColor = Color.White;
            txtiban.BackColor = Color.White;
            txtmaas.BackColor = Color.White;
            txtprim.BackColor = Color.White;
            txtavans.BackColor = Color.White;
            txtcalisma.BackColor = Color.White;
            txtbaslama.BackColor = Color.White;


            if (cmbogrenimdurumu.Text == "Öğrenim Durumu Seçiniz" || cmbogrenimdurumu.Text == "")
            {
                cmbogrenimdurumu.BackColor = Color.DarkRed;
                cmbogrenimdurumu.Focus();
                bos = true;

            }

            if (cmbbirim.Text == "Birim Seçiniz" || cmbbirim.Text == "")
            {
                cmbbirim.BackColor = Color.DarkRed;
                cmbbirim.Focus();
                bos = true;

            }

            if (txtad.Text == "")
            {
                txtad.BackColor = Color.DarkRed;
                txtad.Focus();
                bos = true;

            }

            if (txtsoyad.Text == "")
            {
                txtsoyad.BackColor = Color.DarkRed;
                txtsoyad.Focus();
                bos = true;

            }

            if (txttc.Text == "")
            {
                txttc.BackColor = Color.DarkRed;
                txttc.Focus();
                bos = true;

            }

            if (txtadres.Text == "")
            {
                txtadres.BackColor = Color.DarkRed;
                txtadres.Focus();
                bos = true;

            }

            if (txttelefon.Text == "")
            {
                txttelefon.BackColor = Color.DarkRed;
                txttelefon.Focus();
                bos = true;

            }

            if (txtiban.Text == "")
            {
                txtiban.BackColor = Color.DarkRed;
                txtiban.Focus();
                bos = true;

            }

            if (txtmaas.Text == "")
            {
                txtmaas.BackColor = Color.DarkRed;
                txtmaas.Focus();
                bos = true;

            }


            if (txtprim.Text == "")
            {
                txtprim.BackColor = Color.DarkRed;
                txtprim.Focus();
                bos = true;

            }

            if (txtavans.Text == "")
            {
                txtavans.BackColor = Color.DarkRed;
                txtavans.Focus();
                bos = true;

            }

            if (txtcalisma.Text == "")
            {
                txtcalisma.BackColor = Color.DarkRed;
                txtcalisma.Focus();
                bos = true;

            }

            if (txtbaslama.Text == "")
            {
                txtbaslama.BackColor = Color.DarkRed;
                txtbaslama.Focus();
                bos = true;

            }
            return bos;

        }


    }
}

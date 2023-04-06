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
    public partial class SoforEkle : Form
    {
        public SoforEkle()
        {
            InitializeComponent();
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
                string Sorgu = "Insert Into Sofor (Adı,Soyadı,TcKimlikNo,Plaka,ıseBaslamaTarihi,AyrilmaTarihi,AyrilmaNedeni,Adres,Telefon,OgrenimDurumu,EhliyetSinifi,EhliyetNo,SrcNo,PiskoTestNo,TakografNo) Values (@Adı,@Soyadı,@TcKimlikNo,@Plaka,@IseBaslamaTarihi,@AyrilmaTarihi,@AyrilmaNedeni,@Adres,@Telefon,@OgrenimDurumu,@EhliyetSinifi,@EhliyetNo,@SrcNo,@PiskoTestNo,@TakografNo)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Adı", txtad.Text);
                EkleKomut.Parameters.AddWithValue("@Soyadı", txtsoyad.Text);
                EkleKomut.Parameters.AddWithValue("@TcKimlikNo", txttckimlik.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                EkleKomut.Parameters.AddWithValue("@ıseBaslamaTarihi", txtbaslama.Text);
                EkleKomut.Parameters.AddWithValue("@AyrilmaTarihi", txtayrilma.Text);
                EkleKomut.Parameters.AddWithValue("@AyrilmaNedeni", txtayrilmanedeni.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                EkleKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbogrenimdurumu.Text);
                EkleKomut.Parameters.AddWithValue("@EhliyetSinifi", cmbehliyetsinif.Text);
                EkleKomut.Parameters.AddWithValue("@EhliyetNo", txtehiletno.Text);
                EkleKomut.Parameters.AddWithValue("@SrcNo", txtsrcno.Text);
                EkleKomut.Parameters.AddWithValue("@PiskoTestNo", txtpiskono.Text);
                EkleKomut.Parameters.AddWithValue("@TakografNo", txttakografno.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttckimlik.Text = "";
            txtplaka.Text = "";
            txtbaslama.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";
            cmbogrenimdurumu.Text = "";
            cmbehliyetsinif.Text = "";
            txtehiletno.Text = "";
            txtsrcno.Text = "";
            txtpiskono.Text = "";
            txttakografno.Text = "";
            
        }


        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtad.BackColor = Color.White;
            txtsoyad.BackColor = Color.White;
            txttckimlik.BackColor = Color.White;
            txtplaka.BackColor = Color.White;
            txtbaslama.BackColor = Color.White;
            txtayrilma.BackColor = Color.White;
            txtayrilmanedeni.BackColor = Color.White;
            txtadres.BackColor = Color.White;
            txttelefon.BackColor = Color.White;
            cmbogrenimdurumu.BackColor = Color.White;
            cmbehliyetsinif.BackColor = Color.White;
            txtehiletno.BackColor = Color.White;
            txtsrcno.BackColor = Color.White;
            txtsrcno.BackColor = Color.White;
            txtpiskono.BackColor = Color.White;
            txttakografno.BackColor = Color.White;



            if (cmbogrenimdurumu.Text == "Öğrenim Durumu Seçiniz" || cmbogrenimdurumu.Text == "")
            {
                cmbogrenimdurumu.BackColor = Color.DarkRed;
                cmbogrenimdurumu.Focus();
                bos = true;

            }

            if (cmbehliyetsinif.Text == "Ehliyet Sınıfı Seçiniz" || cmbehliyetsinif.Text == "")
            {
                cmbehliyetsinif.BackColor = Color.DarkRed;
                cmbehliyetsinif.Focus();
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

            if (txttckimlik.Text == "")
            {
                txttckimlik.BackColor = Color.DarkRed;
                txttckimlik.Focus();
                bos = true;

            }

            if (txtplaka.Text == "")
            {
                txtplaka.BackColor = Color.DarkRed;
                txtplaka.Focus();
                bos = true;

            }

            if (txtbaslama.Text == "")
            {
                txtbaslama.BackColor = Color.DarkRed;
                txtbaslama.Focus();
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

            if (txtehiletno.Text == "")
            {
                txtehiletno.BackColor = Color.DarkRed;
                txtehiletno.Focus();
                bos = true;

            }

            if (txtsrcno.Text == "")
            {
                txtsrcno.BackColor = Color.DarkRed;
                txtsrcno.Focus();
                bos = true;

            }

            if (txtpiskono.Text == "")
            {
                txtpiskono.BackColor = Color.DarkRed;
                txtpiskono.Focus();
                bos = true;

            }

            if (txttakografno.Text == "")
            {
                txttakografno.BackColor = Color.DarkRed;
                txttakografno.Focus();
                bos = true;

            }

            return bos;

        }
    }
}

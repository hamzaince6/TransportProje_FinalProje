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
    public partial class SoforGuncelle : Form
    {
        public SoforGuncelle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

      

        public void KayıtDegistir()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Update Sofor Set Adı=@Adı,Soyadı=@Soyadı,TcKimlikNo=@TcKimlikNo,Plaka=@Plaka,IseBaslamaTarihi=@IseBaslamaTarihi,AyrilmaTarihi=@AyrilmaTarihi,AyrilmaNedeni=@AyrilmaNedeni,Adres=@Adres,Telefon=@Telefon,OgrenimDurumu=@OgrenimDurumu,EhliyetSinifi=@EhliyetSinifi,EhliyetNo=@EhliyetNo,SrcNo=@SrcNo,PiskoTestNo=@PiskoTestNo,TakografNo=@TakografNo where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Adı", txtad.Text);
                DegistirKomut.Parameters.AddWithValue("@Soyadı", txtsoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@TcKimlikNo", txttckimlik.Text);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                DegistirKomut.Parameters.AddWithValue("@IseBaslamaTarihi", txtbaslama.Text);
                DegistirKomut.Parameters.AddWithValue("@AyrilmaTarihi", txtayrilma.Text);
                DegistirKomut.Parameters.AddWithValue("@AyrilmaNedeni", txtayrilmanedeni.Text);
                DegistirKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                DegistirKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                DegistirKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbogrenimdurumu.Text);
                DegistirKomut.Parameters.AddWithValue("@EhliyetSinifi", cmbehliyetsinif.Text);
                DegistirKomut.Parameters.AddWithValue("@EhliyetNo", txtehiletno.Text);
                DegistirKomut.Parameters.AddWithValue("@SrcNo", txtsrcno.Text);
                DegistirKomut.Parameters.AddWithValue("@PiskoTestNo", txtpiskono.Text);
                DegistirKomut.Parameters.AddWithValue("@TakografNo", txttakografno.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtad.Text + "" + txtsoyad.Text + "isimli kayıt Değiştirildi");
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

            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayıtDegistir();
        }
    }
}

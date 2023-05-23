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
    public partial class MusteriTakipGuncelle : Form
    {
        public MusteriTakipGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmusterikimlik.Text = "";
            txtkayitno.Text = "";
            txtgorusulenkisi.Text = "";
            txtgorusenkisi.Text = "";
            txtuyaritarihi.Text = "";
            cmbdurumu.Text = "";
            txtkonu.Text = "";
            txtgorusmeicerik.Text = "";
            cmbsikayetbeklenti.Text = "";
            cmbsonuc.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Geri Dön Butonu
            MusteriKarti frmgerilistele22 = new MusteriKarti();
            frmgerilistele22.Show();
            this.Close();
        }

        public void KayıtDegistir()
        {
            try
            {
                SatisFaturaGuncelle.BaglantiAc();
                string Sorgu = "Update MusteriTakip Set MusteriKimlik=@MusteriKimlik,KayıtNo=@KayıtNo,GorusulenKisi=@GorusulenKisi,GorusenKisi=@GorusenKisi,UyariTarihi=@UyariTarihi,Durumu=@Durumu,Konu=@Konu,GorusmeIcerigi=@GorusmeIcerigi,MusteriSikayetBeklenti=@MusteriSikayetBeklenti,Sonuc=@Sonuc where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, SatisFaturaGuncelle.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@MusteriKimlik", txtmusterikimlik.Text);
                DegistirKomut.Parameters.AddWithValue("@KayıtNo", txtkayitno.Text);
                DegistirKomut.Parameters.AddWithValue("@GorusulenKisi", txtgorusulenkisi.Text);
                DegistirKomut.Parameters.AddWithValue("@GorusenKisi", txtgorusenkisi.Text);
                DegistirKomut.Parameters.AddWithValue("@UyariTarihi", txtuyaritarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@Durumu", cmbdurumu.Text);
                DegistirKomut.Parameters.AddWithValue("@Konu", txtkonu.Text);
                DegistirKomut.Parameters.AddWithValue("@GorusmeIcerigi", txtgorusmeicerik.Text);
                DegistirKomut.Parameters.AddWithValue("@MusteriSikayetBeklenti", cmbsikayetbeklenti.Text);
                DegistirKomut.Parameters.AddWithValue("@Sonuc", cmbsonuc.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtkayitno.Text + "" + txtgorusenkisi.Text + "isimli kayıt Değiştirildi");
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
            txtmusterikimlik.BackColor = Color.White;
            txtkayitno.BackColor = Color.White;
            txtgorusulenkisi.BackColor = Color.White;
            txtgorusenkisi.BackColor = Color.White;
            txtuyaritarihi.BackColor = Color.White;
            cmbdurumu.BackColor = Color.White;
            txtkonu.BackColor = Color.White;
            txtgorusmeicerik.BackColor = Color.White;
            cmbsikayetbeklenti.BackColor = Color.White;
            cmbsonuc.BackColor = Color.White;



            if (cmbdurumu.Text == "Durumu Seçiniz" || cmbdurumu.Text == "")
            {
                cmbdurumu.BackColor = Color.DarkRed;
                cmbdurumu.Focus();
                bos = true;

            }

            if (cmbsikayetbeklenti.Text == " Destek Seçiniz" || cmbsikayetbeklenti.Text == "")
            {
                cmbsikayetbeklenti.BackColor = Color.DarkRed;
                cmbsikayetbeklenti.Focus();
                bos = true;

            }

            if (cmbsonuc.Text == "Sonuç Seçiniz" || cmbsonuc.Text == "")
            {
                cmbsonuc.BackColor = Color.DarkRed;
                cmbsonuc.Focus();
                bos = true;

            }



            if (txtmusterikimlik.Text == "")
            {
                txtmusterikimlik.BackColor = Color.DarkRed;
                txtmusterikimlik.Focus();
                bos = true;

            }

            if (txtkayitno.Text == "")
            {
                txtkayitno.BackColor = Color.DarkRed;
                txtkayitno.Focus();
                bos = true;

            }

            if (txtgorusulenkisi.Text == "")
            {
                txtgorusulenkisi.BackColor = Color.DarkRed;
                txtgorusulenkisi.Focus();
                bos = true;

            }

            if (txtgorusenkisi.Text == "")
            {
                txtgorusenkisi.BackColor = Color.DarkRed;
                txtgorusenkisi.Focus();
                bos = true;

            }

            if (txtuyaritarihi.Text == "")
            {
                txtuyaritarihi.BackColor = Color.DarkRed;
                txtuyaritarihi.Focus();
                bos = true;

            }

            if (txtkonu.Text == "")
            {
                txtkonu.BackColor = Color.DarkRed;
                txtkonu.Focus();
                bos = true;

            }

            if (txtgorusmeicerik.Text == "")
            {
                txtgorusmeicerik.BackColor = Color.DarkRed;
                txtgorusmeicerik.Focus();
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

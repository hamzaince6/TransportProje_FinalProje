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
    public partial class MusteriKartiGuncelle : Form
    {
        public MusteriKartiGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfirmano.Text = "";
            txtfirmaadi.Text = "";
            txtmusteritemsilcisi.Text = "";
            txtvergino.Text = "";
            cmbvergidairesi.Text = "";
            txthesapno.Text = "";
            cmbdovizbirimi.Text = "";
            txtadres.Text = "";
            txtpostakodu.Text = "";
            txttelefon.Text = "";
            txtfaks.Text = "";
            txtmail.Text = "";
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
                string Sorgu = "Update MusteriKarti Set FirmaNo=@FirmaNo,FirmaAdi=@FirmaAdi,MusteriTemsilcisi=@MusteriTemsilcisi,VergiNo=@VergiNo,VergiDairesi=@VergiDairesi,HesapNo=@HesapNo,DovizBirimi=@DovizBirimi,Adres=@Adres,PostaKodu=@PostaKodu,Telefon=@Telefon,Faks=@Faks,Mail=@Mail where MusteriKimlik=@MusteriKimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, SatisFaturaGuncelle.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@FirmaNo", txtfirmano.Text);
                DegistirKomut.Parameters.AddWithValue("@FirmaAdi", txtfirmaadi.Text);
                DegistirKomut.Parameters.AddWithValue("@MusteriTemsilcisi", txtmusteritemsilcisi.Text);
                DegistirKomut.Parameters.AddWithValue("@VergiNo", txtvergino.Text);
                DegistirKomut.Parameters.AddWithValue("@VergiDairesi", cmbvergidairesi.Text);
                DegistirKomut.Parameters.AddWithValue("@HesapNo", txthesapno.Text);
                DegistirKomut.Parameters.AddWithValue("@DovizBirimi", cmbdovizbirimi.Text);
                DegistirKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                DegistirKomut.Parameters.AddWithValue("@PostaKodu", txtpostakodu.Text);
                DegistirKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                DegistirKomut.Parameters.AddWithValue("@Faks", txtfaks.Text);
                DegistirKomut.Parameters.AddWithValue("@Mail", txtmail.Text);
                DegistirKomut.Parameters.AddWithValue("@MusteriKimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtfirmaadi.Text + "" + txtmusteritemsilcisi.Text + "isimli kayıt Değiştirildi");
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
            txtfirmano.BackColor = Color.White;
            txtfirmaadi.BackColor = Color.White;
            txtmusteritemsilcisi.BackColor = Color.White;
            txtvergino.BackColor = Color.White;
            cmbvergidairesi.BackColor = Color.White;
            txthesapno.BackColor = Color.White;
            cmbdovizbirimi.BackColor = Color.White;
            txtadres.BackColor = Color.White;
            txtpostakodu.BackColor = Color.White;
            txttelefon.BackColor = Color.White;
            txtfaks.BackColor = Color.White;
            txtmail.BackColor = Color.White;


            if (cmbdovizbirimi.Text == "Döviz Seçiniz" || cmbdovizbirimi.Text == "")
            {
                cmbdovizbirimi.BackColor = Color.DarkRed;
                cmbdovizbirimi.Focus();
                bos = true;

            }

            if (cmbvergidairesi.Text == "Vergi Dairesini Seçiniz" || cmbvergidairesi.Text == "")
            {
                cmbvergidairesi.BackColor = Color.DarkRed;
                cmbvergidairesi.Focus();
                bos = true;

            }



            if (txtfirmano.Text == "")
            {
                txtfirmano.BackColor = Color.DarkRed;
                txtfirmano.Focus();
                bos = true;

            }

            if (txtfirmaadi.Text == "")
            {
                txtfirmaadi.BackColor = Color.DarkRed;
                txtfirmaadi.Focus();
                bos = true;

            }

            if (txtmusteritemsilcisi.Text == "")
            {
                txtmusteritemsilcisi.BackColor = Color.DarkRed;
                txtmusteritemsilcisi.Focus();
                bos = true;

            }

            if (txtvergino.Text == "")
            {
                txtvergino.BackColor = Color.DarkRed;
                txtvergino.Focus();
                bos = true;

            }

            if (txthesapno.Text == "")
            {
                txthesapno.BackColor = Color.DarkRed;
                txthesapno.Focus();
                bos = true;

            }

            if (txtadres.Text == "")
            {
                txtadres.BackColor = Color.DarkRed;
                txtadres.Focus();
                bos = true;

            }

            if (txtpostakodu.Text == "")
            {
                txtpostakodu.BackColor = Color.DarkRed;
                txtpostakodu.Focus();
                bos = true;

            }

            if (txttelefon.Text == "")
            {
                txttelefon.BackColor = Color.DarkRed;
                txttelefon.Focus();
                bos = true;

            }

            if (txtfaks.Text == "")
            {
                txtfaks.BackColor = Color.DarkRed;
                txtfaks.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayıtDegistir();
        }
    }
}

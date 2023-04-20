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
    public partial class SatisFaturaGuncelle : Form
    {
        public SatisFaturaGuncelle()
        {
            InitializeComponent();
        }


        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");

        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }
            catch (Exception Hata)
            {
                //sistem hata mesajı
                MessageBox.Show(Hata.Message, "Bağlantı Hatası");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Geri Dön Butonu
            SatisFaturaListele frmgerilistele = new SatisFaturaListele();
            frmgerilistele.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfaturano.Text = "";
            txtbelgeno.Text = "";
            txtmusteri.Text = "";
            cmbdovizturu.Text = "";
            txtfaturatarihi.Text = "";
            txtvadetarihi.Text = "";
            txtmustertitemsilci.Text = "";
            cmbfaturaturu.Text = "";
            txtfiyat.Text = "";
            txtdoviztutar.Text = "";
            txttltutar.Text = "";
            cmbkdvorani.Text = "";
            txtaciklama.Text = "";
        }

        public void KayıtDegistir()
        {
            try
            {
                SatisFaturaGuncelle.BaglantiAc();
                string Sorgu = "Update SatisFatura Set FaturaNo=@FaturaNo,BelgeNo=@BelgeNo,Musteri=@Musteri,FaturaDovizi=@FaturaDovizi,FaturaTarihi=@FaturaTarihi,VadeTarihi=@VadeTarihi,MusteriTemsilcisi=@MusteriTemsilcisi,FaturaTuru=@FaturaTuru,Fiyat=@Fiyat,DovizTutar=@DovizTutar,TLTutar=@TLTutar,KdvOrani=@KdvOrani,Aciklama=@Aciklama where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, SatisFaturaGuncelle.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@FaturaNo", txtfaturano.Text);
                DegistirKomut.Parameters.AddWithValue("@BelgeNo", txtbelgeno.Text);
                DegistirKomut.Parameters.AddWithValue("@Musteri", txtmusteri.Text);
                DegistirKomut.Parameters.AddWithValue("@FaturaDovizi", cmbdovizturu.Text);
                DegistirKomut.Parameters.AddWithValue("@FaturaTarihi", txtfaturatarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@VadeTarihi", txtvadetarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@MusteriTemsilcisi", txtmustertitemsilci.Text);
                DegistirKomut.Parameters.AddWithValue("@FaturaTuru", cmbfaturaturu.Text);
                DegistirKomut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
                DegistirKomut.Parameters.AddWithValue("@DovizTutar", txtdoviztutar.Text);
                DegistirKomut.Parameters.AddWithValue("@TLTutar", txttltutar.Text);
                DegistirKomut.Parameters.AddWithValue("@KdvOrani", cmbkdvorani.Text);
                DegistirKomut.Parameters.AddWithValue("@Aciklama", txtaciklama.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtfaturano.Text + "" + txtbelgeno.Text + "isimli kayıt Değiştirildi");
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
            txtfaturano.BackColor = Color.White;
            txtbelgeno.BackColor = Color.White;
            txtmusteri.BackColor = Color.White;
            cmbdovizturu.BackColor = Color.White;
            txtfaturatarihi.BackColor = Color.White;
            txtvadetarihi.BackColor = Color.White;
            txtmustertitemsilci.BackColor = Color.White;
            cmbfaturaturu.BackColor = Color.White;
            txtfiyat.BackColor = Color.White;
            txtdoviztutar.BackColor = Color.White;
            txttltutar.BackColor = Color.White;
            cmbkdvorani.BackColor = Color.White;
            txtaciklama.BackColor = Color.White;

            if (cmbdovizturu.Text == "Döviz Seçiniz" || cmbdovizturu.Text == "")
            {
                cmbdovizturu.BackColor = Color.DarkRed;
                cmbdovizturu.Focus();
                bos = true;

            }

            if (cmbfaturaturu.Text == "Fatura Türünü Seçiniz" || cmbfaturaturu.Text == "")
            {
                cmbfaturaturu.BackColor = Color.DarkRed;
                cmbfaturaturu.Focus();
                bos = true;

            }

            if (cmbkdvorani.Text == "KDV Oranı Seçiniz" || cmbkdvorani.Text == "")
            {
                cmbkdvorani.BackColor = Color.DarkRed;
                cmbkdvorani.Focus();
                bos = true;

            }

            if (txtfaturano.Text == "")
            {
                txtfaturano.BackColor = Color.DarkRed;
                txtfaturano.Focus();
                bos = true;

            }

            if (txtbelgeno.Text == "")
            {
                txtbelgeno.BackColor = Color.DarkRed;
                txtbelgeno.Focus();
                bos = true;

            }

            if (txtmusteri.Text == "")
            {
                txtmusteri.BackColor = Color.DarkRed;
                txtmusteri.Focus();
                bos = true;

            }

            if (txtfaturatarihi.Text == "")
            {
                txtfaturatarihi.BackColor = Color.DarkRed;
                txtfaturatarihi.Focus();
                bos = true;

            }

            if (txtmustertitemsilci.Text == "")
            {
                txtmustertitemsilci.BackColor = Color.DarkRed;
                txtmustertitemsilci.Focus();
                bos = true;

            }

            if (txtfiyat.Text == "")
            {
                txtfiyat.BackColor = Color.DarkRed;
                txtfiyat.Focus();
                bos = true;

            }

            if (txtdoviztutar.Text == "")
            {
                txtdoviztutar.BackColor = Color.DarkRed;
                txtdoviztutar.Focus();
                bos = true;

            }

            if (txttltutar.Text == "")
            {
                txttltutar.BackColor = Color.DarkRed;
                txttltutar.Focus();
                bos = true;

            }

            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
                bos = true;

            }

            if (txtaciklama.Text == "")
            {
                txtaciklama.BackColor = Color.DarkRed;
                txtaciklama.Focus();
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

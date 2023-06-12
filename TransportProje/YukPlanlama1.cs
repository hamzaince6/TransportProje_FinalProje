using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace TransportProje
{
    public partial class YukPlanlama1 : Form
    {
        public YukPlanlama1()
        {
            InitializeComponent();
        }

        // Database Tanımlama
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

        public void SoforListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from ithaalat "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "ithaalat");
                datagridithaalat.DataSource = ds.Tables["ithaalat"]; //ithaalat Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "ithaalat Listele Hata Penceresi");
            }
        }

        private void dovizkuru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));

                lbldolar.Text = dolar.ToString();
                lbleuro.Text = euro.ToString();
                lblsterlin.Text = sterlin.ToString();
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }

        }





        private void YukPlanlama1_Load(object sender, EventArgs e)
        {
            //Buton6 Gizleme
            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //Buton7 Gizleme
            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SoforListele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            YukPlanlama form1 = new YukPlanlama();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan Çıkamak İstiyor musunuz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult Deneme;
                Deneme = MessageBox.Show("Programdan Çıkış Yapılıyor");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Programa Geri Dönülüyor...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YukPlanlama form1 = new YukPlanlama();
            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            DovizGoster();
        }

        public void KayitEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into ithaalat (YukNo,GondericiFirma,AliciFirma,YuklemeYeri,BosaltmaYeri,TasimaSekli,PozisyonTipi,CekiciPlaka,SurucuAdi) Values (@YukNo,@GondericiFirma,@AliciFirma,@YuklemeYeri,@BosaltmaYeri,@TasimaSekli,@PozisyonTipi,@CekiciPlaka,@SurucuAdi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@YukNo", txtyukno.Text);
                EkleKomut.Parameters.AddWithValue("@Musteri", txtmusteri.Text);
                EkleKomut.Parameters.AddWithValue("@GondericiFirma", txtgonderici.Text);
                EkleKomut.Parameters.AddWithValue("@AliciFirma", txtalici.Text);
                EkleKomut.Parameters.AddWithValue("@YuklemeYeri", cmbyuklemeyeri.Text);
                EkleKomut.Parameters.AddWithValue("@BosaltmaYeri", cmbbosaltmayeri.Text);
                EkleKomut.Parameters.AddWithValue("@TasimaSekli", cmbtasimasekli.Text);
                EkleKomut.Parameters.AddWithValue("@PozisyonTipi", cmbpozisyontipi.Text);
                EkleKomut.Parameters.AddWithValue("@CekiciPlaka", txtcekiciplaka.Text);
                EkleKomut.Parameters.AddWithValue("@SurucuAdi", txtsoforisim.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtyukno.Text = "";
            txtmusteri.Text = "";
            txtgonderici.Text = "";
            txtalici.Text = "";
            cmbyuklemeyeri.Text = "";
            cmbbosaltmayeri.Text = "";
            cmbtasimasekli.Text = "";
            cmbpozisyontipi.Text = "";
            txtcekiciplaka.Text = "";
            txtsoforisim.Text = "";
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtyukno.BackColor = Color.White;
            txtmusteri.BackColor = Color.White;
            txtgonderici.BackColor = Color.White;
            txtalici.BackColor = Color.White;
            cmbyuklemeyeri.BackColor = Color.White;
            cmbbosaltmayeri.BackColor = Color.White;
            cmbtasimasekli.BackColor = Color.White;
            cmbpozisyontipi.BackColor = Color.White;
            txtcekiciplaka.BackColor = Color.White;
            txtsoforisim.BackColor = Color.White;


            if (cmbyuklemeyeri.Text == "Yükleme Yeri Seçiniz" || cmbyuklemeyeri.Text == "")
            {
                cmbyuklemeyeri.BackColor = Color.DarkRed;
                cmbyuklemeyeri.Focus();
                bos = true;

            }

            if (cmbbosaltmayeri.Text == "Boşaltma Yeri Seçiniz" || cmbbosaltmayeri.Text == "")
            {
                cmbbosaltmayeri.BackColor = Color.DarkRed;
                cmbbosaltmayeri.Focus();
                bos = true;

            }


            if (cmbpozisyontipi.Text == "Pozisyon Seçiniz" || cmbpozisyontipi.Text == "")
            {
                cmbpozisyontipi.BackColor = Color.DarkRed;
                cmbpozisyontipi.Focus();
                bos = true;

            }

            if (cmbtasimasekli.Text == "Taşıma Şekli Seçiniz" || cmbtasimasekli.Text == "")
            {
                cmbtasimasekli.BackColor = Color.DarkRed;
                cmbtasimasekli.Focus();
                bos = true;

            }

            if (txtyukno.Text == "")
            {
                txtyukno.BackColor = Color.DarkRed;
                txtyukno.Focus();
                bos = true;

            }

            if (txtmusteri.Text == "")
            {
                txtmusteri.BackColor = Color.DarkRed;
                txtmusteri.Focus();
                bos = true;

            }

            if (txtgonderici.Text == "")
            {
                txtgonderici.BackColor = Color.DarkRed;
                txtgonderici.Focus();
                bos = true;

            }

            if (txtalici.Text == "")
            {
                txtalici.BackColor = Color.DarkRed;
                txtalici.Focus();
                bos = true;

            }

            if (txtcekiciplaka.Text == "")
            {
                txtcekiciplaka.BackColor = Color.DarkRed;
                txtcekiciplaka.Focus();
                bos = true;

            }

            if (txtsoforisim.Text == "")
            {
                txtsoforisim.BackColor = Color.DarkRed;
                txtsoforisim.Focus();
                bos = true;

            }


            return bos;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'deki seçili satırın primary key değerini al
            int seciliSatirId = Convert.ToInt32(datagridithaalat.CurrentRow.Cells["Kimlik"].Value);

            // Veritabanı bağlantısını oluştur
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb;"))
            {
                conn.Open();

                // Veritabanındaki ilgili kaydı sil
                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM ithaalat WHERE Kimlik = @Kimlik", conn))
                {
                    cmd.Parameters.AddWithValue("@Kimlik", seciliSatirId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // DataGridView'den seçili satırı kaldır
            datagridithaalat.Rows.Remove(datagridithaalat.CurrentRow);
        }

        private void lbleuro_Click(object sender, EventArgs e)
        {

        }

        private void lbldolar_Click(object sender, EventArgs e)
        {

        }

        private void lblsterlin_Click(object sender, EventArgs e)
        {

        }

        private void datagridithaalat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmdegistir_Click(object sender, EventArgs e)
        {

        }

        private void radplaka_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Yuk No :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radtcno_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Yukleme Yeri :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        public void SoforHizliAra()
        {
            try
            {



                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from ithaalat";
                string SorguBayiilebaslayan = "Select * From ithaalat where YuklemeYeri Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From ithaalat where YuklemeYeri Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From ithaalat where YuklemeYeri Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From ithaalat where YukNo Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From ithaalat where YukNo Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From ithaalat where YukNo Like '%" + txtAranan.Text + "%'";

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radyuklemeyeri.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radyuklemeyeri.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radyuklemeyeri.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }
                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "ithaalat");
                datagridithaalat.DataSource = ds.Tables["ithaalat"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            SoforHizliAra();
        }
    }
}

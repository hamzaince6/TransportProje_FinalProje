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
using System.Xml;

namespace TransportProje
{
    public partial class MusteriTakip : Form
    {
        public MusteriTakip()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            DovizGoster();
        }

        private void dovizkuru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MusteriTakip_Load(object sender, EventArgs e)
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
            MusteriTakip1();

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

        private void button7_Click(object sender, EventArgs e)
        {
            Pazarlama form1 = new Pazarlama();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pazarlama form1 = new Pazarlama();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pazarlama form1 = new Pazarlama();
            form1.Show();
            this.Hide();
        }
        public void MusteriTakip1()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select * from MusteriTakip "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "MusteriTakip");
                dataGridMusteriTakip.DataSource = ds.Tables["MusteriTakip"]; //MusteriKarti1 tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "MusteriTakip Listele Hata Penceresi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'deki seçili satırın primary key değerini al
            int seciliSatirId = Convert.ToInt32(dataGridMusteriTakip.CurrentRow.Cells["Kimlik"].Value);

            // Veritabanı bağlantısını oluştur
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb;"))
            {
                conn.Open();

                // Veritabanındaki ilgili kaydı sil
                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM MusteriKarti WHERE Kimlik = @Kimlik", conn))
                {
                    cmd.Parameters.AddWithValue("@MusteriTakip", seciliSatirId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // DataGridView'den seçili satırı kaldır
            dataGridMusteriTakip.Rows.Remove(dataGridMusteriTakip.CurrentRow);
        }

        public void MusteriTakipEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into MusteriTakip (MusteriKimlik,KayıtNo,GorusulenKisi,GorusenKisi,UyariTarihi,Durumu,Konu,GorusmeIcerigi,MusteriSikayetBeklenti,Sonuc) Values (@MusteriKimlik,@KayıtNo,@GorusulenKisi,@GorusenKisi,@UyariTarihi,@Durumu,@Konu,@GorusmeIcerigi,@MusteriSikayetBeklenti,@Sonuc)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@MusteriKimlik", txtmusterikimlik.Text);
                EkleKomut.Parameters.AddWithValue("@KayıtNo", txtkayitno.Text);
                EkleKomut.Parameters.AddWithValue("@GorusulenKisi", txtgorusulenkisi.Text);
                EkleKomut.Parameters.AddWithValue("@GorusenKisi", txtgorusenkisi.Text);
                EkleKomut.Parameters.AddWithValue("@UyariTarihi", txtuyaritarihi.Text);
                EkleKomut.Parameters.AddWithValue("@Durumu", cmbdurumu.Text);
                EkleKomut.Parameters.AddWithValue("@Konu", txtkonu.Text);
                EkleKomut.Parameters.AddWithValue("@GorusmeIcerigi", txtgorusmeicerik.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriSikayetBeklenti", cmbsikayetbeklenti.Text);
                EkleKomut.Parameters.AddWithValue("@Sonuc", cmbsonuc.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                MusteriTakipEkle();
        }

        private void frmdegistir_Click(object sender, EventArgs e)
        {
            MusteriTakipGuncelle frmdegistir = new MusteriTakipGuncelle();
            frmdegistir.Show();
            MusteriTakipGuncelle frmdegistir1 = new MusteriTakipGuncelle();
            frmdegistir.txtid.Text = dataGridMusteriTakip.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtmusterikimlik.Text = dataGridMusteriTakip.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtkayitno.Text = dataGridMusteriTakip.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtgorusulenkisi.Text = dataGridMusteriTakip.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtgorusenkisi.Text = dataGridMusteriTakip.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtuyaritarihi.Text = dataGridMusteriTakip.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbdurumu.Text = dataGridMusteriTakip.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtkonu.Text = dataGridMusteriTakip.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtgorusmeicerik.Text = dataGridMusteriTakip.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.cmbsikayetbeklenti.Text = dataGridMusteriTakip.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.cmbsonuc.Text = dataGridMusteriTakip.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.Show();
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            RaporMusteriTakip frm2 = new RaporMusteriTakip();
            frm2.ShowDialog();

        }

        public void SoforHizliAra()
        {
            try
            {



                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from MusteriTakip";
                string SorguBayiilebaslayan = "Select * From MusteriTakip where Konu Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From MusteriTakip where Konu Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From MusteriTakip where Konu Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From MusteriTakip where Durumu Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From MusteriTakip where Durumu Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From MusteriTakip where Durumu Like '%" + txtAranan.Text + "%'";

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radtcno.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radtcno.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radtcno.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }
                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "MusteriTakip");
                dataGridMusteriTakip.DataSource = ds.Tables["MusteriTakip"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void radplaka_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Durum :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radtcno_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Konu :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            SoforHizliAra();
        }
    }
}

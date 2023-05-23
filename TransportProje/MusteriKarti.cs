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
    public partial class MusteriKarti : Form
    {
        public MusteriKarti()
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


        public void MusteriKarti12()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select * from MusteriKarti "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "MusteriKarti");
                dataGridMusteriKarti.DataSource = ds.Tables["MusteriKarti"]; //MusteriKarti1 tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "MusteriKarti Listele Hata Penceresi");
            }
        }



        // Döviz Gösterme
        private void dovizkuru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // Döviz Gösterme
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            DovizGoster();
        }
        // Döviz Gösterme
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

        private void MusteriKarti_Load(object sender, EventArgs e)
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

            MusteriKarti12();
            DovizGoster();
        }
        // Çıkış Butonu 
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
        // Geri Dönme Butonu
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

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'deki seçili satırın primary key değerini al
            int seciliSatirId = Convert.ToInt32(dataGridMusteriKarti.CurrentRow.Cells["MusteriKimlik"].Value);

            // Veritabanı bağlantısını oluştur
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb;"))
            {
                conn.Open();

                // Veritabanındaki ilgili kaydı sil
                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM MusteriKarti WHERE MusteriKimlik = @MusteriKimlik", conn))
                {
                    cmd.Parameters.AddWithValue("@MusteriKimlik", seciliSatirId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // DataGridView'den seçili satırı kaldır
            dataGridMusteriKarti.Rows.Remove(dataGridMusteriKarti.CurrentRow);
        }


        public void MusteriEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into MusteriKarti (FirmaNo,FirmaAdi,MusteriTemsilcisi,VergiNo,VergiDairesi,HesapNo,DovizBirimi,Adres,PostaKodu,Telefon,Faks,Mail) Values (@FirmaNo,@FirmaAdi,@MusteriTemsilcisi,@VergiNo,@VergiDairesi,@HesapNo,@DovizBirimi,@Adres,@PostaKodu,@Telefon,@Faks,@Mail)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@FirmaNo", txtfirmano.Text);
                EkleKomut.Parameters.AddWithValue("@FirmaAdi", txtfirmaadi.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriTemsilcisi", txtmusteritemsilcisi.Text);
                EkleKomut.Parameters.AddWithValue("@VergiNo", txtvergino.Text);
                EkleKomut.Parameters.AddWithValue("@VergiDairesi", cmbvergidairesi.Text);
                EkleKomut.Parameters.AddWithValue("@HesapNo", txthesapno.Text);
                EkleKomut.Parameters.AddWithValue("@DovizBirimi", cmbdovizbirimi.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                EkleKomut.Parameters.AddWithValue("@PostaKodu", txtpostakodu.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                EkleKomut.Parameters.AddWithValue("@Faks", txtfaks.Text);
                EkleKomut.Parameters.AddWithValue("@Mail", txtmail.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                MusteriEkle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriKartiGuncelle frmdegistir = new MusteriKartiGuncelle();
            frmdegistir.Show();
            MusteriKartiGuncelle frmdegistir1 = new MusteriKartiGuncelle();
            frmdegistir.txtid.Text = dataGridMusteriKarti.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtfirmano.Text = dataGridMusteriKarti.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtfirmaadi.Text = dataGridMusteriKarti.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtmusteritemsilcisi.Text = dataGridMusteriKarti.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtvergino.Text = dataGridMusteriKarti.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.cmbvergidairesi.Text = dataGridMusteriKarti.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txthesapno.Text = dataGridMusteriKarti.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbdovizbirimi.Text = dataGridMusteriKarti.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtadres.Text = dataGridMusteriKarti.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtpostakodu.Text = dataGridMusteriKarti.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txttelefon.Text = dataGridMusteriKarti.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txtfaks.Text = dataGridMusteriKarti.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtmail.Text = dataGridMusteriKarti.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.Show();
            this.Close();
        }

        private void dataGridMusteriKarti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtfaks_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txttelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtpostakodu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtadres_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtfirmaadi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbvergidairesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txthesapno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtvergino_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtmusteritemsilcisi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbdovizbirimi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfirmano_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

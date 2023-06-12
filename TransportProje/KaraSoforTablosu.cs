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
    public partial class KaraSoforTablosu : Form
    {
        public KaraSoforTablosu()
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        public void SoforListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Sofor "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Sofor");
                dataGridSofor.DataSource = ds.Tables["Sofor"]; //Soför Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Soför Listele Hata Penceresi");
            }
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

        private void button5_Click(object sender, EventArgs e)
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

        private void KaraSoforTablosu_Load(object sender, EventArgs e)
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
            SoforVeriYukleEhliyetSınıf12();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'deki seçili satırın primary key değerini al
            int seciliSatirId = Convert.ToInt32(dataGridSofor.CurrentRow.Cells["Kimlik"].Value);

            // Veritabanı bağlantısını oluştur
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb;"))
            {
                conn.Open();

                // Veritabanındaki ilgili kaydı sil
                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM Sofor WHERE Kimlik = @Kimlik", conn))
                {
                    cmd.Parameters.AddWithValue("@Kimlik", seciliSatirId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // DataGridView'den seçili satırı kaldır
            dataGridSofor.Rows.Remove(dataGridSofor.CurrentRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            this.Hide();
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
            Main form1 = new Main();
            form1.Show();
            this.Hide();
        }

        private void frmdegistir_Click(object sender, EventArgs e)
        {
            KaraSoforTablosuGuncelle frmdegistir = new KaraSoforTablosuGuncelle();
            frmdegistir.txtid.Text = dataGridSofor.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtad.Text = dataGridSofor.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtsoyad.Text = dataGridSofor.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txttckimlik.Text = dataGridSofor.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtplaka.Text = dataGridSofor.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtbaslama.Text = dataGridSofor.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtayrilma.Text = dataGridSofor.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtayrilmanedeni.Text = dataGridSofor.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtadres.Text = dataGridSofor.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txttelefon.Text = dataGridSofor.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.cmbogrenimdurumu.Text = dataGridSofor.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.cmbehliyetsinif.Text = dataGridSofor.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtehiletno.Text = dataGridSofor.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtsrcno.Text = dataGridSofor.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.txtpiskono.Text = dataGridSofor.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.txttakografno.Text = dataGridSofor.CurrentRow.Cells[15].Value.ToString();
            frmdegistir.ShowDialog();
            this.Hide();
        }

        public void SoforKayitAra12()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguSoforKayitAra = "select * from Sofor";
                string SorguSoforKayitAraTcKimlik = "Select * From Sofor where TcKimlikNo='" + txtkaratc.Text + "'";
                string SorguSoforKayitAraPlaka = "Select * From Sofor where Plaka='" + txtkaraplaka.Text + "'";
                string SorguSoforKayitAraEhliyetSinif = "Select * From Sofor where EhliyetSinifi='" + cmbehliyet155.Text + "'";

                string SorguTCNoPlaka = "Select * From Sofor where TcKimlikNo='" + txtkaratc.Text + "' And Plaka='" + txtkaraplaka.Text + "'";
                string SorguTCNoEhliyetSınıfı = "Select * From Sofor where TcKimlikNo='" + txtkaratc.Text + "' And EhliyetSinifi='" + cmbehliyet155.Text + "'";
                string SorguPlakaEhliyetSınıfı = "Select * From Sofor where Plaka='" + txtkaraplaka.Text + "' And EhliyetSinifi='" + cmbehliyet155.Text + "'";
                string SorguTCNoPlakaEhliyetSınıfı = "Select * From Sofor where TcKimlikNo='" + txtkaratc.Text + "' And Plaka='" + txtkaraplaka.Text + "'  And TcKimlikNo='" + txtkaratc.Text + "'";

                if (chktcno.Checked && chkplaka12.Checked && chkehliyetsinifi255.Checked)
                    SorguSoforKayitAra = SorguTCNoPlakaEhliyetSınıfı;
                else if (chktcno.Checked && chkplaka12.Checked)
                    SorguSoforKayitAra = SorguTCNoPlaka;
                else if (chktcno.Checked && chkehliyetsinifi255.Checked)
                    SorguSoforKayitAra = SorguTCNoEhliyetSınıfı;
                else if (chkplaka12.Checked && chkehliyetsinifi255.Checked)
                    SorguSoforKayitAra = SorguPlakaEhliyetSınıfı;
                else if (chktcno.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraTcKimlik;
                else if (chkplaka12.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraPlaka;
                else if (chkehliyetsinifi255.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraEhliyetSinif;


                OleDbDataAdapter da = new OleDbDataAdapter(SorguSoforKayitAra, Baglanti);
                da.Fill(ds, "Sofor");
                dataGridSofor.DataSource = ds.Tables["Sofor"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        public void SoforVeriYukleEhliyetSınıf12()
        {
            try
            {
                KaraSoforTablosu.BaglantiAc();
                string Sorgu = "Select EhliyetSinifi from Sofor";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, KaraSoforTablosu.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbehliyet155.Items.Add(dr["EhliyetSinifi"]);
                }
                KaraSoforTablosu.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        private void btnkaraara_Click(object sender, EventArgs e)
        {
            SoforKayitAra12();
        }

        private void radplaka_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Plaka :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radtcno_CheckedChanged(object sender, EventArgs e)
        {
            lblAlanalan.Text = "Tc No :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        public void SoforHizliAra()
        {
            try
            {



                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Sofor";
                string SorguBayiilebaslayan = "Select * From Sofor where TcKimlikNo Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From Sofor where TcKimlikNo Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From Sofor where TcKimlikNo Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Sofor where Plaka Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Sofor where Plaka Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From Sofor where Plaka Like '%" + txtAranan.Text + "%'";

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
                da.Fill(ds, "Sofor");
                dataGridSofor.DataSource = ds.Tables["Sofor"];
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

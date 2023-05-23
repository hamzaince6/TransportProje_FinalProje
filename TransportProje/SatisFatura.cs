using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;

namespace TransportProje
{
    public partial class SatisFatura : Form
    {
        public SatisFatura()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
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

        private void SatisFatura_Load(object sender, EventArgs e)
        {
            //Buton1 Gizleme
            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //Buton2 Gizleme
            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;

            DovizGoster();
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

        private void dovizkuru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            DovizGoster();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            SatisFaturaListele frmfaturalistele = new SatisFaturaListele();
            frmfaturalistele.ShowDialog();
            this.Close();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

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
                string Sorgu = "Insert Into SatisFatura (FaturaNo,BelgeNo,Musteri,FaturaDovizi,FaturaTarihi,VadeTarihi,MusteriTemsilcisi,FaturaTuru,Fiyat,DovizTutar,TLTutar,KdvOrani,Aciklama) Values (@FaturaNo,@BelgeNo,@Musteri,@FaturaDovizi,@FaturaTarihi,@VadeTarihi,@MusteriTemsilcisi,@FaturaTuru,@Fiyat,@DovizTutar,@TLTutar,@KdvOrani,@Aciklama)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@FaturaNo", txtfaturano.Text);
                EkleKomut.Parameters.AddWithValue("@BelgeNo", txtbelgeno.Text);
                EkleKomut.Parameters.AddWithValue("@Musteri", txtmusteri.Text);
                EkleKomut.Parameters.AddWithValue("@FaturaDovizi", cmbdovizturu.Text);
                EkleKomut.Parameters.AddWithValue("@FaturaTarihi", txtfaturatarihi.Text);
                EkleKomut.Parameters.AddWithValue("@VadeTarihi", txtvadetarihi.Text);
                EkleKomut.Parameters.AddWithValue("@MusteriTemsilcisi", txtmustertitemsilci.Text);
                EkleKomut.Parameters.AddWithValue("@FaturaTuru", cmbfaturaturu.Text);
                EkleKomut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
                EkleKomut.Parameters.AddWithValue("@DovizTutar", txtdoviztutar.Text);
                EkleKomut.Parameters.AddWithValue("@TLTutar", txttltutar.Text);
                EkleKomut.Parameters.AddWithValue("@KdvOrani", cmbkdvorani.Text);
                EkleKomut.Parameters.AddWithValue("@Aciklama", txtaciklama.Text);
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
            Main frmgeri = new Main();
            frmgeri.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            if (txtaciklama.Text == "")
            {
                txtaciklama.BackColor = Color.DarkRed;
                txtaciklama.Focus();
                bos = true;

            }

            return bos;

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            YillikGelirListele frmyillikgelir = new YillikGelirListele();
            frmyillikgelir.ShowDialog();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            AylikGelirListele frmayliklistele = new AylikGelirListele();
            frmayliklistele.ShowDialog();
            this.Hide();
        }
    }
}

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
    public partial class Tanimlamalar : Form
    {
        public Tanimlamalar()
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
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }

        public void Giris()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Giris "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Giris");
                dataGridView1.DataSource = ds.Tables["Giris"]; //Giriş tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }
        public void Trucks()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Trucks "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Trucks");
                dataGridView1.DataSource = ds.Tables["Trucks"]; //Trucks tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        public void Trailer()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Trailer "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Trailer");
                dataGridView1.DataSource = ds.Tables["Trailer"]; //Trailer tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        public void Personel()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Personel "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        public void YakitTakip()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from YakitTakip "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "YakitTakip");
                dataGridView1.DataSource = ds.Tables["YakitTakip"]; //Yakit Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }


        private void uygulamadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            this.Hide();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel();
        }

        private void girişListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void çekiciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trucks();
        }

        private void dorseListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trailer();
        }

        private void yakitTakipListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YakitTakip();
        }
    }
}

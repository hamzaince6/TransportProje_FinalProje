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
    public partial class AylikGelirListele : Form
    {
        public AylikGelirListele()
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



        public void AylikGelirListele1()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from AylikGelir "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "AylikGelir");
                dataGridAylik.DataSource = ds.Tables["AylikGelir"]; //AylikGelir Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "AylikGelir Listele Hata Penceresi");
            }
        }

        private void AylikGelirListele_Load(object sender, EventArgs e)
        {
            AylikGelirListele1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Geri Dön Butonu
            SatisFatura frmgerilistele = new SatisFatura();
            frmgerilistele.Show();
            this.Close();
        }
    }
}

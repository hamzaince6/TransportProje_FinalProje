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
    public partial class YillikGelirListele : Form
    {
        public YillikGelirListele()
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

        public void YillikGelirListele1()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from YillikGelir "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "YillikGelir");
                dataGridYillik.DataSource = ds.Tables["YillikGelir"]; //YillikGelir Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "YillikGelir Listele Hata Penceresi");
            }
        }

        private void YillikGelirListele_Load(object sender, EventArgs e)
        {
            YillikGelirListele1();
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

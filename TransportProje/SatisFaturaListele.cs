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
    public partial class SatisFaturaListele : Form
    {
        public SatisFaturaListele()
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


        public void SatisFatura()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from SatisFatura "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "SatisFatura");
                dataGridView1.DataSource = ds.Tables["SatisFatura"]; //SatisFatura tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        private void SatisFaturaListele_Activated(object sender, EventArgs e)
        {
            
            SatisFatura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisFatura frmgerilistele = new SatisFatura();
            frmgerilistele.Show();
            this.Close();

        }

        private void SatisFaturaListele_Load(object sender, EventArgs e)
        {
            //Buton1 Gizleme
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}

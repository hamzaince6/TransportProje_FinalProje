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


        public void SatisFatura()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select * from SatisFatura "; //Sql Komutunu yaz
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
            // Satis Faturası
            SatisFatura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Geri Dön Butonu
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

      
        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridView'deki seçili satırın primary key değerini al
            int seciliSatirId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kimlik"].Value);

            // Veritabanı bağlantısını oluştur
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb;"))
            {
                conn.Open();

                // Veritabanındaki ilgili kaydı sil
                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM SatisFatura WHERE Kimlik = @Kimlik", conn))
                {
                    cmd.Parameters.AddWithValue("@Kimlik", seciliSatirId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            // DataGridView'den seçili satırı kaldır
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisFaturaGuncelle frmdegistir = new SatisFaturaGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtfaturano.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtbelgeno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtmusteri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.cmbdovizturu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtfaturatarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtvadetarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtmustertitemsilci.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.cmbfaturaturu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtfiyat.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtdoviztutar.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txttltutar.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.cmbkdvorani.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtaciklama.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.Show();
            this.Hide();
        }

        private void SatisFaturaListele_Load_1(object sender, EventArgs e)
        {
                Baglanti.Open();
                // Veritabanından tüm kayıtları seç
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM SatisFatura", Baglanti))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // DataGridView'in veri kaynağı olarak DataTable'ı kullan
                    dataGridView1.DataSource = dt;
                }
                Baglanti.Close();
            // DataGridView'in veri kaynağına yeni bir veri eklenirse veya mevcut bir veri güncellenirse
            // DataGridView'in otomatik olarak güncellenmesini sağlamak için aşağıdaki kod kullanılabilir.
            // Bu kod, DataGridView'in veri kaynağındaki değişiklikleri takip etmesini sağlar.
            ((DataTable)dataGridView1.DataSource).RowChanged += new DataRowChangeEventHandler(dataGridView1_RowChanged);
        }

        private void dataGridView1_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // Veri kaynağındaki değişiklikleri otomatik olarak güncelle
            ((DataTable)dataGridView1.DataSource).AcceptChanges();
        }
    }
}

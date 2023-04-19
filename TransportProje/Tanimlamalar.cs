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
                MessageBox.Show(Hata.Message, "Bağlantı Hatası");
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


        public void SoforListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Sofor "; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Sofor");
                dataGridView1.DataSource = ds.Tables["Sofor"]; //Soför Takip tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Soför Listele Hata Penceresi");
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

        private void çekiciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CekiciEkle frmekle = new CekiciEkle();
            frmekle.Show();
            this.Hide();
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
            this.Hide();

        }

        private void Tanimlamalar_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            Trucks();
        }

        private void dorseEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DorseEkle frmekledorse = new DorseEkle();
            frmekledorse.Show();
            this.Hide();
        }

        private void soförListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforListele();
        }

        private void soförEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforEkle frmeklesofor = new SoforEkle();
            frmeklesofor.Show();
            this.Hide();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle frmeklepersonel = new PersonelEkle();
            frmeklepersonel.Show();
            this.Hide();
        }

        private void girişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeEkle frmuyeekle = new UyeEkle();
            frmuyeekle.Show();
            this.Hide();
        }

        private void yakıtTakipEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YakitTakipEkle frmyakitekle = new YakitTakipEkle();
            frmyakitekle.Show();
            this.Hide();
        }

        private void çekiciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CekiciSil frmsil = new CekiciSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtmarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtmodel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtplaka.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
           
        }

        private void dorseSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DorseSil frmsil = new DorseSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtkullanimalani.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtmodelyili.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtsasino.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
        }

        private void soförSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforSil frmsil = new SoforSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txttcno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsil.txtehliyetno.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSil frmsil = new PersonelSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txttcno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsil.txttelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSil frmsil = new UyeSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtkad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
        }

        private void yakıtTakipSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YakitTakipSil frmsil = new YakitTakipSil();
            frmsil.txtkimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtdepohacmi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtyakittipi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsil.ShowDialog();
            this.Hide();
        }

        private void çekiciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CekiciGuncelle frmdegistir = new CekiciGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbmarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtmodel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.cmbrenk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txturetimyili.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.cmbvites.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtkm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbyakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtplaka.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtaracdegeri.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtmtvverisi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txthgsno.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtsasino.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtmotorno.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.cmbdepohacmi.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.txtruhsatno.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frmdegistir.cmbruhsatverilenyer.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frmdegistir.txtnetagirlik.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frmdegistir.cmbmotorgucu.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frmdegistir.cmbplaka.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[20].Value.ToString() == "Yerli")
                frmdegistir.radyerli.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[20].Value.ToString() == "Yabancı")
                frmdegistir.radyabanci.Checked = true;
            frmdegistir.Show();
            this.Hide();
            
        }

        private void dorseGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DorseGuncelle frmdegistir = new DorseGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbkullanimalani.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtmodel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.cmbrenk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtsasino.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtruhsatno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbruhsatverilenyer.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtagirlik.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.cmbbayrak.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "Yerli")
                frmdegistir.radyerli.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "Yabancı")
                frmdegistir.radyabanci.Checked = true;
            frmdegistir.txthgsno.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.cmbboy.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.cmben.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.cmbyukseklik.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.cmbbosagirlik.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
   
            frmdegistir.Show();
            this.Hide();
        }

        private void soförGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforGuncelle frmdegistir = new SoforGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txttckimlik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtplaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtbaslama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtayrilma.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtayrilmanedeni.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtadres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txttelefon.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.cmbogrenimdurumu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.cmbehliyetsinif.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtehiletno.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtsrcno.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.txtpiskono.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.txttakografno.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frmdegistir.Show();
            this.Hide();
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGuncelle frmdegistir = new PersonelGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txttc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmdegistir.raderkek.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kadın")
                frmdegistir.radkadin.Checked = true;
            frmdegistir.txtadres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txttelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbogrenimdurumu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.cmbbirim.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtiban.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtmaas.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txtprim.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtavans.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtcalisma.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.txtbaslama.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.txtayrilmatarihi.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frmdegistir.txtayrilma.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frmdegistir.Show();
            this.Hide();
        }

        private void üyeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeGuncelle frmdegistir = new UyeGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtkullanici.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.Show();
            this.Hide();
        }

        private void yakıtTakipGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YakitTakipGuncelle frmdegistir = new YakitTakipGuncelle();
            frmdegistir.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmbdepohacmi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.cmbyakit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.cmbgunlukhak.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtortalama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.Show();
            this.Hide();
        }
    }
}

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
            DialogResult dialogResult = MessageBox.Show("Programdan Çıkmak İstiyor musunuz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (chkogrenimdurumu.Checked)
            {
                cmbpersonelogrenımdurumu.Enabled = true;
                cmbpersonelogrenımdurumu.Focus();
            }
            else
            {
                cmbpersonelogrenımdurumu.Text = "";
                cmbpersonelogrenımdurumu.Enabled = false;


            }

        }

        private void chkmarka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmarka.Checked)
            {
                cmbcekicimarka.Enabled = true;
                cmbcekicimarka.Focus();
            }
            else
            {
                cmbcekicimarka.Text = "";
                cmbcekicimarka.Enabled = false;


            }
        }

        private void chkmodel_CheckedChanged(object sender, EventArgs e)
        {

            if (chkmodel.Checked)
            {
                txtcekicimodel.Enabled = true;
                txtcekicimodel.Focus();
            }
            else
            {
                txtcekicimodel.Text = "";
                txtcekicimodel.Enabled = false;


            }
        }

        private void chkplaka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkplaka.Checked)
            {
                txtcekiciplaka.Enabled = true;
                txtcekiciplaka.Focus();
            }
            else
            {
                txtcekiciplaka.Text = "";
                txtcekiciplaka.Enabled = false;


            }
        }

        private void chkkullanimalani_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkullanimalani.Checked)
            {
                cmbdorsekullanimalani.Enabled = true;
                cmbdorsekullanimalani.Focus();
            }
            else
            {
                cmbdorsekullanimalani.Text = "";
                cmbdorsekullanimalani.Enabled = false;


            }
        }

        private void chkboy_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkboy.Checked)
            {
                cmbdorseboy.Enabled = true;
                cmbdorseboy.Focus();
            }
            else
            {
                cmbdorseboy.Text = "";
                cmbdorseboy.Enabled = false;


            }
        }

        private void chkyukselik_CheckedChanged(object sender, EventArgs e)
        {
            if (chkyukselik.Checked)
            {
                cmbdorseyukselik.Enabled = true;
                cmbdorseyukselik.Focus();
            }
            else
            {
                cmbdorseyukselik.Text = "";
                cmbdorseyukselik.Enabled = false;


            }
        }

        private void chksofortc_CheckedChanged(object sender, EventArgs e)
        {
            if (chksofortc.Checked)
            {
                txtsofortc.Enabled = true;
                txtsofortc.Focus();
            }
            else
            {
                txtsofortc.Text = "";
                txtsofortc.Enabled = false;


            }
        }

        private void chksoforplaka_CheckedChanged(object sender, EventArgs e)
        {
            if (chksoforplaka.Checked)
            {
                txtsoforplaka.Enabled = true;
                txtsoforplaka.Focus();
            }
            else
            {
                txtsoforplaka.Text = "";
                txtsoforplaka.Enabled = false;


            }
        }

        private void chkehliyetsinif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkehliyetsinif.Checked)
            {
                cmbsoforehliyetsinif.Enabled = true;
                cmbsoforehliyetsinif.Focus();
            }
            else
            {
                cmbsoforehliyetsinif.Text = "";
                cmbsoforehliyetsinif.Enabled = false;


            }
        }

        private void chkpersoneltc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpersoneltc.Checked)
            {
                txtpersoneltc.Enabled = true;
                txtpersoneltc.Focus();
            }
            else
            {
                txtpersoneltc.Text = "";
                txtpersoneltc.Enabled = false;


            }
        }

        private void chkpersonelbirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpersonelbirim.Checked)
            {
                cmbpersonelbirim.Enabled = true;
                cmbpersonelbirim.Focus();
            }
            else
            {
                cmbpersonelbirim.Text = "";
                cmbpersonelbirim.Enabled = false;


            }
        }

        private void chkkullaniciadi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkullaniciadi.Checked)
            {
                txtuyekullaniciadi.Enabled = true;
                txtuyekullaniciadi.Focus();
            }
            else
            {
                txtuyekullaniciadi.Text = "";
                txtuyekullaniciadi.Enabled = false;


            }
        }

        private void chkuyesifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkuyesifre.Checked)
            {
                txtuyesifre.Enabled = true;
                txtuyesifre.Focus();
            }
            else
            {
                txtuyesifre.Text = "";
                txtuyesifre.Enabled = false;


            }

        }

        private void chkuyemail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkuyemail.Checked)
            {
                txtuyemail.Enabled = true;
                txtuyemail.Focus();
            }
            else
            {
                txtuyemail.Text = "";
                txtuyemail.Enabled = false;


            }

        }

        private void chkyakitplaka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkyakitplaka.Checked)
            {
                txtyakitplaka.Enabled = true;
                txtyakitplaka.Focus();
            }
            else
            {
                txtyakitplaka.Text = "";
                txtyakitplaka.Enabled = false;


            }
        }

        private void chkyakittipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkyakittipi.Checked)
            {
                cmbyakittipi.Enabled = true;
                cmbyakittipi.Focus();
            }
            else
            {
                cmbyakittipi.Text = "";
                cmbyakittipi.Enabled = false;
            }
        }

        private void chkdepohacmi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdepohacmi.Checked)
            {
                cmbdepohacmi.Enabled = true;
                cmbdepohacmi.Focus();
            }
            else
            {
                cmbdepohacmi.Text = "";
                cmbdepohacmi.Enabled = false;
            }
        }

        public void CekiciKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguCekiciKayitAra = "select * from Trucks";
                string SorguCekiciKayitAraMarka = "Select * From Trucks where Marka='" + cmbcekicimarka.Text + "'";
                string SorguCekiciKayitAraModel = "Select * From Trucks where Model='" + txtcekicimodel.Text + "'";
                string SorguCekiciKayitAraPlaka = "Select * From Trucks where Plaka='" + txtcekiciplaka.Text + "'";

                string SorguMarkaModel = "Select * From Trucks where Marka='" + cmbcekicimarka.Text + "' And Model='" + txtcekicimodel.Text + "'";
                string SorguMarkaPlaka = "Select * From Trucks where Marka='" + cmbcekicimarka.Text + "' And Plaka='" + txtcekiciplaka.Text + "'";
                string SorguModelPlaka = "Select * From Trucks where Model='" + txtcekicimodel.Text + "' And Plaka='" + txtcekiciplaka.Text + "'";
                string SorguMarkaModelPlaka = "Select * From Trucks where Marka='" + cmbcekicimarka.Text + "' And Model='" + txtcekicimodel.Text + "'  And Plaka='" + txtcekiciplaka.Text + "'";
               
                if (chkmarka.Checked && chkmodel.Checked && chkplaka.Checked)
                    SorguCekiciKayitAra = SorguMarkaModelPlaka;
                else if (chkmarka.Checked && chkmodel.Checked)
                    SorguCekiciKayitAra = SorguMarkaModel;
                else if (chkmarka.Checked && chkplaka.Checked)
                    SorguCekiciKayitAra = SorguMarkaPlaka;
                else if (chkmodel.Checked && chkplaka.Checked)
                    SorguCekiciKayitAra = SorguModelPlaka;
                else if (chkmarka.Checked)
                    SorguCekiciKayitAra = SorguCekiciKayitAraMarka;
                else if (chkmodel.Checked)
                    SorguCekiciKayitAra = SorguCekiciKayitAraModel;
                else if (chkplaka.Checked)
                    SorguCekiciKayitAra = SorguCekiciKayitAraPlaka;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguCekiciKayitAra, Baglanti);
                da.Fill(ds, "Trucks");
                dataGridView1.DataSource = ds.Tables["Trucks"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            CekiciKayitAra();
        }


        public void CekiciVeriYukle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Select Marka from Trucks";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbcekicimarka.Items.Add(dr["Marka"]);
                }
                Tanimlamalar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        private void Tanimlamalar_Load(object sender, EventArgs e)
        {
            CekiciVeriYukle();
            DorseVeriYukleKullanimAlani();
            DorseVeriYukleBoy();
            DorseVeriYukleYukseklik();
            SoforVeriYukleEhliyetSınıf();

        }



        public void DorseKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguDorseKayitAra = "select * from Trailer";
                string SorguDorseKayitAraKullanımAlanı = "Select * From Trailer where KullimAlani='" + cmbdorsekullanimalani.Text + "'";
                string SorguDorseKayitAraBoy = "Select * From Trailer where Boy='" + cmbdorseboy.Text + "'";
                string SorguDorseKayitAraYukseklik = "Select * From Trailer where Yükseklik='" + cmbdorseyukselik.Text + "'";

                string SorguKullanımAlanıBoy = "Select * From Trailer where KullimAlani='" + cmbdorsekullanimalani.Text + "' And Boy='" + cmbdorseboy.Text + "'";
                string SorguKullanımAlanıYukseklik = "Select * From Trailer where KullimAlani='" + cmbdorsekullanimalani.Text + "' And Yükseklik='" + cmbdorseyukselik.Text + "'";
                string SorguBoyYukseklik = "Select * From Trailer where Boy='" + cmbdorseboy.Text + "' And Yükseklik='" + cmbdorseyukselik.Text + "'";
                string SorguKullanımAlanıBoyYukseklik = "Select * From Trailer where KullimAlani='" + cmbdorsekullanimalani.Text + "' And Boy='" + cmbdorseboy.Text + "'  And Yükseklik='" + cmbdorseyukselik.Text + "'";

                if (chkkullanimalani.Checked && chkboy.Checked && chkyukselik.Checked)
                    SorguDorseKayitAra = SorguDorseKayitAraYukseklik;
                else if (chkkullanimalani.Checked && chkboy.Checked)
                    SorguDorseKayitAra = SorguKullanımAlanıBoy;
                else if (chkkullanimalani.Checked && chkyukselik.Checked)
                    SorguDorseKayitAra = SorguBoyYukseklik;
                else if (chkboy.Checked && chkyukselik.Checked)
                    SorguDorseKayitAra = SorguBoyYukseklik;
                else if (chkkullanimalani.Checked)
                    SorguDorseKayitAra = SorguDorseKayitAraKullanımAlanı;
                else if (chkboy.Checked)
                    SorguDorseKayitAra = SorguDorseKayitAraBoy;
                else if (chkyukselik.Checked)
                    SorguDorseKayitAra = SorguDorseKayitAraYukseklik;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguDorseKayitAra, Baglanti);
                da.Fill(ds, "Trailer");
                dataGridView1.DataSource = ds.Tables["Trailer"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        public void DorseVeriYukleKullanimAlani()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Select KullimAlani from Trailer";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbdorsekullanimalani.Items.Add(dr["KullimAlani"]);
                }
                Tanimlamalar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        public void DorseVeriYukleBoy()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Select Boy from Trailer";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbdorseboy.Items.Add(dr["Boy"]);
                }
                Tanimlamalar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        public void DorseVeriYukleYukseklik()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Select Yükseklik from Trailer";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbdorseyukselik.Items.Add(dr["Yükseklik"]);
                }
                Tanimlamalar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        private void btnaradorse_Click(object sender, EventArgs e)
        {
            DorseKayitAra();
        }

        public void SoforKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguSoforKayitAra = "select * from Sofor";
                string SorguSoforKayitAraTcKimlik = "Select * From Sofor where TcKimlikNo='" + txtsofortc.Text + "'";
                string SorguSoforKayitAraPlaka = "Select * From Sofor where Plaka='" + txtsoforplaka.Text + "'";
                string SorguSoforKayitAraEhliyetSinif = "Select * From Sofor where EhliyetSinifi='" + cmbsoforehliyetsinif.Text + "'";

                string SorguTCNoPlaka = "Select * From Sofor where TcKimlikNo='" + txtsofortc.Text + "' And Plaka='" + txtsoforplaka.Text + "'";
                string SorguTCNoEhliyetSınıfı = "Select * From Sofor where TcKimlikNo='" + txtsofortc.Text + "' And EhliyetSinifi='" + cmbsoforehliyetsinif.Text + "'";
                string SorguPlakaEhliyetSınıfı = "Select * From Sofor where Plaka='" + txtsoforplaka.Text + "' And EhliyetSinifi='" + cmbsoforehliyetsinif.Text + "'";
                string SorguTCNoPlakaEhliyetSınıfı = "Select * From Sofor where TcKimlikNo='" + txtsofortc.Text + "' And Plaka='" + txtsoforplaka.Text + "'  And TcKimlikNo='" + txtsofortc.Text + "'";

                if (chksofortc.Checked && chkplaka.Checked && chkehliyetsinif.Checked)
                    SorguSoforKayitAra = SorguTCNoPlakaEhliyetSınıfı;
                else if (chksofortc.Checked && chkplaka.Checked)
                    SorguSoforKayitAra = SorguTCNoPlaka;
                else if (chksofortc.Checked && chkehliyetsinif.Checked)
                    SorguSoforKayitAra = SorguTCNoEhliyetSınıfı;
                else if (chkplaka.Checked && chkehliyetsinif.Checked)
                    SorguSoforKayitAra = SorguPlakaEhliyetSınıfı;
                else if (chksofortc.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraTcKimlik;
                else if (chksoforplaka.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraPlaka;
                else if (chkehliyetsinif.Checked)
                    SorguSoforKayitAra = SorguSoforKayitAraEhliyetSinif;


                OleDbDataAdapter da = new OleDbDataAdapter(SorguSoforKayitAra, Baglanti);
                da.Fill(ds, "Sofor");
                dataGridView1.DataSource = ds.Tables["Sofor"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        public void SoforVeriYukleEhliyetSınıf()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Select EhliyetSinifi from Sofor";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbsoforehliyetsinif.Items.Add(dr["EhliyetSinifi"]);
                }
                Tanimlamalar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        private void btnarasofor_Click(object sender, EventArgs e)
        {
            SoforKayitAra();
        }
    }
}

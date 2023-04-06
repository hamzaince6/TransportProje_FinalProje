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
    public partial class DorseEkle : Form
    {
        public DorseEkle()
        {
            InitializeComponent();
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
                string Sorgu = "Insert Into Trailer (KullimAlani,ModelYili,Renk,SasiNo,RuhsatNo,RuhsatVerilenYer,Netagirlik,Bayrak,YerliYabanci,HGSNo,Boy,En,Yükseklik,BosAgirlik) Values (@KullimAlani,@ModelYili,@Renk,@SasiNo,@RuhsatNo,@RuhsatVerilenYer,@Netagirlik,@Bayrak,@YerliYabanci,@HGSNo,@Boy,@En,@Yükseklik,@BosAgirlik)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@KullimAlani", cmbkullanimalani.Text);
                EkleKomut.Parameters.AddWithValue("@ModelYili", txtmodel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbrenk.Text);
                EkleKomut.Parameters.AddWithValue("@SasiNo", txtsasino.Text);
                EkleKomut.Parameters.AddWithValue("@RuhsatNo", txtruhsatno.Text);
                EkleKomut.Parameters.AddWithValue("@RusatVerilenYer", cmbruhsatverilenyer.Text);
                EkleKomut.Parameters.AddWithValue("@HGSNo", txthgsno.Text);
                EkleKomut.Parameters.AddWithValue("@Netagirlik", txtagirlik.Text);
                EkleKomut.Parameters.AddWithValue("@Bayrak", cmbbayrak.Text);
                EkleKomut.Parameters.AddWithValue("@En", cmben.Text);
                EkleKomut.Parameters.AddWithValue("@Boy", cmbboy.Text);
                EkleKomut.Parameters.AddWithValue("@Yükseklik", cmbyukseklik.Text);
                EkleKomut.Parameters.AddWithValue("@BosAgirlik", cmbbosagirlik.Text);
                if (radyerli.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@YerliYabanci", "Yerli");
                else if (radyabanci.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@YerliYabanci", "Yabanci");

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
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbkullanimalani.Text = "";
            txtmodel.Text = "";
            cmbrenk.Text = "";
            txtsasino.Text = "";
            txtruhsatno.Text = "";
            cmbruhsatverilenyer.Text = "";
            txthgsno.Text = "";
            txtagirlik.Text="";
            cmbbayrak.Text = "";
            cmben.Text = "";
            cmbboy.Text = "";
            cmbyukseklik.Text = "";
            cmbbosagirlik.Text = "";
            cmbkullanimalani.Focus();
        }



        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            cmbkullanimalani.BackColor = Color.White;
            txtmodel.BackColor = Color.White;
            cmbrenk.BackColor = Color.White;
            txtsasino.BackColor = Color.White;
            txtruhsatno.BackColor = Color.White;
            cmbruhsatverilenyer.BackColor = Color.White;
            txthgsno.BackColor = Color.White;
            txtagirlik.BackColor = Color.White;
            cmbbayrak.BackColor = Color.White;
            cmben.BackColor = Color.White;
            cmbboy.BackColor = Color.White;
            cmbyukseklik.BackColor = Color.White;
            cmbbosagirlik.BackColor = Color.White;

            if (cmbkullanimalani.Text == "Kullanım Alanı Seçiniz" || cmbkullanimalani.Text == "")
            {
                cmbkullanimalani.BackColor = Color.DarkRed;
                cmbkullanimalani.Focus();
                bos = true;

            }

            if (cmbbayrak.Text == "Bayrak Seçiniz" || cmbbayrak.Text == "")
            {
                cmbbayrak.BackColor = Color.DarkRed;
                cmbbayrak.Focus();
                bos = true;

            }

            if (cmbrenk.Text == "Renk Seçiniz" || cmbrenk.Text == "")
            {
                cmbrenk.BackColor = Color.DarkRed;
                cmbrenk.Focus();
                bos = true;
            }

            if (cmbruhsatverilenyer.Text == "Ruhsat Verilen Yer Seçiniz" || cmbruhsatverilenyer.Text == "")
            {
                cmbruhsatverilenyer.BackColor = Color.DarkRed;
                cmbruhsatverilenyer.Focus();
                bos = true;
            }

            if (cmben.Text == "En Seçiniz" || cmben.Text == "")
            {
                cmben.BackColor = Color.DarkRed;
                cmben.Focus();
                bos = true;
            }

            if (cmbboy.Text == "Boy Seçiniz" || cmbboy.Text == "")
            {
                cmbboy.BackColor = Color.DarkRed;
                cmbboy.Focus();
                bos = true;
            }

            if (cmbyukseklik.Text == "Yükseklik Seçiniz" || cmbyukseklik.Text == "")
            {
                cmbyukseklik.BackColor = Color.DarkRed;
                cmbyukseklik.Focus();
                bos = true;
            }

            if (cmbbosagirlik.Text == "Boş Ağırlık Seçiniz" || cmbbosagirlik.Text == "")
            {
                cmbbosagirlik.BackColor = Color.DarkRed;
                cmbbosagirlik.Focus();
                bos = true;
            }

            if (txtmodel.Text == "")
            {
                txtmodel.BackColor = Color.DarkRed;
                txtmodel.Focus();
                bos = true;

            }

            if (txthgsno.Text == "")
            {
                txthgsno.BackColor = Color.DarkRed;
                txthgsno.Focus();
                bos = true;

            }

            if (txtsasino.Text == "")
            {
                txtsasino.BackColor = Color.DarkRed;
                txtsasino.Focus();
                bos = true;

            }

            if (txtruhsatno.Text == "")
            {
                txtruhsatno.BackColor = Color.DarkRed;
                txtruhsatno.Focus();
                bos = true;

            }


            if (radyerli.Checked == false && radyabanci.Checked == false)
            {
                radyerli.BackColor = Color.DarkRed;
                radyabanci.BackColor = Color.DarkRed;
                bos = true;
            }



            return bos;

        }


    }
}

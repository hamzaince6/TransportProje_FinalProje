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
    public partial class DorseGuncelle : Form
    {
        public DorseGuncelle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayıtDegistir();
        }

        public void KayıtDegistir()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Update Trailer Set KullimAlani=@KullimAlani,ModelYili=@ModelYili,Renk=@Renk,SasiNo=@SasiNo,RuhsatNo=@RuhsatNo,RuhsatVerilenYer=@RuhsatVerilenYer,Netagirlik=@Netagirlik,Bayrak=@Bayrak,YerliYabanci=@YerliYabanci,HGSNo=@HGSNo,Boy=@Boy,En=@En,Yükseklik=@Yükseklik,BosAgirlik=@BosAgirlik where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@KullimAlani", cmbkullanimalani.Text);
                DegistirKomut.Parameters.AddWithValue("@ModelYili", txtmodel.Text);
                DegistirKomut.Parameters.AddWithValue("@Renk", cmbrenk.Text);
                DegistirKomut.Parameters.AddWithValue("@SasiNo", txtsasino.Text);
                DegistirKomut.Parameters.AddWithValue("@RuhsatNo", txtruhsatno.Text);
                DegistirKomut.Parameters.AddWithValue("@RuhsatVerilenYer", cmbruhsatverilenyer.Text);
                DegistirKomut.Parameters.AddWithValue("@Netagirlik", txtagirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@Bayrak", cmbbayrak.Text);
                if (radyerli.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@YerliYabanci", "Yerli");
                else if (radyabanci.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@YerliYabanci", "Yabanci");
                DegistirKomut.Parameters.AddWithValue("@HGSNo", txthgsno.Text);
                DegistirKomut.Parameters.AddWithValue("@Boy", cmbboy.Text);
                DegistirKomut.Parameters.AddWithValue("@En", cmben.Text);
                DegistirKomut.Parameters.AddWithValue("@Yükseklik", cmbyukseklik.Text);
                DegistirKomut.Parameters.AddWithValue("@BosAgirlik", cmbbosagirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbkullanimalani.Text + "" + txtmodel.Text + "isimli kayıt Değiştirildi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir Hata Penceresi");
            }
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

            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
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

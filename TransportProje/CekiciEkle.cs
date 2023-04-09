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
    public partial class CekiciEkle : Form
    {
        public CekiciEkle()
        {
            InitializeComponent();
        }
        // Çekici Kayıt Ekleme
        public void KayitEkle()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Insert Into Trucks (Marka,Model,Renk,UretimYili,Vites,KM,Yakit,Plaka,AracinPiyasaDegeri,MotorluT_Vergisi,HGSNo,SasiNo,MotorNo,DepoHacmi,RuhsatNo,RusatVerilenYer,Netagirlik,MotorGucu,Bayrak,YerliYabancı) Values (@Marka,@Model,@Renk,@UretimYili,@Vites,@KM,@Yakit,@Plaka,@AracinPiyasaDegeri,@MotorluT_Vergisi,@HGSNo,@SasiNo,@MotorNo,@DepoHacmi,@RuhsatNo,@RusatVerilenYer,@Netagirlik,@MotorGucu,@Bayrak,@YerliYabancı)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Marka", cmbmarka.Text);
                EkleKomut.Parameters.AddWithValue("@Model", txtmodel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbrenk.Text);
                EkleKomut.Parameters.AddWithValue("@UretimYili", txturetimyili.Text);
                EkleKomut.Parameters.AddWithValue("@Vites", cmbvites.Text);
                EkleKomut.Parameters.AddWithValue("@KM", txtkm.Text);
                EkleKomut.Parameters.AddWithValue("@Yakit", cmbyakit.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                EkleKomut.Parameters.AddWithValue("@AracinPiyasaDegeri", txtaracdegeri.Text);
                EkleKomut.Parameters.AddWithValue("@MotorluT_Vergisi", txtmtvverisi.Text);
                EkleKomut.Parameters.AddWithValue("@HGSNo", txthgsno.Text);
                EkleKomut.Parameters.AddWithValue("@SasiNo", txtsasino.Text);
                EkleKomut.Parameters.AddWithValue("@MotorNo", txtmotorno.Text);
                EkleKomut.Parameters.AddWithValue("@DepoHacmi", cmbdepohacmi.Text);
                EkleKomut.Parameters.AddWithValue("@RuhsatNo", txtruhsatno.Text);
                EkleKomut.Parameters.AddWithValue("@RusatVerilenYer", cmbruhsatverilenyer.Text);
                EkleKomut.Parameters.AddWithValue("@NetAgirlik", txtnetagirlik.Text);
                EkleKomut.Parameters.AddWithValue("@MotorGucu", cmbmotorgucu.Text);
                EkleKomut.Parameters.AddWithValue("@Bayrak", cmbplaka.Text);
                if (radyerli.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Bayrak", "Yerli");
                else if (radyabanci.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Bayrak", "Yabanci");

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Başarıyla Kayıt Eklendi");
                Tanimlamalar.Baglanti.Close();
                
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }

        private static void BaglantiAc()
        {
            throw new NotImplementedException();
        }
        // Kaydetme Butonu
        private void button1_Click(object sender, EventArgs e) 
        {

            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayitEkle();
           
        }
        // Geri Dönme Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }
        // Temizleme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            cmbmarka.Text = "";
            txtmodel.Text = "";
            cmbrenk.Text = "";
            txturetimyili.Text = "";
            cmbvites.Text = "";
            txtkm.Text = "";
            cmbyakit.Text = "";
            txtplaka.Text = "";
            txtaracdegeri.Text = "";
            txtmtvverisi.Text = "";
            txthgsno.Text = "";
            txtsasino.Text = "";
            txtmotorno.Text = "";
            cmbdepohacmi.Text = "";
            txtruhsatno.Text = "";
            cmbruhsatverilenyer.Text = "";
            txtnetagirlik.Text = "";
            cmbmotorgucu.Text = "";
            cmbplaka.Text = "";
            cmbmarka.Focus();
        }
        // Boşluk Kontrol
        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            cmbmarka.BackColor = Color.White;
            txtmodel.BackColor = Color.White;
            cmbrenk.BackColor = Color.White;
            txturetimyili.BackColor = Color.White;
            cmbvites.BackColor = Color.White;
            txtkm.BackColor = Color.White;
            cmbyakit.BackColor = Color.White;
            txtplaka.BackColor = Color.White;
            txtaracdegeri.BackColor = Color.White;
            txtmtvverisi.BackColor = Color.White;
            txthgsno.BackColor = Color.White;
            txtsasino.BackColor = Color.White;
            txtmotorno.BackColor = Color.White;
            cmbdepohacmi.BackColor = Color.White;
            txtruhsatno.BackColor = Color.White;
            cmbruhsatverilenyer.BackColor = Color.White;
            txtnetagirlik.BackColor = Color.White;
            cmbmotorgucu.BackColor = Color.White;
            cmbplaka.BackColor = Color.White;


            if (cmbmarka.Text == "Marka Seçiniz" || cmbmarka.Text == "")
            {
                cmbmarka.BackColor = Color.DarkRed;
                cmbmarka.Focus();
                bos = true;

            }

            if (cmbplaka.Text == "Bayrak Seçiniz" || cmbplaka.Text == "")
            {
                cmbplaka.BackColor = Color.DarkRed;
                cmbplaka.Focus();
                bos = true;

            }


            if (cmbrenk.Text == "Renk Seçiniz" || cmbrenk.Text == "")
            {
                cmbrenk.BackColor = Color.DarkRed;
                cmbrenk.Focus();
                bos = true;
            }

            if (cmbmotorgucu.Text == "Motor Gücü Seçiniz" || cmbmotorgucu.Text == "")
            {
                cmbmotorgucu.BackColor = Color.DarkRed;
                cmbmotorgucu.Focus();
                bos = true;
            }

            if (txturetimyili.Text == "")
            {
                txturetimyili.BackColor = Color.DarkRed;
                txturetimyili.Focus();
                bos = true;

            }

            if (cmbvites.Text == "Vites Seçiniz" || cmbvites.Text == "")
            {
                cmbvites.BackColor = Color.DarkRed;
                cmbvites.Focus();
                bos = true;
            }

            if (cmbdepohacmi.Text == "Depo Hacmi Seçiniz" || cmbdepohacmi.Text == "")
            {
                cmbdepohacmi.BackColor = Color.DarkRed;
                cmbdepohacmi.Focus();
                bos = true;
            }

            if (cmbruhsatverilenyer.Text == "Ruhsat Verilen Yer Seçiniz" || cmbruhsatverilenyer.Text == "")
            {
                cmbruhsatverilenyer.BackColor = Color.DarkRed;
                cmbruhsatverilenyer.Focus();
                bos = true;
            }

            if (cmbyakit.Text == "Yakıt Seçiniz" || cmbyakit.Text == "")
            {
                cmbyakit.BackColor = Color.DarkRed;
                cmbyakit.Focus();
                bos = true;
            }

            if (txtmodel.Text == "")
            {
                txtmodel.BackColor = Color.DarkRed;
                txtmodel.Focus();
                bos = true;

            }

            if (txtkm.Text == "")
            {
                txtkm.BackColor = Color.DarkRed;
                txtkm.Focus();
                bos = true;

            }

            if (txtplaka.Text == "")
            {
                txtplaka.BackColor = Color.DarkRed;
                txtplaka.Focus();
                bos = true;

            }

            if (txtaracdegeri.Text == "")
            {
                txtaracdegeri.BackColor = Color.DarkRed;
                txtaracdegeri.Focus();
                bos = true;

            }

            if (txtmtvverisi.Text == "")
            {
                txtmtvverisi.BackColor = Color.DarkRed;
                txtmtvverisi.Focus();
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

            if (txtmotorno.Text == "")
            {
                txtmotorno.BackColor = Color.DarkRed;
                txtmotorno.Focus();
                bos = true;

            }

            if (txtruhsatno.Text == "")
            {
                txtruhsatno.BackColor = Color.DarkRed;
                txtruhsatno.Focus();
                bos = true;

            }

            if (txtnetagirlik.Text == "")
            {
                txtnetagirlik.BackColor = Color.DarkRed;
                txtnetagirlik.Focus();
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

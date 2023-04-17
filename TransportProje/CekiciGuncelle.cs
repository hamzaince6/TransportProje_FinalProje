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
    public partial class CekiciGuncelle : Form
    {
        public CekiciGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Update Trucks Set Marka=@Marka,Model=@Model,Renk=@Renk,UretimYili=@UretimYili,Vites=@Vites,KM=@KM,Yakit=@Yakit,Plaka=@Plaka,AracinPiyasaDegeri=@AracinPiyasaDegeri,MotorluT_Vergisi=@MotorluT_Vergisi,HGSNo=@HGSNo,SasiNo=@SasiNo,MotorNo=@MotorNo,DepoHacmi=@DepoHacmi,RuhsatNo=@RuhsatNo,RusatVerilenYer=@RusatVerilenYer,NetAgirlik=@NetAgirlik,MotorGucu=@MotorGucu,Bayrak=@Bayrak,YerliYabancı=@YerliYabancı where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Marka", cmbmarka.Text);
                DegistirKomut.Parameters.AddWithValue("@Model", txtmodel.Text);
                DegistirKomut.Parameters.AddWithValue("@Renk", cmbrenk.Text);
                DegistirKomut.Parameters.AddWithValue("@UretimYili", txturetimyili.Text);
                DegistirKomut.Parameters.AddWithValue("@Vites", cmbvites.Text);
                DegistirKomut.Parameters.AddWithValue("@KM", txtkm.Text);
                DegistirKomut.Parameters.AddWithValue("@Yakit", cmbyakit.Text);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                DegistirKomut.Parameters.AddWithValue("@AracinPiyasaDegeri", txtaracdegeri.Text);
                DegistirKomut.Parameters.AddWithValue("@MotorluT_Vergisi", txtmtvverisi.Text);
                DegistirKomut.Parameters.AddWithValue("@HGSNo", txthgsno.Text);
                DegistirKomut.Parameters.AddWithValue("@SasiNo", txtsasino.Text);
                DegistirKomut.Parameters.AddWithValue("@MotorNo", txtmotorno.Text);
                DegistirKomut.Parameters.AddWithValue("@DepoHacmi", cmbdepohacmi.Text);
                DegistirKomut.Parameters.AddWithValue("@RuhsatNo", txtruhsatno.Text);
                DegistirKomut.Parameters.AddWithValue("@RusatVerilenYer", cmbruhsatverilenyer.Text);
                DegistirKomut.Parameters.AddWithValue("@NetAgirlik", txtnetagirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@MotorGucu", cmbmotorgucu.Text);
                DegistirKomut.Parameters.AddWithValue("@Bayrak", cmbplaka.Text);
                if (radyerli.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Bayrak", "Yerli");
                else if (radyabanci.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Bayrak", "Yabanci");
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbmarka.Text + "" + txtmodel.Text + "isimli kayıt Değiştirildi");
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
            txtid.BackColor = Color.White;
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

            if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "Dikkat");
            else
                KayıtDegistir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanimlamalar frmgeri = new Tanimlamalar();
            frmgeri.Show();
            this.Hide();
        }
    }
}

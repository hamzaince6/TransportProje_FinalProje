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
                string Sorgu = "Update Trailer Set Marka=@Marka,Model=@Model,Renk=@Renk,UretimYili=@UretimYili,Vites=@Vites,KM=@KM,Yakit=@Yakit,Plaka=@Plaka,AracinPiyasaDegeri=@AracinPiyasaDegeri,MotorluT_Vergisi=@MotorluT_Vergisi,HGSNo=@HGSNo,SasiNo=@SasiNo,MotorNo=@MotorNo,DepoHacmi=@DepoHacmi,RuhsatNo=@RuhsatNo,RusatVerilenYer=@RusatVerilenYer,NetAgirlik=@NetAgirlik,MotorGucu=@MotorGucu,Bayrak=@Bayrak,YerliYabancı=@YerliYabancı where Kimlik=@Kimlik";
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
                    MessageBox.Show(cmbmarka.Text + "" + txtmodel.Text + "isimli kayıt Değiştirildi");
                Tanimlamalar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir Hata Penceresi");
            }
        }








    }

   


}

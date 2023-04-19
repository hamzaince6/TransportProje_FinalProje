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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
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

        public void KayıtDegistir()
        {
            try
            {
                Tanimlamalar.BaglantiAc();
                string Sorgu = "Update Personel Set Adı=@Adı,Soyadı=@Soyadı,TcNo=@TcNo,Cinsiyet=@Cinsiyet,Adres=@Adres,Telefon=@Telefon,OgrenimDurumu=@OgrenimDurumu,Birimi=@Birimi,ibanBilgisi=@ibanBilgisi,Maas=@Maas,Prim=@Prim,Avans=@Avans,CalismaYili=@CalismaYili,IseBaslamaTarihi=@IseBaslamaTarihi,AyrilmaTarihi=@AyrilmaTarihi,AyrilmaNedeni=@AyrilmaNedeni where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Tanimlamalar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Adı", txtad.Text);
                DegistirKomut.Parameters.AddWithValue("@Soyadı", txtsoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@TcNo", txttc.Text);
                if (raderkek.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radkadin.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Kadin");
                DegistirKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                DegistirKomut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                DegistirKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbogrenimdurumu.Text);
                DegistirKomut.Parameters.AddWithValue("@Birimi", cmbbirim.Text);
                DegistirKomut.Parameters.AddWithValue("@ibanBilgisi", txtiban.Text);
                DegistirKomut.Parameters.AddWithValue("@Maas", txtmaas.Text);
                DegistirKomut.Parameters.AddWithValue("@Prim", txtprim.Text);
                DegistirKomut.Parameters.AddWithValue("@Avans", txtavans.Text);
                DegistirKomut.Parameters.AddWithValue("@CalismaYili", txtcalisma.Text);
                DegistirKomut.Parameters.AddWithValue("@IseBaslamaTarihi", txtbaslama.Text);
                DegistirKomut.Parameters.AddWithValue("@AyrilmaTarihi", txtayrilmatarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@AyrilmaNedeni", txtayrilma.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtid.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtad.Text + "" + txtsoyad.Text + "isimli kayıt Değiştirildi");
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
            txtad.BackColor = Color.White;
            txtsoyad.BackColor = Color.White;
            txttc.BackColor = Color.White;
            txtadres.BackColor = Color.White;
            txttelefon.BackColor = Color.White;
            cmbogrenimdurumu.BackColor = Color.White;
            cmbbirim.BackColor = Color.White;
            txtiban.BackColor = Color.White;
            txtmaas.BackColor = Color.White;
            txtprim.BackColor = Color.White;
            txtavans.BackColor = Color.White;
            txtcalisma.BackColor = Color.White;
            txtbaslama.BackColor = Color.White;


            if (cmbogrenimdurumu.Text == "Öğrenim Durumu Seçiniz" || cmbogrenimdurumu.Text == "")
            {
                cmbogrenimdurumu.BackColor = Color.DarkRed;
                cmbogrenimdurumu.Focus();
                bos = true;

            }

            if (cmbbirim.Text == "Birim Seçiniz" || cmbbirim.Text == "")
            {
                cmbbirim.BackColor = Color.DarkRed;
                cmbbirim.Focus();
                bos = true;

            }

            if (txtad.Text == "")
            {
                txtad.BackColor = Color.DarkRed;
                txtad.Focus();
                bos = true;

            }

              if (txtid.Text == "")
            {
                txtid.BackColor = Color.DarkRed;
                txtid.Focus();
                bos = true;

            }

            if (txtsoyad.Text == "")
            {
                txtsoyad.BackColor = Color.DarkRed;
                txtsoyad.Focus();
                bos = true;

            }

            if (txttc.Text == "")
            {
                txttc.BackColor = Color.DarkRed;
                txttc.Focus();
                bos = true;

            }

            if (txtadres.Text == "")
            {
                txtadres.BackColor = Color.DarkRed;
                txtadres.Focus();
                bos = true;

            }

            if (txttelefon.Text == "")
            {
                txttelefon.BackColor = Color.DarkRed;
                txttelefon.Focus();
                bos = true;

            }

            if (txtiban.Text == "")
            {
                txtiban.BackColor = Color.DarkRed;
                txtiban.Focus();
                bos = true;

            }

            if (txtmaas.Text == "")
            {
                txtmaas.BackColor = Color.DarkRed;
                txtmaas.Focus();
                bos = true;

            }


            if (txtprim.Text == "")
            {
                txtprim.BackColor = Color.DarkRed;
                txtprim.Focus();
                bos = true;

            }

            if (txtavans.Text == "")
            {
                txtavans.BackColor = Color.DarkRed;
                txtavans.Focus();
                bos = true;

            }

            if (txtcalisma.Text == "")
            {
                txtcalisma.BackColor = Color.DarkRed;
                txtcalisma.Focus();
                bos = true;

            }

            if (txtbaslama.Text == "")
            {
                txtbaslama.BackColor = Color.DarkRed;
                txtbaslama.Focus();
                bos = true;

            }
            return bos;

        }

























    }
}

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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Data.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
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

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullanici.Text=="" && txtmail.Text=="" && txtsifre.Text=="" && txtsifretekrar.Text=="")
            {
                MessageBox.Show("Eksik Bilgileri Doldurunuz","Kayıt Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (txtsifre.Text == txtsifretekrar.Text)
            {
                con.Open();
                string kayitol = "INSERT INTO Giris (Kullaniciadi,Sifre,Mail) VALUES ('" + txtkullanici.Text+"','"+txtsifre.Text+"','"+txtmail.Text+"')";
                cmd = new OleDbCommand(kayitol,con);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Hesabınız Başarıyla Oluşturulmuştur","Kayıt Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre Hatalı Ayni Şifreyi Yazdığınızdan Emin Olun","Kayıt Hatası",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtsifre.Text = "";
                txtsifretekrar.Text = "";
                txtsifre.Focus();
            }
        }


        public int ıd { get; set; }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsifre.PasswordChar = '\0';
                txtsifretekrar.PasswordChar = '\0';
            }
            else
            {
                txtsifre.PasswordChar = '*';
                txtsifretekrar.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show();
            this.Hide();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}

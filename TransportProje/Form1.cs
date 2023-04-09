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
    public partial class Login : Form
    {
        

        public Login() 
        {
            InitializeComponent();
           
        }
        // Database Tanımlama 
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Data.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        // Programdan Çıkma Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan Çıkamak İstiyor musunuz ? ","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialogResult==DialogResult.Yes)
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
        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtkullanici.Text=="username")
            {
                txtkullanici.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtkullanici.Text=="")
            {
                txtkullanici.Text = "username";

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtsifre.Text=="password")
            {
                txtsifre.Text = "";
                txtsifre.PasswordChar = '*';
            }
        }


        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtsifre.Text=="")
            {
                txtsifre.Text = "password";
                txtsifre.PasswordChar = Convert.ToChar(none);
            }
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string login = "SELECT * FROM Giris WHERE Kullaniciadi='" + txtkullanici.Text + "'and Sifre='"+txtsifre.Text+"'";
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read()==true)
            {
                new Main().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Şifre Hatalı Tekrar Deneyin","Giriş Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtkullanici.Text = "";
                txtsifre.Text = "";
                txtkullanici.Focus();

            }

        }

        private void txtkullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl frm1 = new KayitOl();
            frm1.Show();
            this.Hide();
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            if (txtsifre.Text == "password")
            {
                txtsifre.Text = "";
                txtsifre.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}

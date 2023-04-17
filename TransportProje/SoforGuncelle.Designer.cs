
namespace TransportProje
{
    partial class SoforGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txttakografno = new System.Windows.Forms.MaskedTextBox();
            this.txtpiskono = new System.Windows.Forms.MaskedTextBox();
            this.txtsrcno = new System.Windows.Forms.MaskedTextBox();
            this.txtehiletno = new System.Windows.Forms.MaskedTextBox();
            this.cmbehliyetsinif = new System.Windows.Forms.ComboBox();
            this.cmbogrenimdurumu = new System.Windows.Forms.ComboBox();
            this.txttelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtayrilmanedeni = new System.Windows.Forms.TextBox();
            this.txtayrilma = new System.Windows.Forms.MaskedTextBox();
            this.txtbaslama = new System.Windows.Forms.MaskedTextBox();
            this.txttckimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(200, 181);
            this.txtplaka.MaxLength = 8;
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(166, 20);
            this.txtplaka.TabIndex = 79;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(552, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 76;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttakografno
            // 
            this.txttakografno.Location = new System.Drawing.Point(577, 194);
            this.txttakografno.Mask = "000000000";
            this.txttakografno.Name = "txttakografno";
            this.txttakografno.Size = new System.Drawing.Size(165, 20);
            this.txttakografno.TabIndex = 75;
            this.txttakografno.ValidatingType = typeof(int);
            // 
            // txtpiskono
            // 
            this.txtpiskono.Location = new System.Drawing.Point(577, 158);
            this.txtpiskono.Mask = "000000000";
            this.txtpiskono.Name = "txtpiskono";
            this.txtpiskono.Size = new System.Drawing.Size(165, 20);
            this.txtpiskono.TabIndex = 74;
            this.txtpiskono.ValidatingType = typeof(int);
            // 
            // txtsrcno
            // 
            this.txtsrcno.Location = new System.Drawing.Point(577, 122);
            this.txtsrcno.Mask = "000000000";
            this.txtsrcno.Name = "txtsrcno";
            this.txtsrcno.Size = new System.Drawing.Size(165, 20);
            this.txtsrcno.TabIndex = 73;
            this.txtsrcno.ValidatingType = typeof(int);
            // 
            // txtehiletno
            // 
            this.txtehiletno.Location = new System.Drawing.Point(577, 86);
            this.txtehiletno.Mask = "000000000";
            this.txtehiletno.Name = "txtehiletno";
            this.txtehiletno.Size = new System.Drawing.Size(165, 20);
            this.txtehiletno.TabIndex = 72;
            this.txtehiletno.ValidatingType = typeof(int);
            // 
            // cmbehliyetsinif
            // 
            this.cmbehliyetsinif.FormattingEnabled = true;
            this.cmbehliyetsinif.Items.AddRange(new object[] {
            "A",
            "C1",
            "C",
            "D1",
            "D",
            "BE",
            "CE",
            "C1E",
            "DE",
            "D1E",
            "M",
            "B1",
            "B",
            "A1",
            "A2",
            "F",
            "G"});
            this.cmbehliyetsinif.Location = new System.Drawing.Point(577, 49);
            this.cmbehliyetsinif.Name = "cmbehliyetsinif";
            this.cmbehliyetsinif.Size = new System.Drawing.Size(165, 21);
            this.cmbehliyetsinif.TabIndex = 71;
            this.cmbehliyetsinif.Text = "Ehliyet Sınıfı Seçiniz";
            // 
            // cmbogrenimdurumu
            // 
            this.cmbogrenimdurumu.FormattingEnabled = true;
            this.cmbogrenimdurumu.Items.AddRange(new object[] {
            "İlkokul ",
            "Ortaokul ",
            "Lise ",
            "Önlisans",
            "Lisans ",
            "Yüksek Lisans"});
            this.cmbogrenimdurumu.Location = new System.Drawing.Point(200, 453);
            this.cmbogrenimdurumu.Name = "cmbogrenimdurumu";
            this.cmbogrenimdurumu.Size = new System.Drawing.Size(166, 21);
            this.cmbogrenimdurumu.TabIndex = 70;
            this.cmbogrenimdurumu.Text = "Öğrenim Durumu Seçiniz";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(200, 418);
            this.txttelefon.Mask = "(999) 000-0000";
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(166, 20);
            this.txttelefon.TabIndex = 69;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(200, 382);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(166, 20);
            this.txtadres.TabIndex = 68;
            // 
            // txtayrilmanedeni
            // 
            this.txtayrilmanedeni.Location = new System.Drawing.Point(200, 289);
            this.txtayrilmanedeni.Multiline = true;
            this.txtayrilmanedeni.Name = "txtayrilmanedeni";
            this.txtayrilmanedeni.Size = new System.Drawing.Size(166, 78);
            this.txtayrilmanedeni.TabIndex = 67;
            // 
            // txtayrilma
            // 
            this.txtayrilma.Location = new System.Drawing.Point(200, 253);
            this.txtayrilma.Mask = "00/00/0000";
            this.txtayrilma.Name = "txtayrilma";
            this.txtayrilma.Size = new System.Drawing.Size(166, 20);
            this.txtayrilma.TabIndex = 66;
            this.txtayrilma.ValidatingType = typeof(System.DateTime);
            // 
            // txtbaslama
            // 
            this.txtbaslama.Location = new System.Drawing.Point(200, 217);
            this.txtbaslama.Mask = "00/00/0000";
            this.txtbaslama.Name = "txtbaslama";
            this.txtbaslama.Size = new System.Drawing.Size(166, 20);
            this.txtbaslama.TabIndex = 65;
            this.txtbaslama.ValidatingType = typeof(System.DateTime);
            // 
            // txttckimlik
            // 
            this.txttckimlik.Location = new System.Drawing.Point(200, 148);
            this.txttckimlik.Mask = "00000000000";
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(166, 20);
            this.txttckimlik.TabIndex = 64;
            this.txttckimlik.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(200, 109);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(166, 20);
            this.txtsoyad.TabIndex = 63;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(200, 74);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(166, 20);
            this.txtad.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(455, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Takograf No ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(455, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Pisko Test No ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(455, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "SRC No ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(455, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 18);
            this.label15.TabIndex = 50;
            this.label15.Text = "Ehliyet Sinifi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(455, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ehliyet No ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(42, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Öğrenim Durumu ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(42, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(42, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(42, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ayrılma Nedeni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(42, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ayrılma Tarihi ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(42, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "İşe Başlama Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(42, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tc Kimlik No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Adı ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(45, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 24);
            this.label21.TabIndex = 46;
            this.label21.Text = "Soför Güncelle";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(200, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(166, 20);
            this.txtid.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(46, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 18);
            this.label16.TabIndex = 80;
            this.label16.Text = "İd";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(658, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 82;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SoforGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txttakografno);
            this.Controls.Add(this.txtpiskono);
            this.Controls.Add(this.txtsrcno);
            this.Controls.Add(this.txtehiletno);
            this.Controls.Add(this.cmbehliyetsinif);
            this.Controls.Add(this.cmbogrenimdurumu);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtayrilmanedeni);
            this.Controls.Add(this.txtayrilma);
            this.Controls.Add(this.txtbaslama);
            this.Controls.Add(this.txttckimlik);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoforGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoforGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.MaskedTextBox txtid;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtplaka;
        public System.Windows.Forms.MaskedTextBox txttakografno;
        public System.Windows.Forms.MaskedTextBox txtpiskono;
        public System.Windows.Forms.MaskedTextBox txtsrcno;
        public System.Windows.Forms.MaskedTextBox txtehiletno;
        public System.Windows.Forms.ComboBox cmbehliyetsinif;
        public System.Windows.Forms.ComboBox cmbogrenimdurumu;
        public System.Windows.Forms.MaskedTextBox txttelefon;
        public System.Windows.Forms.TextBox txtadres;
        public System.Windows.Forms.TextBox txtayrilmanedeni;
        public System.Windows.Forms.MaskedTextBox txtayrilma;
        public System.Windows.Forms.MaskedTextBox txtbaslama;
        public System.Windows.Forms.MaskedTextBox txttckimlik;
        public System.Windows.Forms.MaskedTextBox txtsoyad;
        public System.Windows.Forms.MaskedTextBox txtad;
        private System.Windows.Forms.Button button1;
    }
}
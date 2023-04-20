
namespace TransportProje
{
    partial class SatisFaturaGuncelle
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
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.cmbkdvorani = new System.Windows.Forms.ComboBox();
            this.txttltutar = new System.Windows.Forms.MaskedTextBox();
            this.txtdoviztutar = new System.Windows.Forms.MaskedTextBox();
            this.txtfiyat = new System.Windows.Forms.MaskedTextBox();
            this.cmbfaturaturu = new System.Windows.Forms.ComboBox();
            this.txtmustertitemsilci = new System.Windows.Forms.MaskedTextBox();
            this.txtvadetarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtfaturatarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbdovizturu = new System.Windows.Forms.ComboBox();
            this.txtmusteri = new System.Windows.Forms.MaskedTextBox();
            this.txtbelgeno = new System.Windows.Forms.MaskedTextBox();
            this.txtfaturano = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(188, 554);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(235, 61);
            this.txtaciklama.TabIndex = 54;
            // 
            // cmbkdvorani
            // 
            this.cmbkdvorani.FormattingEnabled = true;
            this.cmbkdvorani.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.cmbkdvorani.Location = new System.Drawing.Point(188, 513);
            this.cmbkdvorani.Name = "cmbkdvorani";
            this.cmbkdvorani.Size = new System.Drawing.Size(235, 21);
            this.cmbkdvorani.TabIndex = 53;
            this.cmbkdvorani.Text = "KDV Oranı Seçiniz";
            // 
            // txttltutar
            // 
            this.txttltutar.Location = new System.Drawing.Point(188, 474);
            this.txttltutar.Mask = "0000000";
            this.txttltutar.Name = "txttltutar";
            this.txttltutar.Size = new System.Drawing.Size(235, 20);
            this.txttltutar.TabIndex = 52;
            this.txttltutar.ValidatingType = typeof(int);
            // 
            // txtdoviztutar
            // 
            this.txtdoviztutar.Location = new System.Drawing.Point(188, 435);
            this.txtdoviztutar.Mask = "0000000";
            this.txtdoviztutar.Name = "txtdoviztutar";
            this.txtdoviztutar.Size = new System.Drawing.Size(235, 20);
            this.txtdoviztutar.TabIndex = 51;
            this.txtdoviztutar.ValidatingType = typeof(int);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(188, 394);
            this.txtfiyat.Mask = "0000000";
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(235, 20);
            this.txtfiyat.TabIndex = 50;
            this.txtfiyat.ValidatingType = typeof(int);
            // 
            // cmbfaturaturu
            // 
            this.cmbfaturaturu.FormattingEnabled = true;
            this.cmbfaturaturu.Items.AddRange(new object[] {
            "Kara İthaalat Faturası",
            "Kara İhraacat Faturası"});
            this.cmbfaturaturu.Location = new System.Drawing.Point(188, 353);
            this.cmbfaturaturu.Name = "cmbfaturaturu";
            this.cmbfaturaturu.Size = new System.Drawing.Size(235, 21);
            this.cmbfaturaturu.TabIndex = 49;
            this.cmbfaturaturu.Text = "Fatura Türünü Seçiniz";
            // 
            // txtmustertitemsilci
            // 
            this.txtmustertitemsilci.Location = new System.Drawing.Point(188, 314);
            this.txtmustertitemsilci.Name = "txtmustertitemsilci";
            this.txtmustertitemsilci.Size = new System.Drawing.Size(235, 20);
            this.txtmustertitemsilci.TabIndex = 48;
            // 
            // txtvadetarihi
            // 
            this.txtvadetarihi.Location = new System.Drawing.Point(188, 277);
            this.txtvadetarihi.Mask = "00/00/0000";
            this.txtvadetarihi.Name = "txtvadetarihi";
            this.txtvadetarihi.Size = new System.Drawing.Size(235, 20);
            this.txtvadetarihi.TabIndex = 47;
            this.txtvadetarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtfaturatarihi
            // 
            this.txtfaturatarihi.Location = new System.Drawing.Point(188, 234);
            this.txtfaturatarihi.Mask = "00/00/0000";
            this.txtfaturatarihi.Name = "txtfaturatarihi";
            this.txtfaturatarihi.Size = new System.Drawing.Size(235, 20);
            this.txtfaturatarihi.TabIndex = 46;
            this.txtfaturatarihi.ValidatingType = typeof(System.DateTime);
            // 
            // cmbdovizturu
            // 
            this.cmbdovizturu.FormattingEnabled = true;
            this.cmbdovizturu.Items.AddRange(new object[] {
            "Türk Lirası TL",
            "Amerikan doları USD",
            "Avrupa Birliği Euro EUR",
            "Japonya Japon yeni JPY",
            "Birleşik Krallık İngiliz sterlini GBP",
            "Çin Renminbi CNY",
            "Avustralya Avustralya doları AUD",
            "Kanada Kanada doları CAD",
            "İsviçre İsviçre frangı CHF",
            "Hong Kong Hong Kong doları HKD",
            "Singapur Singapur doları SGD",
            "İsveç İsveç kronu SEK"});
            this.cmbdovizturu.Location = new System.Drawing.Point(188, 194);
            this.cmbdovizturu.Name = "cmbdovizturu";
            this.cmbdovizturu.Size = new System.Drawing.Size(235, 21);
            this.cmbdovizturu.TabIndex = 45;
            this.cmbdovizturu.Text = "Döviz Seçiniz";
            // 
            // txtmusteri
            // 
            this.txtmusteri.Location = new System.Drawing.Point(188, 155);
            this.txtmusteri.Name = "txtmusteri";
            this.txtmusteri.Size = new System.Drawing.Size(235, 20);
            this.txtmusteri.TabIndex = 44;
            // 
            // txtbelgeno
            // 
            this.txtbelgeno.Location = new System.Drawing.Point(188, 114);
            this.txtbelgeno.Mask = "0000000";
            this.txtbelgeno.Name = "txtbelgeno";
            this.txtbelgeno.Size = new System.Drawing.Size(235, 20);
            this.txtbelgeno.TabIndex = 43;
            this.txtbelgeno.ValidatingType = typeof(int);
            // 
            // txtfaturano
            // 
            this.txtfaturano.Location = new System.Drawing.Point(188, 77);
            this.txtfaturano.Mask = "0000000";
            this.txtfaturano.Name = "txtfaturano";
            this.txtfaturano.Size = new System.Drawing.Size(235, 20);
            this.txtfaturano.TabIndex = 42;
            this.txtfaturano.ValidatingType = typeof(int);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 555);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Açıklama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Kdv Oranı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "TL Tutar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Döviz Tutar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Fatura Türü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Müşteri Temsilcisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vade Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fatura Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fatura Dövizi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Müşteri ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Belge No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fatura No ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Satış Fatura Güncelle";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(111, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 55;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(217, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 56;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(323, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 57;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "İd";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(188, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(235, 20);
            this.txtid.TabIndex = 58;
            // 
            // SatisFaturaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 717);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.cmbkdvorani);
            this.Controls.Add(this.txttltutar);
            this.Controls.Add(this.txtdoviztutar);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.cmbfaturaturu);
            this.Controls.Add(this.txtmustertitemsilci);
            this.Controls.Add(this.txtvadetarihi);
            this.Controls.Add(this.txtfaturatarihi);
            this.Controls.Add(this.cmbdovizturu);
            this.Controls.Add(this.txtmusteri);
            this.Controls.Add(this.txtbelgeno);
            this.Controls.Add(this.txtfaturano);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisFaturaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisFaturaGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox txtid;
        public System.Windows.Forms.TextBox txtaciklama;
        public System.Windows.Forms.ComboBox cmbkdvorani;
        public System.Windows.Forms.MaskedTextBox txttltutar;
        public System.Windows.Forms.MaskedTextBox txtdoviztutar;
        public System.Windows.Forms.MaskedTextBox txtfiyat;
        public System.Windows.Forms.ComboBox cmbfaturaturu;
        public System.Windows.Forms.MaskedTextBox txtmustertitemsilci;
        public System.Windows.Forms.MaskedTextBox txtvadetarihi;
        public System.Windows.Forms.MaskedTextBox txtfaturatarihi;
        public System.Windows.Forms.ComboBox cmbdovizturu;
        public System.Windows.Forms.MaskedTextBox txtmusteri;
        public System.Windows.Forms.MaskedTextBox txtbelgeno;
        public System.Windows.Forms.MaskedTextBox txtfaturano;
    }
}

namespace TransportProje
{
    partial class PersonelGuncelle
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
            this.txtayrilmatarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.MaskedTextBox();
            this.txtavans = new System.Windows.Forms.MaskedTextBox();
            this.txtprim = new System.Windows.Forms.MaskedTextBox();
            this.txtmaas = new System.Windows.Forms.MaskedTextBox();
            this.txtiban = new System.Windows.Forms.MaskedTextBox();
            this.txtayrilma = new System.Windows.Forms.TextBox();
            this.txtbaslama = new System.Windows.Forms.MaskedTextBox();
            this.txtcalisma = new System.Windows.Forms.MaskedTextBox();
            this.cmbbirim = new System.Windows.Forms.ComboBox();
            this.cmbogrenimdurumu = new System.Windows.Forms.ComboBox();
            this.txttelefon = new System.Windows.Forms.MaskedTextBox();
            this.radkadin = new System.Windows.Forms.RadioButton();
            this.raderkek = new System.Windows.Forms.RadioButton();
            this.txttc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtayrilmatarihi
            // 
            this.txtayrilmatarihi.Location = new System.Drawing.Point(554, 60);
            this.txtayrilmatarihi.Name = "txtayrilmatarihi";
            this.txtayrilmatarihi.Size = new System.Drawing.Size(211, 20);
            this.txtayrilmatarihi.TabIndex = 101;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(210, 253);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(147, 20);
            this.txtadres.TabIndex = 100;
            // 
            // txtavans
            // 
            this.txtavans.Location = new System.Drawing.Point(554, 294);
            this.txtavans.Name = "txtavans";
            this.txtavans.Size = new System.Drawing.Size(211, 20);
            this.txtavans.TabIndex = 99;
            // 
            // txtprim
            // 
            this.txtprim.Location = new System.Drawing.Point(554, 253);
            this.txtprim.Name = "txtprim";
            this.txtprim.Size = new System.Drawing.Size(211, 20);
            this.txtprim.TabIndex = 98;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(554, 212);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(211, 20);
            this.txtmaas.TabIndex = 97;
            // 
            // txtiban
            // 
            this.txtiban.Location = new System.Drawing.Point(554, 172);
            this.txtiban.Mask = "00000000000";
            this.txtiban.Name = "txtiban";
            this.txtiban.Size = new System.Drawing.Size(211, 20);
            this.txtiban.TabIndex = 96;
            // 
            // txtayrilma
            // 
            this.txtayrilma.Location = new System.Drawing.Point(554, 97);
            this.txtayrilma.Multiline = true;
            this.txtayrilma.Name = "txtayrilma";
            this.txtayrilma.Size = new System.Drawing.Size(211, 61);
            this.txtayrilma.TabIndex = 95;
            // 
            // txtbaslama
            // 
            this.txtbaslama.Location = new System.Drawing.Point(210, 462);
            this.txtbaslama.Mask = "00/00/0000";
            this.txtbaslama.Name = "txtbaslama";
            this.txtbaslama.Size = new System.Drawing.Size(147, 20);
            this.txtbaslama.TabIndex = 94;
            this.txtbaslama.ValidatingType = typeof(System.DateTime);
            // 
            // txtcalisma
            // 
            this.txtcalisma.Location = new System.Drawing.Point(210, 421);
            this.txtcalisma.Name = "txtcalisma";
            this.txtcalisma.Size = new System.Drawing.Size(147, 20);
            this.txtcalisma.TabIndex = 93;
            // 
            // cmbbirim
            // 
            this.cmbbirim.FormattingEnabled = true;
            this.cmbbirim.Items.AddRange(new object[] {
            "Yönetici",
            "Personel ",
            "Soför"});
            this.cmbbirim.Location = new System.Drawing.Point(210, 379);
            this.cmbbirim.Name = "cmbbirim";
            this.cmbbirim.Size = new System.Drawing.Size(147, 21);
            this.cmbbirim.TabIndex = 92;
            this.cmbbirim.Text = "Birim Seçiniz";
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
            this.cmbogrenimdurumu.Location = new System.Drawing.Point(210, 338);
            this.cmbogrenimdurumu.Name = "cmbogrenimdurumu";
            this.cmbogrenimdurumu.Size = new System.Drawing.Size(147, 21);
            this.cmbogrenimdurumu.TabIndex = 91;
            this.cmbogrenimdurumu.Text = "Öğrenim Durumu Seçiniz";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(210, 298);
            this.txttelefon.Mask = "(999) 000-0000";
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(147, 20);
            this.txttelefon.TabIndex = 90;
            // 
            // radkadin
            // 
            this.radkadin.AutoSize = true;
            this.radkadin.BackColor = System.Drawing.Color.Transparent;
            this.radkadin.ForeColor = System.Drawing.Color.White;
            this.radkadin.Location = new System.Drawing.Point(302, 216);
            this.radkadin.Name = "radkadin";
            this.radkadin.Size = new System.Drawing.Size(55, 17);
            this.radkadin.TabIndex = 89;
            this.radkadin.TabStop = true;
            this.radkadin.Text = "Kadın ";
            this.radkadin.UseVisualStyleBackColor = false;
            // 
            // raderkek
            // 
            this.raderkek.AutoSize = true;
            this.raderkek.BackColor = System.Drawing.Color.Transparent;
            this.raderkek.ForeColor = System.Drawing.Color.White;
            this.raderkek.Location = new System.Drawing.Point(210, 216);
            this.raderkek.Name = "raderkek";
            this.raderkek.Size = new System.Drawing.Size(53, 17);
            this.raderkek.TabIndex = 88;
            this.raderkek.TabStop = true;
            this.raderkek.Text = "Erkek";
            this.raderkek.UseVisualStyleBackColor = false;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(210, 172);
            this.txttc.Mask = "00000000000";
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(147, 20);
            this.txttc.TabIndex = 87;
            this.txttc.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(210, 131);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(147, 20);
            this.txtsoyad.TabIndex = 86;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(210, 94);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(147, 20);
            this.txtad.TabIndex = 85;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(554, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 82;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(665, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 84;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(422, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 18);
            this.label16.TabIndex = 66;
            this.label16.Text = "Ayrilma Tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(422, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 18);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ayrilma Nedeni";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(30, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 18);
            this.label13.TabIndex = 68;
            this.label13.Text = "İşe Başlama Tarihi ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 69;
            this.label12.Text = "Çalışma Yılı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(422, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 70;
            this.label11.Text = "Avans";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(422, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 71;
            this.label10.Text = "Prim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(422, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Maaş ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(422, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "İban Bilgisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "Birimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Öğrenim Durumu ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(30, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 76;
            this.label15.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Cinsiyet ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tc Kimlik No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Soyadı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "Adı ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(29, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(166, 24);
            this.label21.TabIndex = 65;
            this.label21.Text = "Personel Güncelle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(30, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 18);
            this.label17.TabIndex = 81;
            this.label17.Text = "İd";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(210, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(147, 20);
            this.txtid.TabIndex = 102;
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtayrilmatarihi);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtavans);
            this.Controls.Add(this.txtprim);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtiban);
            this.Controls.Add(this.txtayrilma);
            this.Controls.Add(this.txtbaslama);
            this.Controls.Add(this.txtcalisma);
            this.Controls.Add(this.cmbbirim);
            this.Controls.Add(this.cmbogrenimdurumu);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.radkadin);
            this.Controls.Add(this.raderkek);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.MaskedTextBox txtayrilmatarihi;
        public System.Windows.Forms.MaskedTextBox txtadres;
        public System.Windows.Forms.MaskedTextBox txtavans;
        public System.Windows.Forms.MaskedTextBox txtprim;
        public System.Windows.Forms.MaskedTextBox txtmaas;
        public System.Windows.Forms.MaskedTextBox txtiban;
        public System.Windows.Forms.TextBox txtayrilma;
        public System.Windows.Forms.MaskedTextBox txtbaslama;
        public System.Windows.Forms.MaskedTextBox txtcalisma;
        public System.Windows.Forms.ComboBox cmbbirim;
        public System.Windows.Forms.ComboBox cmbogrenimdurumu;
        public System.Windows.Forms.MaskedTextBox txttelefon;
        public System.Windows.Forms.RadioButton radkadin;
        public System.Windows.Forms.RadioButton raderkek;
        public System.Windows.Forms.MaskedTextBox txttc;
        public System.Windows.Forms.MaskedTextBox txtsoyad;
        public System.Windows.Forms.MaskedTextBox txtad;
        public System.Windows.Forms.MaskedTextBox txtid;
    }
}
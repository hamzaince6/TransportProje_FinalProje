﻿
namespace TransportProje
{
    partial class DorseGuncelle
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
            this.cmbbosagirlik = new System.Windows.Forms.ComboBox();
            this.cmbyukseklik = new System.Windows.Forms.ComboBox();
            this.cmbboy = new System.Windows.Forms.ComboBox();
            this.cmben = new System.Windows.Forms.ComboBox();
            this.txthgsno = new System.Windows.Forms.MaskedTextBox();
            this.radyabanci = new System.Windows.Forms.RadioButton();
            this.radyerli = new System.Windows.Forms.RadioButton();
            this.cmbbayrak = new System.Windows.Forms.ComboBox();
            this.txtagirlik = new System.Windows.Forms.MaskedTextBox();
            this.cmbruhsatverilenyer = new System.Windows.Forms.ComboBox();
            this.txtruhsatno = new System.Windows.Forms.MaskedTextBox();
            this.txtsasino = new System.Windows.Forms.MaskedTextBox();
            this.cmbrenk = new System.Windows.Forms.ComboBox();
            this.txtmodel = new System.Windows.Forms.MaskedTextBox();
            this.cmbkullanimalani = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmbbosagirlik
            // 
            this.cmbbosagirlik.FormattingEnabled = true;
            this.cmbbosagirlik.Items.AddRange(new object[] {
            "1000",
            "1200",
            "1400",
            "1600",
            "1800",
            "2000",
            "2200",
            "2400",
            "2600",
            "2800",
            "3000",
            "3200",
            "3400",
            "3600",
            "3800",
            "4000"});
            this.cmbbosagirlik.Location = new System.Drawing.Point(557, 187);
            this.cmbbosagirlik.Name = "cmbbosagirlik";
            this.cmbbosagirlik.Size = new System.Drawing.Size(185, 21);
            this.cmbbosagirlik.TabIndex = 73;
            this.cmbbosagirlik.Text = "Boş Ağırlık Seçiniz";
            // 
            // cmbyukseklik
            // 
            this.cmbyukseklik.FormattingEnabled = true;
            this.cmbyukseklik.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbyukseklik.Location = new System.Drawing.Point(557, 146);
            this.cmbyukseklik.Name = "cmbyukseklik";
            this.cmbyukseklik.Size = new System.Drawing.Size(185, 21);
            this.cmbyukseklik.TabIndex = 72;
            this.cmbyukseklik.Text = "Yükseklik Seçiniz";
            // 
            // cmbboy
            // 
            this.cmbboy.FormattingEnabled = true;
            this.cmbboy.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70"});
            this.cmbboy.Location = new System.Drawing.Point(557, 105);
            this.cmbboy.Name = "cmbboy";
            this.cmbboy.Size = new System.Drawing.Size(185, 21);
            this.cmbboy.TabIndex = 71;
            this.cmbboy.Text = "Boy Seçiniz";
            // 
            // cmben
            // 
            this.cmben.FormattingEnabled = true;
            this.cmben.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cmben.Location = new System.Drawing.Point(557, 64);
            this.cmben.Name = "cmben";
            this.cmben.Size = new System.Drawing.Size(185, 21);
            this.cmben.TabIndex = 70;
            this.cmben.Text = "En Seçiniz";
            // 
            // txthgsno
            // 
            this.txthgsno.Location = new System.Drawing.Point(223, 424);
            this.txthgsno.Mask = "0000000000";
            this.txthgsno.Name = "txthgsno";
            this.txthgsno.Size = new System.Drawing.Size(160, 20);
            this.txthgsno.TabIndex = 69;
            this.txthgsno.ValidatingType = typeof(int);
            // 
            // radyabanci
            // 
            this.radyabanci.AutoSize = true;
            this.radyabanci.BackColor = System.Drawing.Color.Transparent;
            this.radyabanci.ForeColor = System.Drawing.Color.White;
            this.radyabanci.Location = new System.Drawing.Point(315, 390);
            this.radyabanci.Name = "radyabanci";
            this.radyabanci.Size = new System.Drawing.Size(64, 17);
            this.radyabanci.TabIndex = 68;
            this.radyabanci.TabStop = true;
            this.radyabanci.Text = "Yabancı";
            this.radyabanci.UseVisualStyleBackColor = false;
            // 
            // radyerli
            // 
            this.radyerli.AutoSize = true;
            this.radyerli.BackColor = System.Drawing.Color.Transparent;
            this.radyerli.ForeColor = System.Drawing.Color.White;
            this.radyerli.Location = new System.Drawing.Point(223, 390);
            this.radyerli.Name = "radyerli";
            this.radyerli.Size = new System.Drawing.Size(45, 17);
            this.radyerli.TabIndex = 67;
            this.radyerli.TabStop = true;
            this.radyerli.Text = "Yerli";
            this.radyerli.UseVisualStyleBackColor = false;
            // 
            // cmbbayrak
            // 
            this.cmbbayrak.FormattingEnabled = true;
            this.cmbbayrak.Items.AddRange(new object[] {
            "TR",
            "DE",
            "US",
            "AU",
            "AT",
            "AZ",
            "BE",
            "BR",
            "BG",
            "CZ",
            "FR",
            "NL",
            "GB",
            "IR",
            "CH"});
            this.cmbbayrak.Location = new System.Drawing.Point(223, 349);
            this.cmbbayrak.Name = "cmbbayrak";
            this.cmbbayrak.Size = new System.Drawing.Size(160, 21);
            this.cmbbayrak.TabIndex = 66;
            this.cmbbayrak.Text = "Bayrak Seçiniz";
            // 
            // txtagirlik
            // 
            this.txtagirlik.Location = new System.Drawing.Point(223, 316);
            this.txtagirlik.Mask = "000000";
            this.txtagirlik.Name = "txtagirlik";
            this.txtagirlik.Size = new System.Drawing.Size(160, 20);
            this.txtagirlik.TabIndex = 65;
            // 
            // cmbruhsatverilenyer
            // 
            this.cmbruhsatverilenyer.FormattingEnabled = true;
            this.cmbruhsatverilenyer.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cmbruhsatverilenyer.Location = new System.Drawing.Point(223, 275);
            this.cmbruhsatverilenyer.Name = "cmbruhsatverilenyer";
            this.cmbruhsatverilenyer.Size = new System.Drawing.Size(160, 21);
            this.cmbruhsatverilenyer.TabIndex = 64;
            this.cmbruhsatverilenyer.Text = "Ruhsat Verilen Yer Seçiniz";
            // 
            // txtruhsatno
            // 
            this.txtruhsatno.Location = new System.Drawing.Point(223, 239);
            this.txtruhsatno.Mask = "0000000000";
            this.txtruhsatno.Name = "txtruhsatno";
            this.txtruhsatno.Size = new System.Drawing.Size(160, 20);
            this.txtruhsatno.TabIndex = 63;
            this.txtruhsatno.ValidatingType = typeof(int);
            // 
            // txtsasino
            // 
            this.txtsasino.Location = new System.Drawing.Point(223, 202);
            this.txtsasino.Mask = "0000000000";
            this.txtsasino.Name = "txtsasino";
            this.txtsasino.Size = new System.Drawing.Size(160, 20);
            this.txtsasino.TabIndex = 62;
            this.txtsasino.ValidatingType = typeof(int);
            // 
            // cmbrenk
            // 
            this.cmbrenk.FormattingEnabled = true;
            this.cmbrenk.Items.AddRange(new object[] {
            "Beyaz",
            "Bordo ",
            "Gri ",
            "Gümüş Gri",
            "Kırmızı",
            "Lacivert",
            "Mor ",
            "Pembe",
            "Sarı ",
            "Siyah ",
            "Turkuaz",
            "Turuncu ",
            "Yeşil"});
            this.cmbrenk.Location = new System.Drawing.Point(223, 165);
            this.cmbrenk.Name = "cmbrenk";
            this.cmbrenk.Size = new System.Drawing.Size(160, 21);
            this.cmbrenk.TabIndex = 61;
            this.cmbrenk.Text = "Renk Seçiniz";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(223, 129);
            this.txtmodel.Mask = "0000";
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(160, 20);
            this.txtmodel.TabIndex = 60;
            this.txtmodel.ValidatingType = typeof(int);
            // 
            // cmbkullanimalani
            // 
            this.cmbkullanimalani.FormattingEnabled = true;
            this.cmbkullanimalani.Items.AddRange(new object[] {
            "Damperli",
            "Lowbed",
            "Kuru Yük ",
            "Tenteli",
            "Frigorifik",
            "Tanker",
            "Tekstil",
            "Silobas",
            "Konteyner",
            "Şasi Grubu ",
            "Özel Amaçlı Dorseler"});
            this.cmbkullanimalani.Location = new System.Drawing.Point(223, 91);
            this.cmbkullanimalani.Name = "cmbkullanimalani";
            this.cmbkullanimalani.Size = new System.Drawing.Size(160, 21);
            this.cmbkullanimalani.TabIndex = 59;
            this.cmbkullanimalani.Text = "Kullanım Alanı Seçiniz";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(536, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 56;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(642, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 58;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "HGS No ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Yerli Yabancı ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Bayrak ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Net Agirlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ruhsat Verilen Yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ruhsat No ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sasi No ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Renk ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Model Yili";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(460, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Boş Ağırlık";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(460, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Yükseklik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(460, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Boy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(460, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "En ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Kullanım Alanı ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(59, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 24);
            this.label21.TabIndex = 41;
            this.label21.Text = "Dorse Güncelle";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.BackColor = System.Drawing.Color.Transparent;
            this.tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx.ForeColor = System.Drawing.Color.White;
            this.tx.Location = new System.Drawing.Point(61, 63);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(19, 18);
            this.tx.TabIndex = 55;
            this.tx.Text = "İd";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(223, 61);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 20);
            this.txtid.TabIndex = 74;
            // 
            // DorseGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbbosagirlik);
            this.Controls.Add(this.cmbyukseklik);
            this.Controls.Add(this.cmbboy);
            this.Controls.Add(this.cmben);
            this.Controls.Add(this.txthgsno);
            this.Controls.Add(this.radyabanci);
            this.Controls.Add(this.radyerli);
            this.Controls.Add(this.cmbbayrak);
            this.Controls.Add(this.txtagirlik);
            this.Controls.Add(this.cmbruhsatverilenyer);
            this.Controls.Add(this.txtruhsatno);
            this.Controls.Add(this.txtsasino);
            this.Controls.Add(this.cmbrenk);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.cmbkullanimalani);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DorseGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DorseGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label tx;
        public System.Windows.Forms.ComboBox cmbbosagirlik;
        public System.Windows.Forms.ComboBox cmbyukseklik;
        public System.Windows.Forms.ComboBox cmbboy;
        public System.Windows.Forms.ComboBox cmben;
        public System.Windows.Forms.MaskedTextBox txthgsno;
        public System.Windows.Forms.RadioButton radyabanci;
        public System.Windows.Forms.RadioButton radyerli;
        public System.Windows.Forms.ComboBox cmbbayrak;
        public System.Windows.Forms.MaskedTextBox txtagirlik;
        public System.Windows.Forms.ComboBox cmbruhsatverilenyer;
        public System.Windows.Forms.MaskedTextBox txtruhsatno;
        public System.Windows.Forms.MaskedTextBox txtsasino;
        public System.Windows.Forms.ComboBox cmbrenk;
        public System.Windows.Forms.MaskedTextBox txtmodel;
        public System.Windows.Forms.ComboBox cmbkullanimalani;
        public System.Windows.Forms.MaskedTextBox txtid;
    }
}
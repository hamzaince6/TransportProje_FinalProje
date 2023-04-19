
namespace TransportProje
{
    partial class YakitTakipGuncelle
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtortalama = new System.Windows.Forms.MaskedTextBox();
            this.cmbgunlukhak = new System.Windows.Forms.ComboBox();
            this.cmbyakit = new System.Windows.Forms.ComboBox();
            this.cmbdepohacmi = new System.Windows.Forms.ComboBox();
            this.txtplaka = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(264, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 65;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(370, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 67;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(181, 281);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(207, 20);
            this.txtortalama.TabIndex = 64;
            // 
            // cmbgunlukhak
            // 
            this.cmbgunlukhak.FormattingEnabled = true;
            this.cmbgunlukhak.Items.AddRange(new object[] {
            "250\t",
            "500",
            "750",
            "1000"});
            this.cmbgunlukhak.Location = new System.Drawing.Point(181, 239);
            this.cmbgunlukhak.Name = "cmbgunlukhak";
            this.cmbgunlukhak.Size = new System.Drawing.Size(207, 21);
            this.cmbgunlukhak.TabIndex = 63;
            this.cmbgunlukhak.Text = "Günlük Hak Seçiniz";
            // 
            // cmbyakit
            // 
            this.cmbyakit.FormattingEnabled = true;
            this.cmbyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG",
            "LNG"});
            this.cmbyakit.Location = new System.Drawing.Point(181, 198);
            this.cmbyakit.Name = "cmbyakit";
            this.cmbyakit.Size = new System.Drawing.Size(207, 21);
            this.cmbyakit.TabIndex = 62;
            this.cmbyakit.Text = "Yakıt Tipi Seçiniz";
            // 
            // cmbdepohacmi
            // 
            this.cmbdepohacmi.FormattingEnabled = true;
            this.cmbdepohacmi.Items.AddRange(new object[] {
            "900",
            "1000",
            "1100",
            "1250",
            "1500",
            "1750",
            "2000",
            "2500",
            "3000"});
            this.cmbdepohacmi.Location = new System.Drawing.Point(181, 157);
            this.cmbdepohacmi.Name = "cmbdepohacmi";
            this.cmbdepohacmi.Size = new System.Drawing.Size(207, 21);
            this.cmbdepohacmi.TabIndex = 61;
            this.cmbdepohacmi.Text = "Depo Hacmi Seçiniz";
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(181, 117);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(207, 20);
            this.txtplaka.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ortalama Yakit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Günlük Hak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Yakıt Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Depo Hacmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Plaka";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(31, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 24);
            this.label21.TabIndex = 54;
            this.label21.Text = "Yakıt Takip Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "İd";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(181, 76);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(207, 20);
            this.txtid.TabIndex = 68;
            // 
            // YakitTakipGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(500, 539);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.cmbgunlukhak);
            this.Controls.Add(this.cmbyakit);
            this.Controls.Add(this.cmbdepohacmi);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YakitTakipGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YakitTakipGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtid;
        public System.Windows.Forms.MaskedTextBox txtortalama;
        public System.Windows.Forms.ComboBox cmbgunlukhak;
        public System.Windows.Forms.ComboBox cmbyakit;
        public System.Windows.Forms.ComboBox cmbdepohacmi;
        public System.Windows.Forms.MaskedTextBox txtplaka;
    }
}
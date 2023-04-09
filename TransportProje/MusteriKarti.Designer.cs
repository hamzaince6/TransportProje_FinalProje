
namespace TransportProje
{
    partial class MusteriKarti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKarti));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsterlin = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsterlin
            // 
            this.lblsterlin.AutoSize = true;
            this.lblsterlin.BackColor = System.Drawing.Color.Transparent;
            this.lblsterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsterlin.ForeColor = System.Drawing.Color.White;
            this.lblsterlin.Location = new System.Drawing.Point(1114, 31);
            this.lblsterlin.Name = "lblsterlin";
            this.lblsterlin.Size = new System.Drawing.Size(46, 17);
            this.lblsterlin.TabIndex = 12;
            this.lblsterlin.Text = "label3";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.BackColor = System.Drawing.Color.Transparent;
            this.lbleuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuro.ForeColor = System.Drawing.Color.White;
            this.lbleuro.Location = new System.Drawing.Point(996, 31);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(46, 17);
            this.lbleuro.TabIndex = 11;
            this.lbleuro.Text = "label2";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.BackColor = System.Drawing.Color.Transparent;
            this.lbldolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldolar.ForeColor = System.Drawing.Color.White;
            this.lbldolar.Location = new System.Drawing.Point(880, 31);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(46, 17);
            this.lbldolar.TabIndex = 10;
            this.lbldolar.Text = "label1";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1213, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 55);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1273, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 55);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MusteriKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblsterlin);
            this.Controls.Add(this.lbleuro);
            this.Controls.Add(this.lbldolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriKarti";
            this.Load += new System.EventHandler(this.MusteriKarti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsterlin;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}
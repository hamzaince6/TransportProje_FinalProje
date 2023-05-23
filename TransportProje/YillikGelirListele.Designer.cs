
namespace TransportProje
{
    partial class YillikGelirListele
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
            this.dataGridYillik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYillik)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridYillik
            // 
            this.dataGridYillik.AllowUserToAddRows = false;
            this.dataGridYillik.AllowUserToDeleteRows = false;
            this.dataGridYillik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYillik.Location = new System.Drawing.Point(12, 102);
            this.dataGridYillik.Name = "dataGridYillik";
            this.dataGridYillik.ReadOnly = true;
            this.dataGridYillik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridYillik.Size = new System.Drawing.Size(708, 486);
            this.dataGridYillik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yillik Gelir Listele";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1104, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 23;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.BackColor = System.Drawing.Color.White;
            this.monthCalendar2.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar2.Location = new System.Drawing.Point(732, 140);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(929, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Takvim";
            // 
            // YillikGelirListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportProje.Properties.Resources._2180133;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridYillik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YillikGelirListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YillikGelirListele";
            this.Load += new System.EventHandler(this.YillikGelirListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYillik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridYillik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
    }
}
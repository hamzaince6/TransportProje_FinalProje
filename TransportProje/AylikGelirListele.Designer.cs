
namespace TransportProje
{
    partial class AylikGelirListele
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
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAylik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAylik)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(934, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Takvim";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.BackColor = System.Drawing.Color.White;
            this.monthCalendar2.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar2.Location = new System.Drawing.Point(737, 124);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1109, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 33;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Aylik Gelir Listele";
            // 
            // dataGridAylik
            // 
            this.dataGridAylik.AllowUserToAddRows = false;
            this.dataGridAylik.AllowUserToDeleteRows = false;
            this.dataGridAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAylik.Location = new System.Drawing.Point(17, 86);
            this.dataGridAylik.Name = "dataGridAylik";
            this.dataGridAylik.ReadOnly = true;
            this.dataGridAylik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAylik.Size = new System.Drawing.Size(708, 486);
            this.dataGridAylik.TabIndex = 31;
            // 
            // AylikGelirListele
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
            this.Controls.Add(this.dataGridAylik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AylikGelirListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AylikGelirListele";
            this.Load += new System.EventHandler(this.AylikGelirListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAylik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAylik;
    }
}
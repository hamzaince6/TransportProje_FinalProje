
namespace TransportProje
{
    partial class DetaylıRaporYakitTakip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnara = new System.Windows.Forms.Button();
            this.txtsoyadara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataDataSet = new TransportProje.DataDataSet();
            this.GirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GirisTableAdapter = new TransportProje.DataDataSetTableAdapters.GirisTableAdapter();
            this.YakitTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YakitTakipTableAdapter = new TransportProje.DataDataSetTableAdapters.YakitTakipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YakitTakipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.YakitTakipBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportProje.DetaylıRaporYakitTakip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(250, 650);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 9;
            this.btnara.Text = "Filtrele";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtsoyadara
            // 
            this.txtsoyadara.Location = new System.Drawing.Point(88, 653);
            this.txtsoyadara.Name = "txtsoyadara";
            this.txtsoyadara.Size = new System.Drawing.Size(141, 20);
            this.txtsoyadara.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yakit Takip";
            // 
            // DataDataSet
            // 
            this.DataDataSet.DataSetName = "DataDataSet";
            this.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GirisBindingSource
            // 
            this.GirisBindingSource.DataMember = "Giris";
            this.GirisBindingSource.DataSource = this.DataDataSet;
            // 
            // GirisTableAdapter
            // 
            this.GirisTableAdapter.ClearBeforeFill = true;
            // 
            // YakitTakipBindingSource
            // 
            this.YakitTakipBindingSource.DataMember = "YakitTakip";
            this.YakitTakipBindingSource.DataSource = this.DataDataSet;
            // 
            // YakitTakipTableAdapter
            // 
            this.YakitTakipTableAdapter.ClearBeforeFill = true;
            // 
            // DetaylıRaporYakitTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtsoyadara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DetaylıRaporYakitTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetaylıRaporYakitTakip";
            this.Load += new System.EventHandler(this.DetaylıRaporYakitTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YakitTakipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtsoyadara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource GirisBindingSource;
        private DataDataSet DataDataSet;
        private DataDataSetTableAdapters.GirisTableAdapter GirisTableAdapter;
        private System.Windows.Forms.BindingSource YakitTakipBindingSource;
        private DataDataSetTableAdapters.YakitTakipTableAdapter YakitTakipTableAdapter;
    }
}
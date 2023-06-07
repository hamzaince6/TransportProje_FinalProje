
namespace TransportProje
{
    partial class DetaylıRaporPersonel
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
            this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataDataSet = new TransportProje.DataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelTableAdapter = new TransportProje.DataDataSetTableAdapters.PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyadara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelBindingSource
            // 
            this.PersonelBindingSource.DataMember = "Personel";
            this.PersonelBindingSource.DataSource = this.DataDataSet;
            // 
            // DataDataSet
            // 
            this.DataDataSet.DataSetName = "DataDataSet";
            this.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportProje.DetaylıRaporPersonel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelTableAdapter
            // 
            this.PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soyad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsoyadara
            // 
            this.txtsoyadara.Location = new System.Drawing.Point(71, 653);
            this.txtsoyadara.Name = "txtsoyadara";
            this.txtsoyadara.Size = new System.Drawing.Size(141, 20);
            this.txtsoyadara.TabIndex = 2;
            this.txtsoyadara.TextChanged += new System.EventHandler(this.txtsoyadara_TextChanged);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(233, 650);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 3;
            this.btnara.Text = "Filtrele";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // DetaylıRaporPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtsoyadara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DetaylıRaporPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetaylıRaporPersonel";
            this.Load += new System.EventHandler(this.DetaylıRaporPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonelBindingSource;
        private DataDataSet DataDataSet;
        private DataDataSetTableAdapters.PersonelTableAdapter PersonelTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyadara;
        private System.Windows.Forms.Button btnara;
    }
}
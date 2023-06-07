
namespace TransportProje
{
    partial class DetaylıRaporCekici
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
            this.TrucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataDataSet = new TransportProje.DataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TrucksTableAdapter = new TransportProje.DataDataSetTableAdapters.TrucksTableAdapter();
            this.btnara = new System.Windows.Forms.Button();
            this.txtsoyadara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrucksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TrucksBindingSource
            // 
            this.TrucksBindingSource.DataMember = "Trucks";
            this.TrucksBindingSource.DataSource = this.DataDataSet;
            // 
            // DataDataSet
            // 
            this.DataDataSet.DataSetName = "DataDataSet";
            this.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TrucksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportProje.DetaylıRaporCekici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // TrucksTableAdapter
            // 
            this.TrucksTableAdapter.ClearBeforeFill = true;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(223, 650);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "Filtrele";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtsoyadara
            // 
            this.txtsoyadara.Location = new System.Drawing.Point(61, 653);
            this.txtsoyadara.Name = "txtsoyadara";
            this.txtsoyadara.Size = new System.Drawing.Size(141, 20);
            this.txtsoyadara.TabIndex = 5;
            this.txtsoyadara.TextChanged += new System.EventHandler(this.txtsoyadara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DetaylıRaporCekici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtsoyadara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DetaylıRaporCekici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetaylıRaporCekici";
            this.Load += new System.EventHandler(this.DetaylıRaporCekici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrucksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrucksBindingSource;
        private DataDataSet DataDataSet;
        private DataDataSetTableAdapters.TrucksTableAdapter TrucksTableAdapter;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtsoyadara;
        private System.Windows.Forms.Label label1;
    }
}
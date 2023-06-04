
namespace TransportProje
{
    partial class RaporMusteriKarti
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
            this.DataDataSet = new TransportProje.DataDataSet();
            this.MusteriKartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MusteriKartiTableAdapter = new TransportProje.DataDataSetTableAdapters.MusteriKartiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriKartiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MusteriKartiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportProje.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataDataSet
            // 
            this.DataDataSet.DataSetName = "DataDataSet";
            this.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusteriKartiBindingSource
            // 
            this.MusteriKartiBindingSource.DataMember = "MusteriKarti";
            this.MusteriKartiBindingSource.DataSource = this.DataDataSet;
            // 
            // MusteriKartiTableAdapter
            // 
            this.MusteriKartiTableAdapter.ClearBeforeFill = true;
            // 
            // RaporMusteriKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaporMusteriKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporMusteriKarti";
            this.Load += new System.EventHandler(this.RaporMusteriKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriKartiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MusteriKartiBindingSource;
        private DataDataSet DataDataSet;
        private DataDataSetTableAdapters.MusteriKartiTableAdapter MusteriKartiTableAdapter;
    }
}
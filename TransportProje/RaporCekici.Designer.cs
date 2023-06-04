
namespace TransportProje
{
    partial class RaporCekici
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportProje.Cekici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1247, 700);
            this.reportViewer1.TabIndex = 0;
            // 
            // TrucksTableAdapter
            // 
            this.TrucksTableAdapter.ClearBeforeFill = true;
            // 
            // RaporCekici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaporCekici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporCekici";
            this.Load += new System.EventHandler(this.RaporCekici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrucksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrucksBindingSource;
        private DataDataSet DataDataSet;
        private DataDataSetTableAdapters.TrucksTableAdapter TrucksTableAdapter;
    }
}
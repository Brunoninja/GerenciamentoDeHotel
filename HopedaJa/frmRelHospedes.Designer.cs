namespace HopedaJa
{
    partial class frmRelHospedes
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
            this.DadosDataSet = new HopedaJa.DadosDataSet();
            this.hospedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospedeTableAdapter = new HopedaJa.DadosDataSetTableAdapters.hospedeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hospedeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HopedaJa.rptHospedes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(838, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // DadosDataSet
            // 
            this.DadosDataSet.DataSetName = "DadosDataSet";
            this.DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospedeBindingSource
            // 
            this.hospedeBindingSource.DataMember = "hospede";
            this.hospedeBindingSource.DataSource = this.DadosDataSet;
            // 
            // hospedeTableAdapter
            // 
            this.hospedeTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmRelHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Hospedes";
            this.Load += new System.EventHandler(this.frmRelHospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hospedeBindingSource;
        private DadosDataSet DadosDataSet;
        private DadosDataSetTableAdapters.hospedeTableAdapter hospedeTableAdapter;
    }
}
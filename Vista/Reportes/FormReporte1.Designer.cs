namespace Vista.Reportes
{
    partial class FormReporte1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.amortizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reporte1 = new Vista.Reportes.DS_Reporte1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.amortizacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amortizacionTableAdapter = new Vista.Reportes.DS_Reporte1TableAdapters.AmortizacionTableAdapter();
            this.prestamosdatabaseDataSet1 = new Vista.PrestamosdatabaseDataSet1();
            this.amortizacionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.amortizacionTableAdapter1 = new Vista.PrestamosdatabaseDataSet1TableAdapters.AmortizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosdatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // amortizacionBindingSource
            // 
            this.amortizacionBindingSource.DataMember = "Amortizacion";
            this.amortizacionBindingSource.DataSource = this.dS_Reporte1;
            // 
            // dS_Reporte1
            // 
            this.dS_Reporte1.DataSetName = "DS_Reporte1";
            this.dS_Reporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Amortizacion";
            reportDataSource1.Value = this.amortizacionBindingSource1;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.amortizacionBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // amortizacionBindingSource1
            // 
            this.amortizacionBindingSource1.DataMember = "Amortizacion";
            this.amortizacionBindingSource1.DataSource = this.dS_Reporte1;
            // 
            // amortizacionTableAdapter
            // 
            this.amortizacionTableAdapter.ClearBeforeFill = true;
            // 
            // prestamosdatabaseDataSet1
            // 
            this.prestamosdatabaseDataSet1.DataSetName = "PrestamosdatabaseDataSet1";
            this.prestamosdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amortizacionBindingSource2
            // 
            this.amortizacionBindingSource2.DataMember = "Amortizacion";
            this.amortizacionBindingSource2.DataSource = this.prestamosdatabaseDataSet1;
            // 
            // amortizacionTableAdapter1
            // 
            this.amortizacionTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte1";
            this.Text = "FormReporte1";
            this.Load += new System.EventHandler(this.FormReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosdatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizacionBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource amortizacionBindingSource;
        private DS_Reporte1 dS_Reporte1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource amortizacionBindingSource1;
        private DS_Reporte1TableAdapters.AmortizacionTableAdapter amortizacionTableAdapter;
        private PrestamosdatabaseDataSet1 prestamosdatabaseDataSet1;
        private System.Windows.Forms.BindingSource amortizacionBindingSource2;
        private PrestamosdatabaseDataSet1TableAdapters.AmortizacionTableAdapter amortizacionTableAdapter1;
    }
}
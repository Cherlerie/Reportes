namespace Vista.Reportes
{
    partial class FormReorte3
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
            this.dS_Reporte3 = new Vista.Reportes.DS_Reporte3();
            this.spReporteTotalPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteTotalPrestamosTableAdapter = new Vista.Reportes.DS_Reporte3TableAdapters.sp_ReporteTotalPrestamosTableAdapter();
            this.dSReporte3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReporteTotalPrestamosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTotalPrestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTotalPrestamosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReporteTotalPrestamosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.Reporte3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reporte3
            // 
            this.dS_Reporte3.DataSetName = "DS_Reporte3";
            this.dS_Reporte3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteTotalPrestamosBindingSource
            // 
            this.spReporteTotalPrestamosBindingSource.DataMember = "sp_ReporteTotalPrestamos";
            this.spReporteTotalPrestamosBindingSource.DataSource = this.dS_Reporte3;
            // 
            // sp_ReporteTotalPrestamosTableAdapter
            // 
            this.sp_ReporteTotalPrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // dSReporte3BindingSource
            // 
            this.dSReporte3BindingSource.DataSource = this.dS_Reporte3;
            this.dSReporte3BindingSource.Position = 0;
            // 
            // spReporteTotalPrestamosBindingSource1
            // 
            this.spReporteTotalPrestamosBindingSource1.DataMember = "sp_ReporteTotalPrestamos";
            this.spReporteTotalPrestamosBindingSource1.DataSource = this.dS_Reporte3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 1;
            // 
            // FormReorte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReorte3";
            this.Text = "FormReorte3";
            this.Load += new System.EventHandler(this.FormReorte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTotalPrestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTotalPrestamosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reporte3 dS_Reporte3;
        private System.Windows.Forms.BindingSource spReporteTotalPrestamosBindingSource;
        private DS_Reporte3TableAdapters.sp_ReporteTotalPrestamosTableAdapter sp_ReporteTotalPrestamosTableAdapter;
        private System.Windows.Forms.BindingSource spReporteTotalPrestamosBindingSource1;
        private System.Windows.Forms.BindingSource dSReporte3BindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}
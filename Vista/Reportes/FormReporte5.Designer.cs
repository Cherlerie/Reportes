namespace Vista.Reportes
{
    partial class FormReporte5
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
            this.dS_Reporte5 = new Vista.Reportes.DS_Reporte5();
            this.spListarClientesMorososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListarClientesMorososTableAdapter = new Vista.Reportes.DS_Reporte5TableAdapters.sp_ListarClientesMorososTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarClientesMorososBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListarClientesMorososBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.Reporte5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reporte5
            // 
            this.dS_Reporte5.DataSetName = "DS_Reporte5";
            this.dS_Reporte5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarClientesMorososBindingSource
            // 
            this.spListarClientesMorososBindingSource.DataMember = "sp_ListarClientesMorosos";
            this.spListarClientesMorososBindingSource.DataSource = this.dS_Reporte5;
            // 
            // sp_ListarClientesMorososTableAdapter
            // 
            this.sp_ListarClientesMorososTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporte5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte5";
            this.Text = "FormReporte5";
            this.Load += new System.EventHandler(this.FormReporte5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarClientesMorososBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Reporte5 dS_Reporte5;
        private System.Windows.Forms.BindingSource spListarClientesMorososBindingSource;
        private DS_Reporte5TableAdapters.sp_ListarClientesMorososTableAdapter sp_ListarClientesMorososTableAdapter;
    }
}
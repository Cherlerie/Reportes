namespace Vista.Reportes
{
    partial class FormReporte4
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
            this.dS_Reportes = new Vista.Reportes.DS_Reportes1();
            this.dSReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosdatabaseDataSet = new Vista.PrestamosdatabaseDataSet();
            this.spmorasporclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_morasporclienteTableAdapter = new Vista.PrestamosdatabaseDataSetTableAdapters.sp_morasporclienteTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmorasporclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmorasporclienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSReportesBindingSource
            // 
            this.dSReportesBindingSource.DataSource = this.dS_Reportes;
            this.dSReportesBindingSource.Position = 0;
            // 
            // prestamosdatabaseDataSet
            // 
            this.prestamosdatabaseDataSet.DataSetName = "PrestamosdatabaseDataSet";
            this.prestamosdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmorasporclienteBindingSource
            // 
            this.spmorasporclienteBindingSource.DataMember = "sp_morasporcliente";
            this.spmorasporclienteBindingSource.DataSource = this.prestamosdatabaseDataSet;
            // 
            // sp_morasporclienteTableAdapter
            // 
            this.sp_morasporclienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(31, 61);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(165, 22);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // FormReporte4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte4";
            this.Text = "FormReporte4";
            this.Load += new System.EventHandler(this.FormReporte4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmorasporclienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmorasporclienteBindingSource;
        private PrestamosdatabaseDataSet prestamosdatabaseDataSet;
        private DS_Reportes1 dS_Reportes;
        private System.Windows.Forms.BindingSource dSReportesBindingSource;
        private PrestamosdatabaseDataSetTableAdapters.sp_morasporclienteTableAdapter sp_morasporclienteTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}
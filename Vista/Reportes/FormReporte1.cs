using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Vista.Reportes
{
    public partial class FormReporte1 : Form
    {
        public FormReporte1()
        {
            InitializeComponent();
        }

        public void FormReporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosdatabaseDataSet1.Amortizacion' Puede moverla o quitarla según sea necesario.
            this.amortizacionTableAdapter1.Fill(this.prestamosdatabaseDataSet1.Amortizacion);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void CargarReporte(int prestamoID)
        {
            try
            {
                ReportParameter parametro = new ReportParameter("PrestamoID", prestamoID.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parametro });
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

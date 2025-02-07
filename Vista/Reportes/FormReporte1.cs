using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Reportes
{
    public partial class FormReporte1 : Form
    {
        public FormReporte1()
        {
            InitializeComponent();
        }

        private void FormReporte1_Load(object sender, EventArgs e)
        {
            try
            {
                int? prestamoID = 1; 
                this.sp_ObtenerAmortizacionTableAdapter.Fill(dataSet1.sp_ObtenerAmortizacion, prestamoID);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte, inténtelo otra vez: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}

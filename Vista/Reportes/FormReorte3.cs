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
    public partial class FormReorte3 : Form
    {
        public FormReorte3()
        {
            InitializeComponent();
        }

        private void FormReorte3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reporte3.sp_ReporteTotalPrestamos' Puede moverla o quitarla según sea necesario.
            this.sp_ReporteTotalPrestamosTableAdapter.Fill(this.dS_Reporte3.sp_ReporteTotalPrestamos);

            this.reportViewer1.RefreshReport();
        }
    }
}

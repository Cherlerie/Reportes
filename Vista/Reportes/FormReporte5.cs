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
    public partial class FormReporte5 : Form
    {
        public FormReporte5()
        {
            InitializeComponent();
        }

        private void FormReporte5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reporte5.sp_ListarClientesMorosos' Puede moverla o quitarla según sea necesario.
            this.sp_ListarClientesMorososTableAdapter.Fill(this.dS_Reporte5.sp_ListarClientesMorosos);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class FormReporte4 : Form
    {
        private PrestamosdatabaseDataSet ds = new PrestamosdatabaseDataSet();

        public FormReporte4()
        {
            InitializeComponent();
        }

        private void FormReporte4_Load(object sender, EventArgs e)
        {
            try
            {
                this.sp_morasporclienteTableAdapter.Fill(ds.sp_morasporcliente, txt_p1.Text);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

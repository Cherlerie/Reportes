using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class BuscarMorosos : Form
    {
        private CN_Moras cnMoras = new CN_Moras();

        public BuscarMorosos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Ingrese un criterio de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataTable dtMorosos = cnMoras.BuscarMorosos(criterio);
                dgvMorosos.DataSource = dtMorosos;

                if (dtMorosos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes morosos con ese criterio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar morosos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

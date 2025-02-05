using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class BuscarCliente : Form
    {
        private CN_Cliente cnCliente = new CN_Cliente();

        public BuscarCliente()
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
                DataTable dtClientes = cnCliente.BuscarCliente(criterio);

                dgvClientes.DataSource = dtClientes;

                if (dtClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes con ese criterio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}

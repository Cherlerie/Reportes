using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Pjr_Capa_Presentacion
{
    public partial class Moras : Form
    {
        private int ClienteID;
        private CN_Moras negocioMoras = new CN_Moras();

        public Moras(int clienteID)
        {
            InitializeComponent();
            this.ClienteID = clienteID;
            CargarMoras();
        }

        private void CargarMoras()
        {
            try
            {
                DataTable dt = negocioMoras.ObtenerMoras(ClienteID);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las moras: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

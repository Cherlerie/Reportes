using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pjr_Capa_Negocio;
 
namespace Vista
{
    public partial class Prestamos : Form
    { 
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private int ClienteID;

        public Prestamos(int clienteID)
        {
            InitializeComponent();
            this.ClienteID = clienteID;

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();

        }

        private void CargarPrestamos()
        {
            try
            {
                DataTable dt = cnPrestamo.ObtenerPrestamosPorCliente(ClienteID);
                 dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

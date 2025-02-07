using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class GestionPrestamos : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();

        public GestionPrestamos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteID = int.Parse(txtClienteID.Text.Trim());
                decimal montoPrestamo = decimal.Parse(txtMontoPrestamo.Text.Trim());
                int tiempoMeses = int.Parse(txtTiempoMeses.Text.Trim());
                decimal sueldo = decimal.Parse(txtSueldo.Text.Trim());
                string garantia = txtGarantia.Text.Trim();

                CE_Prestamo prestamo = new CE_Prestamo
                {
                    ClienteID = clienteID,
                    MontoPrestamo = montoPrestamo,
                    TiempoMeses = tiempoMeses
                };

                bool insertado = cnPrestamo.InsertarPrestamo(prestamo, sueldo, garantia);
                if (insertado)
                {
                    MessageBox.Show("Préstamo insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

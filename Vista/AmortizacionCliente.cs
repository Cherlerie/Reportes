using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class AmortizacionCliente : Form
    {
        private CN_Amortizacion cnAmortizacion = new CN_Amortizacion();
        private CN_Prestamo cnPrestamo = new CN_Prestamo();

        private int ClienteID;
        private int prestamoID = 0;

        public AmortizacionCliente(int ClienteID)
        {
            InitializeComponent();
            this.ClienteID = ClienteID;
        }

        private void AmortizacionCliente_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CargarPrestamos()
        {
            try
            {
                DataTable dtPrestamos = cnPrestamo.ObtenerPrestamosPorCliente(ClienteID);
                MessageBox.Show("Filas de préstamos: " + dtPrestamos.Rows.Count.ToString()); 
                if (dtPrestamos != null && dtPrestamos.Rows.Count > 0)
                {
                    comboBoxPrestamos.DataSource = dtPrestamos;
                    comboBoxPrestamos.DisplayMember = "Descripcion";
                    comboBoxPrestamos.ValueMember = "PrestamoID";
                }
                else
                {
                    MessageBox.Show("No se encontraron préstamos activos para este cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxPrestamos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxPrestamos.SelectedItem is DataRowView row)
            {
                prestamoID = Convert.ToInt32(row["PrestamoID"]);
                CargarAmortizacion();
            }
            else
            {
                try
                {
                    prestamoID = Convert.ToInt32(comboBoxPrestamos.SelectedValue);
                    CargarAmortizacion();
                }
                catch { }
            }
        }

        private void CargarAmortizacion()
        {
            try
            {
                DataTable dt = cnAmortizacion.ObtenerAmortizacion(prestamoID);
                dgvAmortizacionCliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la amortización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarAmortizacion();
        }
    }
}

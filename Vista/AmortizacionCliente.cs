using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class AmortizacionCliente : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Amortizacion cnAmortizacion = new CN_Amortizacion();

        private int clienteID;
        private int prestamoID = 0;

        public AmortizacionCliente(int clienteID)
        {
            InitializeComponent();
            this.clienteID = clienteID;
        }

        

        private void CargarPrestamosCliente()
        {
            try
            {
                DataTable dtPrestamos = cnPrestamo.ObtenerPrestamosPorCliente(clienteID);
                MessageBox.Show("Se encontraron " + dtPrestamos.Rows.Count + " préstamos para este cliente.", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dtPrestamos != null && dtPrestamos.Rows.Count > 0)
                {
                    comboBoxPrestamos.DataSource = dtPrestamos;
                    if (dtPrestamos.Columns.Contains("Descripcion"))
                        comboBoxPrestamos.DisplayMember = "Descripcion";
                    else
                        comboBoxPrestamos.DisplayMember = "PrestamoID";
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

        private void comboBoxPrestamos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrestamos.SelectedItem is DataRowView row)
                {
                    prestamoID = Convert.ToInt32(row["PrestamoID"]);
                }
                else if (comboBoxPrestamos.SelectedValue != null)
                {
                    prestamoID = Convert.ToInt32(comboBoxPrestamos.SelectedValue);
                }
                CargarAmortizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AmortizacionCliente_Load(object sender, EventArgs e)
        {
            CargarPrestamosCliente();
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


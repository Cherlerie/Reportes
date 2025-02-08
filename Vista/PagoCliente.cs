using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;
using static Vista.Login;  

namespace Vista
{
    public partial class PagoCliente : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Pagos cnPagos = new CN_Pagos();

        private int clienteID;
        private int prestamoID = 0;

        public PagoCliente(int clienteID)
        {
            InitializeComponent();
            this.clienteID = clienteID;
        }

       

        private void CargarPrestamos()
        {
            try
            {
                DataTable dt = cnPrestamo.ObtenerPrestamosPorCliente(clienteID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBoxPrestamos.DataSource = dt;
                    comboBoxPrestamos.DisplayMember = dt.Columns.Contains("Descripcion") ? "Descripcion" : "PrestamoID";
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

       

        private void CargarHistorialPagos()
        {
            try
            {
                DataTable dt = cnPagos.ObtenerPagos(prestamoID);
                dgvHistorialPagos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montoPago;
                if (!decimal.TryParse(txtMontoPago.Text.Trim(), out montoPago) || montoPago <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Pago nuevoPago = new Pago
                {
                    ClienteID = clienteID,
                    PrestamoID = prestamoID,
                    MontoAbonado = montoPago,
                    FechaPago = DateTime.Now
                };

                cnPagos.RegistrarPago1(nuevoPago);
                MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorialPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void comboBoxPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrestamos.SelectedItem is DataRowView row)
                    prestamoID = Convert.ToInt32(row["PrestamoID"]);
                else if (comboBoxPrestamos.SelectedValue != null)
                    prestamoID = Convert.ToInt32(comboBoxPrestamos.SelectedValue);

                CargarHistorialPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarHistorialPagos();

        }

        private void PagoCliente_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarPrestamos();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;
using static Vista.Login; // Para acceder a Sesion.ClienteID

namespace Vista
{
    public partial class Pago : Form
    {
        // Instancias de las capas de negocio necesarias
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Pagos cnPagos = new CN_Pagos();

        // PrestamoID seleccionado actualmente
        private int prestamoID = 0;

        public Pago()
        {
            InitializeComponent();
        }

        // Al cargar el formulario, se cargan los préstamos y se muestra la fecha actual.
        private void Pago_Load(object sender, EventArgs e)
        {
            CargarPrestamosCliente();
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Carga en el ComboBox los préstamos activos del cliente (utilizando Sesion.ClienteID)
        private void CargarPrestamosCliente()
        {
            DataTable dt = cnPrestamo.ObtenerPrestamosPorCliente(Sesion.ClienteID);
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxIDprestamo.DataSource = dt;
                // Se asume que el DataTable tiene al menos las columnas "PrestamoID" y "Descripcion" (o puedes usar PrestamoID como texto)
                comboBoxIDprestamo.DisplayMember = "Descripcion";
                comboBoxIDprestamo.ValueMember = "PrestamoID";
            }
            else
            {
                MessageBox.Show("No se encontraron préstamos activos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Cuando se selecciona un préstamo, se actualizan los Labels con los detalles del préstamo.
        private void comboBoxIDprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDprestamo.SelectedValue != null && comboBoxIDprestamo.SelectedValue is int)
            {
                prestamoID = Convert.ToInt32(comboBoxIDprestamo.SelectedValue);
                CargarDetallesPrestamo(prestamoID);
            }
        }

        // Obtiene los detalles del préstamo seleccionado y los muestra en los Labels.
        private void CargarDetallesPrestamo(int prestamoID)
        {
            DataRow prestamo = cnPrestamo.ObtenerDetallePrestamo(prestamoID);
            if (prestamo != null)
            {
                // Se esperan las siguientes columnas en el DataRow (ajusta los nombres según tu consulta):
                // "MontoPendiente", "InteresGenerado", "FechaUltimoPago", "ProximaFechaPago", "MontoTotal"
                lblMontoaPagar.Text = prestamo["MontoPendiente"].ToString();
                lblInteresporPagar.Text = prestamo["InteresGenerado"].ToString();
                // Para la fecha del último pago y la del próximo pago, suponemos columnas llamadas "FechaUltimoPago" y "ProximaFechaPago"
                lblFechaAnterior.Text = prestamo["FechaUltimoPago"] != DBNull.Value
                                        ? Convert.ToDateTime(prestamo["FechaUltimoPago"]).ToString("dd/MM/yyyy")
                                        : "N/A";
                lblFechaSiguiente.Text = prestamo["ProximaFechaPago"] != DBNull.Value
                                        ? Convert.ToDateTime(prestamo["ProximaFechaPago"]).ToString("dd/MM/yyyy")
                                        : "N/A";
                // También se puede mostrar el monto total a pagar (opcional)
                lblTotal.Text = prestamo["MontoTotal"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para registrar el pago cuando el usuario presiona el botón.
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            decimal montoPago;
            // Validar que el monto ingresado en el TextBox sea un número válido y mayor que cero.
            if (!decimal.TryParse(txtpago.Text, out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido para el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular si se debe aplicar mora:
            decimal mora = 0;
            DateTime fechaProxima;
            if (DateTime.TryParse(lblFechaSiguiente.Text, out fechaProxima) && DateTime.Now > fechaProxima)
            {
                // Se aplica mora del 10% sobre el monto total a pagar (puedes ajustar la fórmula)
                decimal montoAProgramar = Convert.ToDecimal(lblTotal.Text);
                mora = montoAProgramar * 0.10m;
            }

            decimal montoTotalPago = montoPago + mora;

            // Registrar el pago utilizando la capa de negocio
            bool registrado = cnPagos.RegistrarPago(Sesion.ClienteID, prestamoID, montoTotalPago);
            if (registrado)
            {
                MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar la información del préstamo y el historial de pagos después del pago
                CargarDetallesPrestamo(prestamoID);
                ActualizarHistorialPagos();
            }
            else
            {
                MessageBox.Show("Error al registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualiza el DataGridView con el historial de pagos del préstamo seleccionado.
        private void ActualizarHistorialPagos()
        {
            DataTable dtHistorial = cnPagos.ObtenerHistorialPagos(prestamoID);
            dgvHistorialPagos.DataSource = dtHistorial;
        }

        // Opcional: Puedes agregar validaciones en tiempo real en el TextBox, por ejemplo en el evento TextChanged.
        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            // Aquí podrías mostrar un mensaje o cambiar el color si el formato es incorrecto.
        }
    }
}

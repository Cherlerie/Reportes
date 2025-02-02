using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;
using static Vista.Login;  // Para acceder a Sesion.ClienteID

namespace Vista
{
    public partial class Pago : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Pagos cnPagos = new CN_Pagos();

        // Variable para almacenar el préstamo seleccionado
        private int prestamoID = 0;
        // Almacenar el valor calculado de la cuota mensual
        private decimal cuotaMensual = 0;

        public Pago()
        {
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            CargarPrestamosCliente();
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Cargar los préstamos activos del cliente en el ComboBox
        private void CargarPrestamosCliente()
        {
            DataTable dt = cnPrestamo.ObtenerPrestamosPorCliente(Sesion.ClienteID);
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxIDprestamo.DataSource = dt;
                // Asegúrate de que el DataTable incluya una columna "Descripcion" o usa "PrestamoID" para mostrar
                comboBoxIDprestamo.DisplayMember = "Descripcion";
                comboBoxIDprestamo.ValueMember = "PrestamoID";
            }
            else
            {
                MessageBox.Show("No se encontraron préstamos activos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Al cambiar la selección en el ComboBox, actualiza los detalles del préstamo
        private void comboBoxIDprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDprestamo.SelectedItem is DataRowView row)
            {
                prestamoID = Convert.ToInt32(row["PrestamoID"]);
                CargarDetallesPrestamo(prestamoID);
                ActualizarHistorialPagos();
            }
        }

        // Método para calcular la cuota mensual usando la fórmula del Sistema Francés
        private decimal CalcularCuotaMensual(CE_Prestamo prestamo)
        {
            decimal P = prestamo.MontoPrestamo;
            int n = prestamo.TiempoMeses;
            decimal i = 0;

            // Determinar la tasa mensual según el plazo
            if (n >= 1 && n <= 3)
                i = 0.10m / 12;
            else if (n >= 4 && n <= 6)
                i = 0.08m / 12;
            else if (n >= 7 && n <= 12)
                i = 0.07m / 12;
            else
                i = 0.05m / 12;

            decimal cuota = P * (i * (decimal)Math.Pow((double)(1 + i), n)) / ((decimal)Math.Pow((double)(1 + i), n) - 1);
            return cuota;
        }

        // Cargar detalles del préstamo seleccionado y calcular la cuota mensual
        private void CargarDetallesPrestamo(int prestamoID)
        {
            DataRow prestamoRow = cnPrestamo.ObtenerDetallePrestamo(prestamoID);
            if (prestamoRow != null)
            {
                // Asumimos que la consulta devuelve:
                // "MontoPendiente", "InteresGenerado", "MontoTotal", y "FechaInicio"
                lblMontoaPagar.Text = prestamoRow["MontoPendiente"].ToString();
                lblInteresporPagar.Text = prestamoRow["InteresGenerado"].ToString();
                lblFechaAnterior.Text = prestamoRow["FechaInicio"] != DBNull.Value
                                        ? Convert.ToDateTime(prestamoRow["FechaInicio"]).ToString("dd/MM/yyyy")
                                        : "N/A";
                // La fecha siguiente se calcula como 30 días después de la fecha actual
                lblFechaSiguiente.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
                lblTotal.Text = prestamoRow["MontoTotal"].ToString();

                // Para calcular la cuota mensual, primero necesitamos crear un objeto CE_Prestamo.
                // Suponemos que la clase CE_Prestamo tiene las propiedades MontoPrestamo y TiempoMeses.
                CE_Prestamo prestamo = new CE_Prestamo
                {
                    PrestamoID = Convert.ToInt32(prestamoRow["PrestamoID"]),
                    MontoPrestamo = Convert.ToDecimal(prestamoRow["MontoPrestamo"]),
                    TiempoMeses = Convert.ToInt32(prestamoRow["TiempoMeses"])
                };

                cuotaMensual = CalcularCuotaMensual(prestamo);
                // Mostrar la cuota mensual en el label correspondiente.
                lblMontoMes.Text = cuotaMensual.ToString("N2");
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Registrar el pago
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            decimal montoPago;
            if (!decimal.TryParse(txtpago.Text, out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido para el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si el monto ingresado es igual o superior a la cuota mensual, consideramos que cubre la cuota.
            // Si es exactamente igual a la cuota, se muestran 000 en los labels de "Monto a Pagar" y "Interés a Pagar".
            bool pagaCompleto = montoPago >= cuotaMensual;

            // Calcular mora si el pago se realiza después de la fecha límite
            decimal mora = 0;
            DateTime fechaSiguiente;
            if (DateTime.TryParse(lblFechaSiguiente.Text, out fechaSiguiente) && DateTime.Now > fechaSiguiente)
            {
                // Se aplica una mora del 10% sobre el monto total a pagar.
                decimal montoTotal = Convert.ToDecimal(lblTotal.Text);
                mora = montoTotal * 0.10m;
            }
            decimal montoTotalPago = montoPago + mora;

            // Registrar el pago usando la capa de negocio
            bool registrado = cnPagos.RegistrarPago(Sesion.ClienteID, prestamoID, montoTotalPago);
            if (registrado)
            {
                MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar detalles y el historial de pagos
                CargarDetallesPrestamo(prestamoID);
                ActualizarHistorialPagos();
                // Si el pago cubre la cuota, se muestran "000" en los labels de interés y monto a pagar.
                if (pagaCompleto)
                {
                    lblMontoaPagar.Text = "000";
                    lblInteresporPagar.Text = "000";
                }
            }
            else
            {
                MessageBox.Show("Error al registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualiza el DataGridView del historial de pagos
        private void ActualizarHistorialPagos()
        {
            DataTable dtHistorial = cnPagos.ObtenerHistorialPagos(prestamoID);
            dgvHistorialPagos.DataSource = dtHistorial;
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar validaciones en tiempo real aquí si es necesario.
        }
    }
}

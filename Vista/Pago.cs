using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;
using static Vista.Login;  

namespace Vista
{
    public partial class Pago : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Pagos cnPagos = new CN_Pagos();

        private int prestamoID = 0;
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

        private void CargarPrestamosCliente()
        {
            DataTable dt = cnPrestamo.ObtenerPrestamosPorCliente(Sesion.ClienteID);
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxIDprestamo.DataSource = dt;
                comboBoxIDprestamo.DisplayMember = "Descripcion";
                comboBoxIDprestamo.ValueMember = "PrestamoID";
            }
            else
            {
                MessageBox.Show("No se encontraron préstamos activos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxIDprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDprestamo.SelectedItem is DataRowView row)
            {
                prestamoID = Convert.ToInt32(row["PrestamoID"]);
                CargarDetallesPrestamo(prestamoID);
                ActualizarHistorialPagos();
            }
        }

        private decimal CalcularCuotaMensual(CE_Prestamo prestamo)
        {
            decimal P = prestamo.MontoPrestamo;
            int n = prestamo.TiempoMeses;
            decimal i = 0;

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

        private void CargarDetallesPrestamo(int prestamoID)
        {
            DataRow prestamoRow = cnPrestamo.ObtenerDetallePrestamo(prestamoID);
            if (prestamoRow != null)
            {
                lblMontoaPagar.Text = prestamoRow["MontoPendiente"].ToString();
                lblInteresporPagar.Text = prestamoRow["InteresGenerado"].ToString();
                lblFechaAnterior.Text = prestamoRow["FechaInicio"] != DBNull.Value
                                        ? Convert.ToDateTime(prestamoRow["FechaInicio"]).ToString("dd/MM/yyyy")
                                        : "N/A";
                lblFechaSiguiente.Text = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
                lblTotal.Text = prestamoRow["MontoTotal"].ToString();

                CE_Prestamo prestamo = new CE_Prestamo
                {
                    PrestamoID = Convert.ToInt32(prestamoRow["PrestamoID"]),
                    MontoPrestamo = Convert.ToDecimal(prestamoRow["MontoPrestamo"]),
                    TiempoMeses = Convert.ToInt32(prestamoRow["TiempoMeses"])
                };

                cuotaMensual = CalcularCuotaMensual(prestamo);
                lblMontoMes.Text = cuotaMensual.ToString("N2");
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            decimal montoPago;
            if (!decimal.TryParse(txtpago.Text, out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido para el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            bool pagaCompleto = montoPago >= cuotaMensual;

            decimal mora = 0;
            DateTime fechaSiguiente;
            if (DateTime.TryParse(lblFechaSiguiente.Text, out fechaSiguiente) && DateTime.Now > fechaSiguiente)
            {
                decimal montoTotal = Convert.ToDecimal(lblTotal.Text);
                mora = montoTotal * 0.10m;
            }
            decimal montoTotalPago = montoPago + mora;

            bool registrado = cnPagos.RegistrarPago(Sesion.ClienteID, prestamoID, montoTotalPago);
            if (registrado)
            {
                MessageBox.Show("Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDetallesPrestamo(prestamoID);
                ActualizarHistorialPagos();
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

        private void ActualizarHistorialPagos()
        {
            DataTable dtHistorial = cnPagos.ObtenerHistorialPagos(prestamoID);
            dgvHistorialPagos.DataSource = dtHistorial;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

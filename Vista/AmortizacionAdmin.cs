using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class AmortizacionAdmin : Form
    {
        private CN_Cliente cnCliente = new CN_Cliente();
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Amortizacion cnAmortizacion = new CN_Amortizacion();

        private int clienteID = 0;
        private int prestamoID = 0;

        public AmortizacionAdmin()
        {
            InitializeComponent();
        }

      

        private void CargarClientes()
        {
            try
            {
                DataTable dtClientes = cnCliente.ObtenerClientes();
                if (dtClientes != null && dtClientes.Rows.Count > 0)
                {
                    if (!dtClientes.Columns.Contains("NombreCompleto"))
                        dtClientes.Columns.Add("NombreCompleto", typeof(string), "Nombre + ' ' + Apellido");
                    comboBoxClientes.DataSource = dtClientes;
                    comboBoxClientes.DisplayMember = "NombreCompleto";
                    comboBoxClientes.ValueMember = "ClienteID";
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void CargarPrestamos(int clienteID)
        {
            try
            {
                DataTable dtPrestamos = cnPrestamo.ObtenerPrestamosPorCliente(clienteID);
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
                    MessageBox.Show("No se encontraron préstamos para el cliente seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxPrestamos.DataSource = null;
                    dgvAmortizacionAdmin.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void CargarAmortizacion(int prestamoID)
        {
            try
            {
                DataTable dt = cnAmortizacion.ObtenerAmortizacion(prestamoID);
                dgvAmortizacionAdmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la amortización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        

        private void AmortizacionAdmin_Load_1(object sender, EventArgs e)
        {
            CargarClientes();
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxPrestamos.SelectedValue != null)
            {
                int prestamoID = Convert.ToInt32(comboBoxPrestamos.SelectedValue);
                CargarAmortizacion(prestamoID);
            }
        }

        private void comboBoxPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrestamos.SelectedItem is DataRowView row)
                    prestamoID = Convert.ToInt32(row["PrestamoID"]);
                else
                    prestamoID = Convert.ToInt32(comboBoxPrestamos.SelectedValue);

                CargarAmortizacion(prestamoID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClientes.SelectedItem is DataRowView row)
                    clienteID = Convert.ToInt32(row["ClienteID"]);
                else if (comboBoxClientes.SelectedValue != null)
                    clienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);

                CargarPrestamos(clienteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class BuscarPagos : Form
    {
        private CN_Cliente cnCliente = new CN_Cliente();
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Pagos cnPago = new CN_Pagos();

        private int clienteID = 0;
        private int prestamoID = 0;

        public BuscarPagos()
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
                    comboBoxPrestamos.DisplayMember = dtPrestamos.Columns.Contains("Descripcion") ? "Descripcion" : "PrestamoID";
                    comboBoxPrestamos.ValueMember = "PrestamoID";
                }
                else
                {
                    MessageBox.Show("No se encontraron préstamos para el cliente seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxPrestamos.DataSource = null;
                    dgvPagos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void CargarHistorialPagos()
        {
            try
            {
                DataTable dt = cnPago.ObtenerPagos(prestamoID);
                dgvPagos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarHistorialPagos();

        }

        private void comboBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
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
                MessageBox.Show("Error al seleccionar préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPagos_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarClientes();
        }
    }
}


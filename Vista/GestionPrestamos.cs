using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class GestionPrestamos : Form
    {
        private CN_Prestamo cnPrestamo = new CN_Prestamo();
        private CN_Cliente cnCliente = new CN_Cliente();

        public GestionPrestamos()
        {
            InitializeComponent();
        }

        private void GestionPrestamos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarPrestamosDataGrid();
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

      
        

        private void CargarPrestamosDataGrid(int clienteID)
        {
            try
            {
                DataTable dtPrestamos = cnPrestamo.ObtenerPrestamosPorCliente(clienteID);
               dataGridView1.DataSource = dtPrestamos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamosDataGrid()
        {
            try
            {
              
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);

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
                    CargarPrestamosDataGrid(clienteID);
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

       

        private void comboBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int clienteID = 0;
                if (comboBoxClientes.SelectedItem is DataRowView row)
                {
                    clienteID = Convert.ToInt32(row["ClienteID"]);
                }
                else if (comboBoxClientes.SelectedValue != null)
                {
                    clienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                }
                CargarPrestamosDataGrid(clienteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedValue != null)
            {
                int clienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                CargarPrestamosDataGrid(clienteID);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



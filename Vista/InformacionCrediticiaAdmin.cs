using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class InformacionCrediticiaAdmin : Form
    {
        private CN_InformacionCrediticia cnInfo = new CN_InformacionCrediticia();
        private CN_Clientes cnClientes = new CN_Clientes();

        public InformacionCrediticiaAdmin()
        {
            InitializeComponent();
        }

        private void InformacionCrediticiaAdmin_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dtClientes = cnClientes.ObtenerClientes();
                if (dtClientes != null && dtClientes.Rows.Count > 0)
                {
                    comboBox1.DataSource = dtClientes;
                    comboBox1.DisplayMember = "Nombre"; 
                    comboBox1.ValueMember = "ClienteID";
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

       

        private void CargarInformacionCrediticia(int clienteID)
        {
            try
            {
                DataTable dt = cnInfo.ObtenerInformacionCrediticia(clienteID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblClienteID.Text = row["ClienteID"].ToString();
                    lblNombre.Text = row["Nombre"].ToString();
                    lblApellido.Text = row["Apellido"].ToString();
                    lblCorreo.Text = row["Correo"].ToString();
                    lblTelefono.Text = row["Telefono"].ToString();
                    lblDireccion.Text = row["Direccion"].ToString();
                    lblUsuario.Text = row["Usuario"].ToString();
                    lblSueldo.Text = row["Sueldo"].ToString();
                    lblGarantia.Text = row["Garantia"].ToString();
                    lblNumeroPrestamos.Text = row["NumeroPrestamos"].ToString();
                    lblTotalPrestado.Text = row["TotalPrestado"].ToString();
                    lblMorasAcumuladas.Text = row["MorasAcumuladas"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró información crediticia para el cliente seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información crediticia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int clienteID = 0;
                if (comboBox1.SelectedItem is DataRowView row)
                {
                    clienteID = Convert.ToInt32(row["ClienteID"]);
                }
                else if (comboBox1.SelectedValue != null)
                {
                    clienteID = Convert.ToInt32(comboBox1.SelectedValue);
                }
                CargarInformacionCrediticia(clienteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

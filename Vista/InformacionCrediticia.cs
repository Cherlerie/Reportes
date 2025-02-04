using System;
using System.Data;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class InformacionCrediticia : Form
    {
        private CN_InformacionCrediticia cnInfo = new CN_InformacionCrediticia();
        private int clienteID;

        public InformacionCrediticia(int clienteID)
        {
            InitializeComponent();
            this.clienteID = clienteID;
        }

        private void InformacionCrediticia_Load(object sender, EventArgs e)
        {
            CargarInformacionCrediticia();
        }

        private void CargarInformacionCrediticia()
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
                }
                else
                {
                    MessageBox.Show("No se encontró información crediticia para este cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información crediticia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

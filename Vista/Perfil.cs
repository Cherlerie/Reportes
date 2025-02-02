using System;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class Perfil : Form
    {
        private CN_Perfil cnPerfil = new CN_Perfil();
        private int clienteID;

        public Perfil(int clienteID)
        {
            InitializeComponent();
            this.clienteID = clienteID;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            CargarPerfil();
        }

        private void CargarPerfil()
        {
            try
            {
                CE_perfil perfil = cnPerfil.ObtenerPerfil(clienteID);
                if (perfil != null)
                {
                    lblNombre.Text = perfil.Nombre1;
                    lblApellido.Text = perfil.Apellido1;
                    lblUsuario.Text = perfil.Usuario1;
                    lblEmail.Text = perfil.Correo;
                    lblTelefono.Text = perfil.Telefono1;

                    txtNombrePerfilCliente.Text = perfil.Nombre1;
                    txtApellidoPerfilCliente.Text = perfil.Apellido1;
                    txtusuarioPerfilCliente.Text = perfil.Usuario1;
                    txtCorreoPerfilCliente.Text = perfil.Correo;
                    txtTelefonoPerfilCliente.Text = perfil.Telefono1;
                    txtDireccionPerfilCliente.Text = perfil.Direccion1;
                    txtContraseñaPerfilCliente.Text = perfil.Contraseña1;
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la información del perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el perfil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                CE_perfil perfil = new CE_perfil
                {
                    ClienteID1 = clienteID,
                    Nombre1 = txtNombrePerfilCliente.Text,
                    Apellido1 = txtApellidoPerfilCliente.Text,
                    Usuario1 = txtusuarioPerfilCliente.Text,
                    Correo = txtCorreoPerfilCliente.Text,
                    Telefono1 = txtTelefonoPerfilCliente.Text,
                    Direccion1 = txtDireccionPerfilCliente.Text,
                    Contraseña1 = txtContraseñaPerfilCliente.Text
                };

                bool resultado = cnPerfil.EditarPerfil(perfil);
                if (resultado)
                {
                    MessageBox.Show("Perfil actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    CargarPerfil();  
                }
                else
                {
                    MessageBox.Show("Error al actualizar el perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el perfil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;

        }

        private void btnCancelarPerfil_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
    }
}

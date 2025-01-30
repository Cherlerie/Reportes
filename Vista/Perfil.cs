using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;
using static Vista.Login;

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
            CargarPerfil();

        }
        private void CargarPerfil()
        {
            CE_perfil perfil = cnPerfil.ObtenerPerfil(clienteID);
            if (perfil != null)
            {

                lblUsuario.Text = perfil.Usuario1;
                lblApellido.Text = perfil.Apellido1;
                lblNombre.Text = perfil.Nombre1;
                lblEmail.Text = perfil.Correo;
                lblTelefono.Text = perfil.Telefono1;
               



                txtNombrePerfilCliente.Text = perfil.Nombre1;
                txtApellidoPerfilCliente.Text = perfil.Apellido1;
                txtCorreoPerfilCliente.Text = perfil.Correo;
                txtDireccionPerfilCliente.Text = perfil.Direccion1;
                txtTelefonoPerfilCliente.Text = perfil.Telefono1;
                txtContraseñaPerfilCliente.Text = perfil.Contraseña1;
                txtusuarioPerfilCliente.Text = perfil.Usuario1;


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

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            CE_perfil perfil = new CE_perfil
            {
                ClienteID1 = clienteID,
                Nombre1 = txtusuarioPerfilCliente.Text,
                Apellido1 = txtApellidoPerfilCliente.Text,
                Correo = txtCorreoPerfilCliente.Text,
                Direccion1 = txtDireccionPerfilCliente.Text,
                Telefono1 = txtTelefonoPerfilCliente.Text,
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

        private void Perfil_Load(object sender, EventArgs e)
        {
            CN_Perfil cnPerfil = new CN_Perfil();
            CE_perfil perfil = cnPerfil.ObtenerPerfil(Sesion.ClienteID);

            if (perfil != null)
            {
                lblNombre.Text = perfil.Nombre1;
                lblApellido.Text = perfil.Apellido1;
                lblUsuario.Text = perfil.Usuario1;
                lblEmail.Text = perfil.Correo;
                lblTelefono.Text = perfil.Telefono1;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del perfil.");
            }

        }
    }
    
}

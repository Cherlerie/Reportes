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

namespace Login
{
    public partial class Form1 : Form
    {
        private CN_Login loginNegocio = new CN_Login();

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Login usuario = new CE_Login
                {
                    UsuarioNombre = txtUsuario.Text,
                    Contraseña = txtContraseña.Text
                };

                // Obtenemos el rol y el ClienteID
                var (rol, clienteID) = loginNegocio.ValidarUsuario(usuario);

                if (!string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show($"Bienvenido. Rol: {rol}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si es Administrador
                    if (rol == "Administrador")
                    {
                        Administrador adminForm = new Administrador();
                        adminForm.Show();
                    }
                    // Si es Cliente
                    else if (rol == "Cliente")
                    {
                        // Pasamos el ClienteID al formulario Cliente
                        Clientes clienteForm = new Clientes(clienteID);
                        clienteForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

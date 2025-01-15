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


                string rol = loginNegocio.ValidarUsuario(usuario);

                MessageBox.Show($"Bienvenido. Rol: {rol}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

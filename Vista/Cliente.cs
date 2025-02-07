using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Pjr_Capa_Presentacion;

namespace Vista 
{
    public partial class Cliente : Form
    {
        private int ClienteID;
        public Cliente(int clienteID)
        {
            InitializeComponent();
            this.ClienteID = clienteID;

        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"ClienteID recibido: {ClienteID}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptcompras_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfil PerfilForm = new Perfil(ClienteID);
            PerfilForm.Show();

            Administrador.Controls.Clear();

            PerfilForm.TopLevel = false;

            PerfilForm.Dock = DockStyle.Fill; 

            Administrador.Controls.Add(PerfilForm);

           
            PerfilForm.Show();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Moras MorasForm = new Moras(ClienteID);

            Administrador.Controls.Clear();

            MorasForm.TopLevel = false;

            MorasForm.Dock = DockStyle.Fill;

            Administrador.Controls.Add(MorasForm);

            MorasForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pago PagoForm = new Pago();
            PagoForm.Show();

            Administrador.Controls.Clear();

            PagoForm.TopLevel = false;

            PagoForm.Dock = DockStyle.Fill;

            Administrador.Controls.Add(PagoForm);


            PagoForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmortizacionCliente AmortizacionClienteForm = new AmortizacionCliente(ClienteID);
            AmortizacionClienteForm.Show();

            Administrador.Controls.Clear();

            AmortizacionClienteForm.TopLevel = false;

            AmortizacionClienteForm.Dock = DockStyle.Fill;

            Administrador.Controls.Add(AmortizacionClienteForm);


            AmortizacionClienteForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InformacionCrediticiaCliente InformacionCrediticiaForm = new InformacionCrediticiaCliente(ClienteID);
            InformacionCrediticiaForm.Show();

            Administrador.Controls.Clear();

            InformacionCrediticiaForm.TopLevel = false;

            InformacionCrediticiaForm.Dock = DockStyle.Fill;

            Administrador.Controls.Add(InformacionCrediticiaForm);


            InformacionCrediticiaForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

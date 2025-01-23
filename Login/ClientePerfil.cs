using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ClientePerfil : Form
    {
        private int clienteID;
        public ClientePerfil()
        {
            InitializeComponent();
            this.clienteID = clienteID;
        }

        private void ClientePerfil_Load(object sender, EventArgs e)
        {
             CargarDatosCliente(clienteID);
        }

    }
}

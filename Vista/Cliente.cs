using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

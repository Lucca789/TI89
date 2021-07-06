using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI89
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

       

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtEmail.Text);
            cliente.Inserir();
            MessageBox.Show(cliente.mensagem, "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtID.Text = Convert.ToString(cliente.id);
        }
    }
}

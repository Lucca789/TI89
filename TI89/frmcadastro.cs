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
            btnAlterar.Enabled = false;
            btnExluir.Enabled = false;
        }
        public void Limpa()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtEmail.Text);
            cliente.Inserir();
            MessageBox.Show(cliente.mensagem, "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtID.Text = Convert.ToString(cliente.id);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            //Cliente cliente = new Cliente();
            //// Testando verfificação
            //if (txtID.Text == string.Empty)
            //{
            //    MessageBox.Show("Informar o ID", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtID.Focus();
            //    return;
            //}
            //else
            //{
               
            //    cliente.consultar(Convert.ToInt32(txtID.Text));

            //}
            ////verificar o valor da variavel que encontrou
            //if (cliente.achou == true)
            //{
            //    txtNome.Text = cliente.Nome;
            //    txtEmail.Text = cliente.Email;
            //    btnAlterar.Enabled = true;
            //    btnExluir.Enabled = true;
               
            //}
            //else
            //{
            //    MessageBox.Show(cliente.mensagem, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnAlterar.Enabled = false;
            //    btnExluir.Enabled = false;
            //}
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(Convert.ToInt32(txtID.Text),txtNome.Text,txtEmail.Text);
            cliente.Alterar();
            MessageBox.Show(cliente.mensagem, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpa();
        }

        private void btnBusca_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            // Testando verfificação
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Informar o ID", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return;
            }
            else
            {

                cliente.consultar(Convert.ToInt32(txtID.Text));

            }
            //verificar o valor da variavel que encontrou
            if (cliente.achou == true)
            {
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                btnAlterar.Enabled = true;
                btnExluir.Enabled = true;

            }
            else
            {
                MessageBox.Show(cliente.mensagem, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAlterar.Enabled = false;
                btnExluir.Enabled = false;
            }
        }
    }
}

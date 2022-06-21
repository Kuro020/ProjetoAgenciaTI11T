using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;
using System.IO;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCod.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCod.Text = Clientes.CodigoCli.ToString();
                tbxNome.Text = Clientes.NomeCli;
                tbxEmail.Text = Clientes.EmailCli;
                tbxSenha.Text = Clientes.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImageCli);
                pbxImagem.Image = Image.FromStream(ms);
                
            }
            if (Clientes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
        }
    }
}

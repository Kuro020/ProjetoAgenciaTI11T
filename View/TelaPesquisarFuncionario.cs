using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxCod.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCod.Text = Funcionario.CodigoFun.ToString();
                tbxNome.Text = Funcionario.NomeFun;
                tbxEmail.Text = Funcionario.EmailFun;
                tbxSenha.Text = Funcionario.SenhaFun;

            }
            if (Funcionario.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                return;
            }
        }
    }
}

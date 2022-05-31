using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(tbxNome.Text == ""| tbxEmail.Text == ""| tbxSenha.Text == ""| pbxImagem.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

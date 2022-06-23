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
    public partial class TelaPesquisarPacotes : Form
    {
        public TelaPesquisarPacotes()
        {
            InitializeComponent();
        }

        private void btnCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
                dtpIda.Text = string.Empty;
                dtpVolta.Text = string.Empty;
                tbxDestino.Text = string.Empty;
            }
            else
            {
                Pacotes.CodigoPac = Convert.ToInt32(tbxCod.Text);
                ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                manipulaPacotes.pesquisaCodPac();

                tbxCod.Text = Pacotes.CodigoPac.ToString();
                tbxValor.Text =  Convert.ToString(Pacotes.ValorPac);
                tbxOrigem.Text = Pacotes.OrigemPac;
                tbxDestino.Text = Pacotes.DestinoPac;
                dtpIda.Text = Pacotes.DataidaPac;
                dtpVolta.Text = Pacotes.DatavoltaPac;
                rtbDescricao.Text = Pacotes.DescricaoPac;

                MemoryStream ms = new MemoryStream((byte[])Pacotes.ImagePac);
                pbxImagem.Image = Image.FromStream(ms);

            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
                dtpIda.Text = string.Empty;
                dtpVolta.Text = string.Empty;
                rtbDescricao.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
        }
    }
}

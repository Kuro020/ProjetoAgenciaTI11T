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
                dtpIda.Value = DateTime.Now;
                dtpVolta.Value = DateTime.Now;
                tbxDestino.Text = string.Empty;
            }
            else
            {
                Pacotes.CodigoPac = Convert.ToInt32(tbxCod.Text);
                ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                manipulaPacotes.pesquisaCodPac();
            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
                dtpIda.Value = DateTime.Now;
                dtpVolta.Value = DateTime.Now;
                rtbDescricao.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
            else
            {
                tbxCod.Text = Pacotes.CodigoPac.ToString();
                tbxValor.Text = Convert.ToString(Pacotes.ValorPac);
                tbxOrigem.Text = Pacotes.OrigemPac;
                tbxDestino.Text = Pacotes.DestinoPac;
                dtpIda.Value = Pacotes.DataidaPac;
                dtpVolta.Value = Pacotes.DatavoltaPac;
                rtbDescricao.Text = Pacotes.DescricaoPac;

                MemoryStream ms = new MemoryStream((byte[])Pacotes.ImagePac);
                pbxImagem.Image = Image.FromStream(ms);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
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
                rtbDescricao.Text = string.Empty;
                pbxImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Pacote " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.CodigoPac = Convert.ToInt32(tbxCod.Text);

                    ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                    manipulaPacotes.deletarPac();
                }

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

        private void btnAlterar_Click(object sender, EventArgs e)
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
                rtbDescricao.Text = string.Empty;
                pbxImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Pacote " + tbxCod.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.CodigoPac = Convert.ToInt32(tbxCod.Text);
                    Pacotes.ValorPac = Convert.ToInt32(tbxCod.Text);
                    Pacotes.OrigemPac = tbxOrigem.Text;
                    Pacotes.DestinoPac = tbxDestino.Text;
                    Pacotes.DataidaPac = Convert.ToDateTime(dtpIda.Value);
                    Pacotes.DatavoltaPac = Convert.ToDateTime(dtpVolta.Text);
                    Pacotes.DescricaoPac = rtbDescricao.Text;

                    MemoryStream ms = new MemoryStream();
                    pbxImagem.Image.Save(ms, pbxImagem.Image.RawFormat);

                    Pacotes.ImagePac = ms.ToArray();

                    ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                    manipulaPacotes.alterarPac();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxOrigem.Text = string.Empty;
                tbxDestino.Text = string.Empty;
                dtpIda.Value = DateTime.Now;
                dtpVolta.Value = DateTime.Now;
                rtbDescricao.Text = string.Empty;
                pbxImagem.Image = null;
                return;
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg;*.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }
    }
}

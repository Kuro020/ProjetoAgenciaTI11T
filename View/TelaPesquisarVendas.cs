﻿using System;
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
    public partial class TelaPesquisarVendas : Form
    {
        public TelaPesquisarVendas()
        {
            InitializeComponent();
        }

        private void btnCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de vendas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
            }
            else
            {
                Vendas.CodigoVen = Convert.ToInt32(tbxCod.Text);
                ManipulaVendas manipulaPacotes = new ManipulaVendas();
                manipulaPacotes.pesquisaCodVen();
            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                return;
            }
            else
            {
                tbxCod.Text = Vendas.CodigoVen.ToString();
                tbxValor.Text = Convert.ToString(Vendas.PagoVen);
                tbxCodCli.Text = Clientes.CodigoCli.ToString();
                tbxCodFun.Text = Funcionario.CodigoFun.ToString();
                tbxCodPac.Text = Pacotes.CodigoPac.ToString();
            }
        }
    }
}

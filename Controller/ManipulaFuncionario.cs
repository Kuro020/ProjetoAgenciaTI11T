﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = System.Windows.Forms.MessageBox.Show("Cadastro do funcionario efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation
                    );

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.Retorno = "Sim";
                    return;
                }
                else
                {
                    Funcionario.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
    }
}

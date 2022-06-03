using System;
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
    class ManipulaPacotes
    {
        public void cadastrarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
                cmd.Parameters.AddWithValue("@dataidaPac", Pacotes.DataidaPac);
                cmd.Parameters.AddWithValue("@datavoltaPac", Pacotes.DatavoltaPac);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacotes.DescricaoPac);
                cmd.Parameters.AddWithValue("@imagemPac", Pacotes.ImagePac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do pacote efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation
                    );

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacotes.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarCliente",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli","Maria da Graça");
                cmd.Parameters.AddWithValue("@emailCli","maria@email.com");
                cmd.Parameters.AddWithValue("@senhaCli","123");
                cmd.Parameters.AddWithValue("@imagemCli","");
            }
        }
    }
}

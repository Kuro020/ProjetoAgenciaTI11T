using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Pacotes
    {
        private static int codigoPac;
        private static double valorPac;
        private static string origemPac;
        private static string destinoPac;
        private static string dataidaPac;
        private static string datavoltaPac;
        private static string descricaoPac;
        private static Array imagePac;
        private static string retorno;

        public static int CodigoPac { get => codigoPac; set => codigoPac = value; }
        public static double ValorPac { get => valorPac; set => valorPac = value; }
        public static string OrigemPac { get => origemPac; set => origemPac = value; }
        public static string DestinoPac { get => destinoPac; set => destinoPac = value; }
        public static string DataidaPac { get => dataidaPac; set => dataidaPac = value; }
        public static string DatavoltaPac { get => datavoltaPac; set => datavoltaPac = value; }
        public static string DescricaoPac { get => descricaoPac; set => descricaoPac = value; }
        public static Array ImagePac { get => imagePac; set => imagePac = value; }
        public static string Retorno { get => retorno; set => retorno = value; }



    }
}

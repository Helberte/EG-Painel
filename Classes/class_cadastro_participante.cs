using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EGP_PAINEL.Classes
{
    public class class_cadastro_participante
    {

        Conexao conexao;
        //string comando = "";

        public class_cadastro_participante()
        {
            this.conexao = new Conexao();
        }


        public SqlDataReader Retorna_funcoes()
        {
            //comando = "select * from funcao";

            using (SqlCommand cmd = new SqlCommand())
            {

            }
            return null;
        }
    }
}

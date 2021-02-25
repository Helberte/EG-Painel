using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EGP_PAINEL.Classes
{
    public class Conexao
    {        
        string strConexao = "";
        SqlConnection conection;
        ArquivoConexao arquivoConexao;

        public Conexao()
        {
            arquivoConexao = new ArquivoConexao();

            if (arquivoConexao.LerArquivo())
            {
                strConexao = "Data Source=" + arquivoConexao.Ip + ";Initial Catalog=EGP;User ID=" +
                    "" + arquivoConexao.Usuario + ";Password=" + arquivoConexao.Senha + "";

                conection = new SqlConnection(strConexao);
            }                     
        }

        public SqlConnection Abre()
        {
            if (conection.State == ConnectionState.Closed)
                conection.Open();

            return conection;
        }

        public void Fecha()
        {
            if (conection.State == ConnectionState.Open)
                conection.Close();
        }
    }
}

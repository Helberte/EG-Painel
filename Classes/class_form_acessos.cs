using EGP_PAINEL.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_Tela_Inicial_04_02.Classes
{
    public class class_form_acessos
    {
        Conexao conexao;
        string consulta = "";

        SqlDataReader reader;
        SqlCommand command;

        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommandBuilder builder;

        public class_form_acessos()
        {
            this.conexao = new Conexao();
        }


        public DataSet RetornaUsuarios()
        {
            consulta = "exec usp_retorna_usuarios";

            try
            {
                using (adapter = new SqlDataAdapter(consulta, conexao.Abre()))
                {
                    using (dataSet = new DataSet())
                    {
                        using (builder = new SqlCommandBuilder(adapter))
                        {
                            adapter.Fill(dataSet);
                            conexao.Fecha();
                            return dataSet;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                conexao.Fecha();
                MessageBox.Show("Erro Banco de Dados: " + e.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

using EGP_PAINEL.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_Tela_Inicial_04_02.Formulario_login_inicial;

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

        public string RetornaPermissoesUsuario(int id_usuario)
        {
            string acessos_usuario = "";
            string comando = "exec usp_retorna_permissoes_usuario " + id_usuario;

            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                        acessos_usuario += reader["ID_USUARIO"].ToString() + "_" +
                                           reader["ID_MENU_ITENS_SUSPENSOS"].ToString() + "_" +
                                           reader["ID_ACESSOS"].ToString() + "_" +
                                           reader["POSICAO_MENU"].ToString() + "_" + 
                                           reader["NOME_ITEM"].ToString() + "_" + 
                                           reader["ACESSO"].ToString() + "_" + 
                                           reader["ALTERAR"].ToString() + "_" +
                                           reader["NOVO"].ToString() + "_" +
                                           reader["NOME_MENU"].ToString() + "\n";


                    conexao.Fecha();
                    return acessos_usuario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao analisar os menus existentes. " +
                    "Metodo = Nomes_menu_principal" + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    conexao.Fecha();
                    return null;
                }
            }
        }
    }
}

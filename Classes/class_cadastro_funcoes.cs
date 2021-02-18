using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EGP_PAINEL.Classes
{
    public class class_cadastro_funcoes
    {
        public string Mensagem_Retorno { get; private set; }
        public int ID { get; private set; }


        string comando;

        Conexao conexao;
        SqlCommand cmd;
        SqlDataReader reader;

        //  classes para o grid

        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommandBuilder builder;


        public class_cadastro_funcoes()
        {
            conexao = new Conexao();
        }

       
        public bool Insert(string nome, string descricao)
        {
            bool retorno = false;
            comando = "exec usp_funcao " + "'n', '" + nome + "', '" + descricao + "'";

            using (cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = comando;
                    cmd.CommandTimeout = 300;
                    cmd.Connection = conexao.Abre(); // retorna o objeto sqlconnection e já abre a conexão

                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = reader["message"].ToString();
                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        this.ID = Convert.ToInt32(reader["id"].ToString());
                        this.Mensagem_Retorno = "Cadastrado com sucesso!";
                        retorno = true;
                    }

                    conexao.Fecha();
                }
                catch (SqlException e)
                {
                    conexao.Fecha();
                    retorno = false;

                    this.Mensagem_Retorno = "Erro no banco: " + e.ToString();
                }       
            }
            return retorno;
        }

        public DataSet PreencheGrid(string consulta)
        {
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

        public bool Delete(int ID)
        {
            bool retorno = false;
            comando = "exec usp_funcao " + "'e', null, null, null, " + ID;

            using (cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = comando;
                    cmd.CommandTimeout = 300;
                    cmd.Connection = conexao.Abre(); // retorna o objeto sqlconnection e já abre a conexão

                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = "\n";

                        do
                        {
                            this.Mensagem_Retorno += reader["message"].ToString().ToUpper() + "\n";

                        } while (reader.Read());                                                                        
                                                                                                                
                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        this.Mensagem_Retorno = "Excluído com sucesso!";
                        retorno = true;
                    }

                    conexao.Fecha();
                }
                catch (SqlException e)
                {
                    conexao.Fecha();
                    retorno = false;

                    this.Mensagem_Retorno = "Erro no banco: " + e.ToString();
                }
            }
            return retorno;
        }

        // ALTERAR

        public bool Update(string nome, string descricao, string serial_camara, int ID)
        {
            bool retorno = false;
            comando = "exec usp_funcao " + "'a', '" + nome + "', '" + descricao + "', " + serial_camara + ", " + ID;

            using (cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = comando;
                    cmd.CommandTimeout = 300;
                    cmd.Connection = conexao.Abre(); // retorna o objeto sqlconnection e já abre a conexão

                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = reader["message"].ToString() ;                        

                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        this.Mensagem_Retorno = "Alterações salvas com sucesso!";
                        retorno = true;
                    }

                    conexao.Fecha();
                }
                catch (SqlException e)
                {
                    conexao.Fecha();
                    retorno = false;

                    this.Mensagem_Retorno = "Erro no banco: " + e.ToString();
                }
            }
            return retorno;
        }
    }
}

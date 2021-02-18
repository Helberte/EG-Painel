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
    public class class_cadastro_camara
    {

        public String Serial_camara { get; private set; }

        Conexao conexao;

        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommandBuilder builder;

        SqlCommand cmd;
        SqlDataReader reader;

        public string Mensagem_Retorno { get; private set; }

        string comando;
         
        public class_cadastro_camara()
        {
            this.conexao = new Conexao();
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

        public bool Insert(string nome, 
                           string cnpj, 
                           string email,
                           string telefone,
                           string celular, 
                           byte[] imagem,
                           string cep,
                           string rua,
                           string numero,
                           string bairro,
                           string cidade)
        {
            bool retorno = false;
        
            comando = "exec usp_camara 'n', null, null, @nome," +
                                                       "@cnpj, " +
                                                       "@email," +
                                                       "@telefone," +
                                                       "@celular, " +
                                                       "@imagem, " +
                                                       "@cep, " +
                                                       "@rua, " +
                                                       "@numero, " +
                                                       "@bairro, " +
                                                       "@cidade";
            using (cmd = new SqlCommand(comando, conexao.Abre()))
            {
                try
                {
                    // cria e identifica os parametros

                    SqlParameter col_nome = new SqlParameter("@nome", SqlDbType.VarChar);
                    SqlParameter col_cnpj = new SqlParameter("@cnpj", SqlDbType.VarChar);
                    SqlParameter col_email = new SqlParameter("@email", SqlDbType.VarChar);
                    SqlParameter col_telefone = new SqlParameter("@telefone", SqlDbType.VarChar);
                    SqlParameter col_celular = new SqlParameter("@celular", SqlDbType.VarChar);
                    SqlParameter col_imagem = new SqlParameter("@imagem", SqlDbType.Binary);
                    SqlParameter col_cep = new SqlParameter("@cep", SqlDbType.VarChar);
                    SqlParameter col_rua = new SqlParameter("@rua", SqlDbType.VarChar);
                    SqlParameter col_numero = new SqlParameter("@numero", SqlDbType.VarChar);
                    SqlParameter col_bairro = new SqlParameter("@bairro", SqlDbType.VarChar);
                    SqlParameter col_cidade = new SqlParameter("@cidade", SqlDbType.VarChar);

                    // concede valor aos parametros

                    col_nome.Value = nome;
                    col_cnpj.Value = cnpj;
                    col_email.Value = email;
                    col_telefone.Value = telefone;
                    col_celular.Value = celular;
                    col_imagem.Value = imagem;
                    col_cep.Value = cep;
                    col_rua.Value = rua;
                    col_numero.Value = numero;
                    col_bairro.Value = bairro;
                    col_cidade.Value = cidade;

                    // adiciona os parametros ao sqlcommand
                    cmd.Parameters.Add(col_nome);
                    cmd.Parameters.Add(col_cnpj);
                    cmd.Parameters.Add(col_email);
                    cmd.Parameters.Add(col_telefone);
                    cmd.Parameters.Add(col_celular);
                    cmd.Parameters.Add(col_imagem);
                    cmd.Parameters.Add(col_cep);
                    cmd.Parameters.Add(col_rua);
                    cmd.Parameters.Add(col_numero);
                    cmd.Parameters.Add(col_bairro);
                    cmd.Parameters.Add(col_cidade);

                    cmd.CommandTimeout = 300;
                    
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = reader["message"].ToString();
                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        this.Serial_camara = reader["Id_camara"].ToString();
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

        public bool Update(string serial_camara,
                           string nome,
                           string cnpj,
                           string email,
                           string telefone,
                           string celular,
                           byte[] imagem,
                           string cep,
                           string rua,
                           string numero,
                           string bairro,
                           string cidade)
        {
            bool retorno = false;

            comando = "exec usp_camara 'A', null, @serial_camara, " +
                                                      "@nome," +
                                                      "@cnpj, " +
                                                      "@email," +
                                                      "@telefone," +
                                                      "@celular, " +
                                                      "@imagem, " +
                                                      "@cep, " +
                                                      "@rua, " +
                                                      "@numero, " +
                                                      "@bairro, " +
                                                      "@cidade";

            using (cmd = new SqlCommand(comando, conexao.Abre()))
            {
                try
                {

                    if (imagem is null)
                    {
                        comando = "exec usp_camara 'A', null, '" + serial_camara + "', " +
                                                      " '" + nome + "', " +
                                                      " '" + cnpj + "', " +
                                                      " '" + email + "', " +
                                                      " '" + telefone + "', " +
                                                      " '" + celular + "', " +
                                                      " null, " +
                                                      " '" + cep + "', " +
                                                      " '" + rua + "', " +
                                                      " '" + numero + "', " +
                                                      " '" + bairro + "', " +
                                                      " '" + cidade + "'";

                        cmd.CommandText = comando;

                        cmd.CommandTimeout = 300;
                        reader = cmd.ExecuteReader();
                    }
                    else
                    {
                        // cria e identifica os parametros

                        SqlParameter col_serial = new SqlParameter("@serial_camara", SqlDbType.VarChar);
                        SqlParameter col_nome = new SqlParameter("@nome", SqlDbType.VarChar);
                        SqlParameter col_cnpj = new SqlParameter("@cnpj", SqlDbType.VarChar);
                        SqlParameter col_email = new SqlParameter("@email", SqlDbType.VarChar);
                        SqlParameter col_telefone = new SqlParameter("@telefone", SqlDbType.VarChar);
                        SqlParameter col_celular = new SqlParameter("@celular", SqlDbType.VarChar);
                        SqlParameter col_imagem = new SqlParameter("@imagem", SqlDbType.Binary);
                        SqlParameter col_cep = new SqlParameter("@cep", SqlDbType.VarChar);
                        SqlParameter col_rua = new SqlParameter("@rua", SqlDbType.VarChar);
                        SqlParameter col_numero = new SqlParameter("@numero", SqlDbType.VarChar);
                        SqlParameter col_bairro = new SqlParameter("@bairro", SqlDbType.VarChar);
                        SqlParameter col_cidade = new SqlParameter("@cidade", SqlDbType.VarChar);

                        // concede valor aos parametros
                        col_serial.Value = serial_camara;
                        col_nome.Value = nome;
                        col_cnpj.Value = cnpj;
                        col_email.Value = email;
                        col_telefone.Value = telefone;
                        col_celular.Value = celular;
                        col_imagem.Value = imagem;
                        col_cep.Value = cep;
                        col_rua.Value = rua;
                        col_numero.Value = numero;
                        col_bairro.Value = bairro;
                        col_cidade.Value = cidade;

                        // adiciona os parametros ao sqlcommand
                        cmd.Parameters.Add(col_serial);
                        cmd.Parameters.Add(col_nome);
                        cmd.Parameters.Add(col_cnpj);
                        cmd.Parameters.Add(col_email);
                        cmd.Parameters.Add(col_telefone);
                        cmd.Parameters.Add(col_celular);
                        cmd.Parameters.Add(col_imagem);
                        cmd.Parameters.Add(col_cep);
                        cmd.Parameters.Add(col_rua);
                        cmd.Parameters.Add(col_numero);
                        cmd.Parameters.Add(col_bairro);
                        cmd.Parameters.Add(col_cidade);

                        cmd.CommandTimeout = 300;

                        reader = cmd.ExecuteReader();
                    }               

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = reader["message"].ToString();
                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        //this.Serial_camara = reader["Id_camara"].ToString();

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGP_PAINEL.Classes;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EGP_Tela_Inicial_04_02.Formulario_login_inicial
{
    public class Class_gerencia_login
    {
        
        private int codigo_usuario;
        private string usuario_login;
        private string senha;

        Conexao conexao;
        SqlDataReader reader;


        public static int Status = 0;
        public static int ID_Usuario = 0;
        public static string Nome_Usuario = "";


        public Class_gerencia_login(int codigo_usuario, string usuario_login, string senha)
        {
            this.codigo_usuario = codigo_usuario;
            this.usuario_login = usuario_login;
            this.senha = senha;
            this.conexao = new Conexao();
        }

        public Class_gerencia_login() { }

        public bool ValidarUsuario()
        {
            bool retorno = false;

            if (this.usuario_login.ToUpper() == "ADMINISTRADOR")
            {
                if (this.senha == "12345678")
                {                   
                    Class_gerencia_login.Status = 1;
                    Class_gerencia_login.ID_Usuario = -1;
                    Nome_Usuario = "Administrador";
                    return true;
                }
                else
                {                    
                    MessageBox.Show("Senha incorreta!","Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }                
            }

            try
            {
                string comando = "exec usp_verifica_usuario '" + this.usuario_login + "', '" + this.senha + "'";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 300;
                    cmd.CommandText = comando;
                    cmd.Connection = conexao.Abre();

                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        retorno = false;
                        MessageBox.Show(reader["message"].ToString(), "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        Class_gerencia_login.Status = 1;
                        ID_Usuario      = Convert.ToInt32(reader["ID"].ToString());
                        Nome_Usuario    = reader["NOME"].ToString();
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                MessageBox.Show("Problemas ao verificar usuário [Class_gerencia_login] " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Fecha();
            return retorno;
        }
    }
}

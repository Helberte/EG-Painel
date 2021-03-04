using EGP_PAINEL.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EGP_Tela_Inicial_04_02.Classes
{
    public class class_verifica_acessos
    {
        int id_usuario;
        public int Id_Menu { get; set; }  // informa para qual posição se refere a lista suspensa, se para o 1 ou 2 etc
        public int Quantidae_nomes_menu { get; private set; }

        Conexao conexao;
        SqlCommand command;
        SqlDataReader reader;

        public class_verifica_acessos(int id_usuario)
        {
            this.id_usuario = id_usuario;
            this.conexao = new Conexao();
        }

        public List<string> Nomes_menu_principal()
        {
            List<string> nomes_menu = new List<string>();

            string comando = "select * from MENU_NOMES order by POSICAO_MENU asc";

            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        nomes_menu.Add(reader["NOME"].ToString());
                        Quantidae_nomes_menu += 1;
                    }

                    conexao.Fecha();
                    return nomes_menu;
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


        public SqlDataReader RetornaListaSuspensa()
        {            
            string comando = "exec usp_retorna_acessos_usuario " + id_usuario;

            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();

                    //conexao.Fecha();
                    return reader;
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
         
        public SqlDataReader RetornaMenusLaterais()
        {
            string comando = "exec usp_retorna_menus_lateral " + id_usuario;

            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();

                    //conexao.Fecha();
                    return reader;
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

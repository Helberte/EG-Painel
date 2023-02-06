﻿using EGP_PAINEL.Classes;
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


        public string RetornaListaSuspensa()
        {
            string lista_suspensa = "";
            string comando = "exec usp_retorna_acessos_usuario " + id_usuario;

            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();                   

                    while (reader.Read())                    
                        lista_suspensa += reader["FK_POSICAO_MENU"].ToString() + "_" + reader["NUMERO_ITEM"].ToString() + "_" + reader["NOME_ITEM"].ToString() + "\n";
                    

                    conexao.Fecha();
                    return lista_suspensa;
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

        public string RetornaMenusRapidos()
        {
            string menus_rapidos = "";
           
            string comando = "select men.NOME_ITEM as [NOME], men.LABEL as [LABEL], nomes.NOME as [CATEGORIA] from ACESSOS a " +
            "inner join USUARIOS us on a.FK_ID_PESSOA = us.ID_USUARIO " +
            "inner join PARTICIPANTE_SESSAO p on p.CPF = us.FK_CPF_PESSOA " +
            "inner join MENU_ITENS_SUSPENSOS men on men.ID_MENU_ITENS_SUSPENSOS = a.FK_MENU_ITENS_SUSPENSOS " +
            "inner join MENU_NOMES nomes on men.FK_POSICAO_MENU = nomes.POSICAO_MENU " +
            "where a.ACESSO = 1 " +
            "and men.MENU_RAPIDO = 1 " +
            "and us.ID_USUARIO = " + id_usuario +
            " order by men.MENU_RAPIDO_ORDEM asc";


            using (command = new SqlCommand())
            {
                try
                {
                    command.CommandText = comando;
                    command.CommandTimeout = 300;
                    command.Connection = conexao.Abre();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                        menus_rapidos += reader["NOME"].ToString() + ";" + reader["LABEL"].ToString() + ";" + reader["CATEGORIA"].ToString() + "\n";


                    conexao.Fecha();
                    return menus_rapidos;
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

        public List<string> RetornaMenusLaterais()
        {
            List<string> menus_laterais = new List<string>();
            string comando = "exec usp_retorna_menus_lateral " + id_usuario;

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
                        menus_laterais.Add(reader["NUMERO_ITEM"].ToString() + "_" + reader["NOME_ITEM"].ToString());
                    }

                    conexao.Fecha();
                    return menus_laterais;
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

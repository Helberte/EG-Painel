using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;
using EGP_Tela_Inicial_04_02.Formulario_login_inicial;

namespace EGP_Tela_Inicial_04_02
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ArquivoConexao arquivo = new ArquivoConexao();

            if (arquivo.LerArquivo())
            {
                try
                {
                    var ping = new Ping();
                    var resposta = ping.Send(arquivo.Ip, 3);


                    if ((resposta != null) && (resposta.Status == IPStatus.Success))
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);

                        Form_login_inicial form_Login = new Form_login_inicial();
                        form_Login.ShowDialog();

                        if (class_gerencia_login.Status == 1)
                        {
                            Application.Run(new Form_principal());
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Servidor não encontrado," +
                            " aplicação não será iniciada.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas na inicialização: IP: " + arquivo.Ip + "\n" + e.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

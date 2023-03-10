using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace EGP_PAINEL.Classes
{
    public class ArquivoConexao
    {

        public string Ip { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }


        public bool LerArquivo()
        {
            bool retorno = false;
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Conection.resx"))
            {
                using (ResXResourceReader resx = new ResXResourceReader(@".\Conection.resx"))
                {
                    foreach (DictionaryEntry item in resx)
                    {
                        if (((string) item.Key).StartsWith("Ip"))                        
                            this.Ip = (string)item.Value;
                        else if (((string)item.Key).StartsWith("Usuario"))
                            this.Usuario = (string)item.Value;
                        else if (((string)item.Key).StartsWith("Senha"))
                            this.Senha = (string)item.Value;

                        retorno = true;
                    }
                }               
            }
            else
            {
                retorno = false;
                MessageBox.Show("Arquivo necessário:" +
                    " " + Directory.GetCurrentDirectory() + @"\Conection.resx", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }
    }
}

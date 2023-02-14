using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGP_Tela_Inicial_04_02.Classes.Configuracao
{
    public class Configuracoes_sistema
    {
        System.Drawing.FontFamily montserrat;
        static Configuracoes_sistema config;

        private Configuracoes_sistema()
        {
            montserrat = new System.Drawing.FontFamily("Montserrat");
        }

        public static System.Drawing.FontFamily GetFontMontserrat()
        {
            if (config is null)
            {
                config = new Configuracoes_sistema();
                return config.montserrat;
            }
            return config.montserrat;
        }
    }
}

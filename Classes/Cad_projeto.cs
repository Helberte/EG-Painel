using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGP_PAINEL.Classes
{
    [Serializable() ] class Cad_projeto
    {
        public string Sigla { get; private set; }
        public string Tipo { get; private set; }
        public string Autor { get; private set; }
        public string Ementa { get; private set; }
        public string Indexacao { get; private set; }

        public Cad_projeto(string sigla, string tipo, string autor, string ementa, string indexacao)
        {
            this.Sigla = sigla;
            this.Tipo = tipo;
            this.Autor = autor;
            this.Ementa = ementa;
            this.Indexacao = Indexacao;
        }

    }
}

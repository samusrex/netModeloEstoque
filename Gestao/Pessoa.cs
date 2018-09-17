using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }

        public string RetornarNomeCompleto()
        {
            string nomeCompleto = String.Empty;
            if (this.Nome.Length > 0 && this.Sobrenome.Length > 0)
            {
                nomeCompleto = string.Format("{0} {1}", this.Nome, this.Sobrenome);
            }
            return nomeCompleto;
        }

        public bool ValidaCpf()
        {
            if (this.Cpf.Length > 0)
            {

                return true;
            }


            return false;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Filme : IItem
    {
        public enum Genero {

            DRAMA,
            SUSPENSE,
            FICÇÃO,
            ROMANCE,
            TERROR,
            AÇÃO,
            ANIME

        }
        public int FilmeId { get; set; }
        public string Nome { get; set; }
        public Genero Categoria { get; set; }
        public double Preco { get; set; }

        private int qtde;

        public int GetQtde()
        {
            return qtde;
        }

        public void SetQtde(int value)
        {
            qtde = value;
        }
    }
}

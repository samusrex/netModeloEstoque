using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AcervoFilmes : IEstoque
    {
        List<Filme> Filmes = new List<Filme>();


        public void Adicione(IItem p)
        {
            Filmes.Add((Filme)p);
        }

        public int Conte(IItem p)
        {
            Filme encontrar = (Filme)p;
            Filme encontrado = Filmes.Find(c => c.FilmeId == encontrar.FilmeId);
            return encontrado.GetQtde();

        }

        public bool Procure(int Id)
        {


            Filme encontrado = Filmes.Find(c => c.FilmeId == Id);

            if (encontrado == null)
            {
                return false;
            }
            return true;
        }

        public void Retire(IItem p)
        {
            Filme encontrar = (Filme)p;
            Filme encontrado = Filmes.Find(c => c.Nome.Equals(encontrar.Nome));
            if (encontrado.GetQtde() > 0)
            {
                encontrado.SetQtde(encontrado.GetQtde() - 1);
            }
        }

        public void Retorne(IItem p, int quantidade)
        {
            Filme encontrar = (Filme)p;
            Filme encontrado = Filmes.Find(c => c.Nome.Equals(encontrar.Nome));
            encontrado.SetQtde(encontrado.GetQtde() + quantidade);

        }

        public IList<IItem> RetorneTodos()
        {
            return this.Filmes.ToList<IItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CentroDistribuicao : IEstoque
    {
        List<Produto> Produtos = new List<Produto>();


        public void Adicione(IItem p)
        {
            Produtos.Add((Produto)p);
        }

        public int Conte(IItem p)
        {
            Produto encontrar = (Produto)p;
            Produto encontrado = Produtos.Find(c => c.ProdutoId == encontrar.ProdutoId);
            return encontrado.GetQtde();

        }

        public bool Procure(int Id)
        {


            Produto encontrado = Produtos.Find(c => c.ProdutoId == Id);

            if (encontrado == null)
            {
                return false;
            }
            return true;
        }

        public void Retire(IItem p)
        {
            Produto encontrar = (Produto)p;
            Produto encontrado = Produtos.Find(c => c.Nome.Equals(encontrar.Nome));
            if (encontrado.GetQtde() > 0)
            {
                encontrado.SetQtde(encontrado.GetQtde() - 1);
            }
        }

        public void Retorne(IItem p, int quantidade)
        {
            Produto encontrar = (Produto)p;
            Produto encontrado = Produtos.Find(c => c.Nome.Equals(encontrar.Nome));
            encontrado.SetQtde(encontrado.GetQtde() + quantidade);

        }

        public IList<IItem> RetorneTodos()
        {
            return this.Produtos.ToList<IItem>();
        }
    }
}

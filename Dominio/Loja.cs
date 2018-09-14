using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Loja : ICompra
    {
        IEstoque estoque;
        List<Produto> MinhasCompras = new List<Produto>();
        double Total = 0;

        public Loja(IEstoque stck)
        {
            this.estoque = stck;
        }

        public void AdicionaItens(IItem it)
        {
            MinhasCompras.Add((Produto)it);
        }

        public IList<IItem> Compras()
        {
            return this.MinhasCompras.ToList<IItem>();
        }

        public bool EstaDisponivel(IItem consulta)
        {
            Produto produto = (Produto)consulta;


            if (estoque.Conte(produto) > 0)
            {

                return true;
            }
            else
            {

                return false;

            }



        }

        public void RealizaPagamento(double valor)
        {
            if (Total >= valor)
            {

                Console.WriteLine("Pagamento insuficiente");
            }
            else if (Total == valor)
            {

                Console.WriteLine("Pagamento Realizado.");
            }
            else if (valor >= Total)
            {

                Console.WriteLine("Pagamento Realizado, Seu troco é de {0}", (valor - Total));
            }
        }

        public void RetiraItens(IItem i)
        {
            MinhasCompras.Remove((Produto)i);
        }

        public double Totalizar()
        {
            foreach (var item in MinhasCompras)
            {

                Total += item.Preco;
            }

            return this.Total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LocadoraFilmes : ICompra
    {
        IEstoque estoque;
        List<Filme> MeusFilmes = new List<Filme>();
        double Total = 0;

        public LocadoraFilmes(IEstoque estq)
        {
            this.estoque = estq;
        }

        public void AdicionaItens(IItem it)
        {
            MeusFilmes.Add((Filme)it);
        }

        public IList<IItem> Compras()
        {
            return this.MeusFilmes.ToList<IItem>();
        }

        public bool EstaDisponivel(IItem consulta)
        {
            if (this.estoque.Conte(consulta) > 0)
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
            if (valor >= Total)
            {
                Console.WriteLine("O total de sua Compra foi de R${0}. E o pagamento foi de R${1} . Seu Troco é de {2} Real", Total, valor, (valor - Total));
            }
            else
            {
                Console.WriteLine("Pagamento Insuficiente. E o total é de {0} Reais", Total);
            }

        }

        public void RetiraItens(IItem i)
        {
            MeusFilmes.Remove((Filme)i);
        }

        public double Totalizar()
        {

            foreach (var item in MeusFilmes)
            {

                Total += item.Preco;

            }

            return this.Total;
        }
    }
}

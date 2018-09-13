using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Loja : ICompra
    {


        public void AdicionaItens(IItem it)
        {
            throw new NotImplementedException();
        }

        public IList<IItem> Compras()
        {
            throw new NotImplementedException();
        }

        public bool EstaDisponivel(IItem consulta)
        {
            throw new NotImplementedException();
        }

        public void RealizaPagamento(double valor)
        {
            throw new NotImplementedException();
        }

        public void RetiraItens(IItem i)
        {
            throw new NotImplementedException();
        }

        public double Totalizar()
        {
            throw new NotImplementedException();
        }
    }
}

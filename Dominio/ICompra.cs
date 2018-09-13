using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ICompra
    {
        void AdicionaItens(IItem it);
        void RetiraItens(IItem i);
        IList<IItem> Compras();
        bool EstaDisponivel(IItem consulta);
        void RealizaPagamento(double valor);
        double Totalizar();
    }
}

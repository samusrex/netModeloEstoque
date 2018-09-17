using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public interface ITituloReceber
    {
      
        void Adicionar(ITitulo novo);
        void Remover(ITitulo excluir);
        void Parcelar(Cliente cli, double valor, int quantidade);
        IList<ITitulo> ObterPorCliente(Cliente cli);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public interface ITituloReceber
    {

        void Adicionar(Titulo novo);
        void Remover(Titulo excluir);
        bool SeParcelado(Titulo te);
        void Parcelar(Titulo valor, int quantidade);
        IList<Titulo> ObterPorCliente(Cliente cli);


    }
}

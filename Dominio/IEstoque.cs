using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IEstoque
    {
        void Retire(IItem p);
        bool Procure(int Id);
        void Adicione(IItem p);
        void Retorne(IItem p, int quantidade);
        int Conte(IItem p);
        IList<IItem> RetorneTodos();
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public class TituloReceber : ITituloReceber
    {

        private List<Duplicata> rec = new List<Duplicata>();

        public TituloReceber()
        {

        }

        public void Adicionar(ITitulo novo)
        {
            rec.Add((Duplicata)novo);
        }

        public IList<ITitulo> ObterPorCliente(Cliente cli)
        {
            var retorno = this.rec;
            retorno.Where(c => c.Cliente == cli).ToList();
            return retorno.ToList<ITitulo>();


        }


        public void Parcelar(Cliente cli, double valor, int quantidade)
        {
            throw new NotImplementedException();
        }

        public void Remover(ITitulo excluir)
        {
            throw new NotImplementedException();
        }
    }
}

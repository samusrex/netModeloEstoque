using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public interface ITituloPagar
    {
        List<ITituloPagar> ObterPorClientes();
        List<ITituloPagar> Priorizar();
        List<ITituloPagar> RetornarNaoPagos();
        List<ITituloPagar> NotificarVencimentos();


    }
}

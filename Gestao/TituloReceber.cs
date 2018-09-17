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

        public void Parcelar(ITitulo valor, int quantidade)
        {
            if (valor != null && quantidade > 0)
            {
                var tituloTotal = (Duplicata)valor;

                for (int i = 1; i <= quantidade; i++)
                {

                    var parcela = new Duplicata()
                    {
                        Id = (rec.LastOrDefault().Id + 1),
                        Cliente = tituloTotal.Cliente,
                        Valor = (tituloTotal.Valor / quantidade),
                        Vencimento = DateTime.Now.AddMonths(i),
                        Referencia = tituloTotal,

                    };

                    rec.Add(parcela);
                }

            }
            else
            {

                Console.WriteLine("Não há quantidade de parcelas ou valor inexistente.");

            }
        }

        public void Remover(ITitulo excluir)
        {
            throw new NotImplementedException();
        }
    }
}

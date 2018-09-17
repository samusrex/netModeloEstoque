using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public class TituloReceber : ITituloReceber
    {

        private List<DuplicataReceber> rec = new List<DuplicataReceber>();

        public TituloReceber()
        {

        }



        public void Adicionar(Titulo novo)
        {
            rec.Add((DuplicataReceber)novo);
        }

        public IList<Titulo> ObterPorCliente(Cliente cli)
        {
            var retorno = this.rec;
            retorno.Where(c => c.Pessoa == cli).ToList();
            return retorno.ToList<Titulo>();

        }

        public void Parcelar(Titulo valor, int quantidade)
        {
            if (SeParcelado(valor) == false)
            {
                if (valor != null && quantidade > 0)
                {
                    var tituloTotal = (DuplicataReceber)valor;

                    for (int i = 1; i <= quantidade; i++)
                    {

                        var parcela = new DuplicataReceber()
                        {
                            Id = (rec.LastOrDefault().Id + 1),
                            Pessoa = tituloTotal.Pessoa,
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
            else
            {
                Console.WriteLine("Valor já parcelado");
            }

        }


        public void Remover(Titulo excluir)
        {
            throw new NotImplementedException();
        }



        public bool SeParcelado(Titulo te)
        {
            DuplicataReceber d = (DuplicataReceber)te;
            var resultado = rec.Where(c => c.Referencia == d).FirstOrDefault();

            if (resultado == null)
            {
                return false;
            }
            return true;
        }

        IList<Titulo> ITituloReceber.ObterPorCliente(Cliente cli)
        {
            var retorno = this.rec;
            retorno.Where(c => c.Pessoa == cli).ToList();
            return retorno.ToList<Titulo>();

        }
    }
}

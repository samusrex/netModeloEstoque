using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    public class Duplicata : ITitulo
    {
        
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }
    }
}

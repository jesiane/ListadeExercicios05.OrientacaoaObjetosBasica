using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Temperatura
    {
        public decimal temperatura;

        public decimal CalcularTemperatura()
        {
            return (temperatura - 32) * 5 / 9;
        }
    } 
}

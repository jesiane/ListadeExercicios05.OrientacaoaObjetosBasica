using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Temperatura
    {
        public decimal temperatura;

        public decimal CalcularTemperatura()
        {
            return (temperatura * 9 / 5) + 32;
        }
    }
}

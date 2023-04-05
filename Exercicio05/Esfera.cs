using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {
        public double radio;

        public double CalcularEsfera()
        {
            return (4.0 * Math.PI * radio * radio * radio / 3);
        }
    }
}
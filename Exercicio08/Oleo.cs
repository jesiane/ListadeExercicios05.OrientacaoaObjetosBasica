using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Oleo
    {

        public double raio;
        public double altura;

        public double CalculoVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}

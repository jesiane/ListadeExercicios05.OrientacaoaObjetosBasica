using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Combustivel
    {
        public double kmini;
        public double kmfim;
        public double iniCombustivel;

        public double CalcularCombustivel()
        {
            return (kmfim - kmini) / iniCombustivel;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MPonderada
    {
        public decimal nota1;
        public decimal nota2;
        public decimal nota3;

        public decimal CalculoMedia()
        {
            return (nota1 + nota2 +nota3)/3;
        }
    }
}

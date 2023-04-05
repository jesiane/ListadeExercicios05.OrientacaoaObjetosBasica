using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Aluno
    {
        private decimal[] notas;
        public Aluno(decimal[] notas)
        {
            this.notas = notas;
        }

        public decimal CalcularMediaHarmonica()
        {
            decimal inversoElementos = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                inversoElementos += 1 / notas[i];
            }

            return this.notas.Length / inversoElementos;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
        public class CalculadorTemperatura
        {
            private decimal grausFahrenheit;
            public CalculadorTemperatura(decimal grausFahrenheit)
            {
                this.grausFahrenheit = grausFahrenheit;
            }

            public decimal CalcularTemperaturaCelsius()
            {
                return (this.grausFahrenheit - 32) / 1.8M;
            }
        }

    }

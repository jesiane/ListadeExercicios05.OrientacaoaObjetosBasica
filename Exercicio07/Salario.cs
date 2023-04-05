using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {
        public String nome;
        public decimal salario;
        public int vendas;
        public decimal percentVendas;

        public decimal CalculoSalario()
        {
            return (vendas * percentVendas) + salario;
        }
    }
}

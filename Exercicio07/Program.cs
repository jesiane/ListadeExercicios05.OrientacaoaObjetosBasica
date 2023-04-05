namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            salario.salario = 1000;
            salario.vendas = 5;
            salario.percentVendas = 5;


            Console.WriteLine("O valor é:  " + salario.CalculoSalario());
        }
    }
}


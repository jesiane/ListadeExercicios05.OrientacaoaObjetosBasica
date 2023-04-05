namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Combustivel combustivel = new Combustivel();

            combustivel.kmfim = 800;
            combustivel.kmini = 1;
            combustivel.kmfim = 105;


            Console.WriteLine("A distancia percorida foi de " + combustivel.CalcularCombustivel());
            Console.WriteLine();
        }
    }
}

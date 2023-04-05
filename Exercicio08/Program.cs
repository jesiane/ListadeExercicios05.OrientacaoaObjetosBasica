namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oleo oleo = new Oleo();

            oleo.altura = 1;
            oleo.raio = 2;

            Console.WriteLine("O valor do volume: " + oleo.CalculoVolume());

        }
    }
}
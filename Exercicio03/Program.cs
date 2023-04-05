namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Cilindro cilindro = new Cilindro();

            cilindro.raio = 10;
            cilindro.altura = 10;

            Console.WriteLine("\r O valor do volume: " + cilindro.CalcularVolume());
            Console.ReadLine();
        }
}
}
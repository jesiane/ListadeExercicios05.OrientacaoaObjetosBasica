namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.radio = 10;

            Console.WriteLine("O valor do volume da esfera: " + esfera.CalcularEsfera());
        }
    }
}
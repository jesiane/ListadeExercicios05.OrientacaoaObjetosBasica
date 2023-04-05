namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MPonderada media = new MPonderada();

            media.nota1 = 9;
            media.nota2 = 10;
            media.nota3 = 6;

            Console.WriteLine("A media é: " + media.CalculoMedia());

        }
    }
}
namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura celsius = new Temperatura();

            celsius.temperatura = 36;

            Console.WriteLine("A temperatura Fahrenheit é:  " + celsius.CalcularTemperatura());

        }

    }
}
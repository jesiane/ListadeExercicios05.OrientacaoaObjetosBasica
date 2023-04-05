namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadorTemperatura calculadorTemperatura = new CalculadorTemperatura(10);
            Console.WriteLine("A temperatura em graus Celsius é: " +
                              Math.Round(calculadorTemperatura.CalcularTemperaturaCelsius()) + " °C.");

            Console.ReadLine();
        }
    }
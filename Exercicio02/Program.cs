namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Temperatura fah = new Temperatura();

                fah.temperatura = 36;

                Console.WriteLine("A temperatura Fahrenheit é:  " + fah.CalcularTemperatura());

            
        }
}
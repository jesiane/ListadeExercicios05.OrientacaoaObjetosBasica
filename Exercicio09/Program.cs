namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] notas = { 7, 8, 9 };
            Aluno aluno = new Aluno(notas);
            Console.WriteLine("A média harmônica do aluno é " + Math.Round(aluno.CalcularMediaHarmonica(), 2));
            Console.ReadLine();
        }
    }
}
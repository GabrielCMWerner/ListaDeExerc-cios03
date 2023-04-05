namespace Exercício09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new MediaHarmonica();
            Console.WriteLine("Calculando a média harmonica do Aluno");

            Console.WriteLine();

            Console.Write("Digite quantas notas do aluno: ");
            mediaHarmonica.quantidade = Convert.ToInt32(Console.ReadLine());

            mediaHarmonica.somainversos = 0;

            for (int i = 1; i <= mediaHarmonica.quantidade; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                mediaHarmonica.somainversos += 1.0 / nota;
            }

            double media = mediaHarmonica.CalcularMediaHarmonica();

            Console.WriteLine($"A media harmonica das notas é: {media:F2}");
        }
    }
}
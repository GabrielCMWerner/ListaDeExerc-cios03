namespace Exercício09
{
    public class MediaHarmonica
    {
        public double somainversos;
        public int quantidade;

        public double CalcularMediaHarmonica()
        {
            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                somainversos += 1.0 / nota;
            }

            double media = quantidade / somainversos;

            return media;
        }
    }
}
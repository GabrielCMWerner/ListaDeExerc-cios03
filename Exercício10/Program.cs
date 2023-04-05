namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MediaPonderada mediaPonderada = new MediaPonderada();
            Console.WriteLine("Calculando a média ponderada do Aluno");

            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            mediaPonderada.nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            mediaPonderada.nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Levando em conta que 1 é 100%, digite o peso de cada prova: (ex: 0.5 = 50% do total)");

            Console.Write("Digite quanto vale a nota da primeira prova: ");
            mediaPonderada. peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quanto vale a nota da segunda prova: ");
            mediaPonderada. peso2 = Convert.ToDouble(Console.ReadLine());

            double media = mediaPonderada.CalcularMediaPonderada();

            Console.WriteLine($"A media ponderada é: " + media);

            Console.ReadLine();
        }
    }
}
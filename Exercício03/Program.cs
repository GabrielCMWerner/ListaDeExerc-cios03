namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.WriteLine("Calculando o volume de um cilindro");

            Console.WriteLine();

            Console.Write("Digite a altura do cilindro: ");
            cilindro.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o raio do cilindro: ");
            cilindro.raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double volume = cilindro.CalcularVolume();

            Console.WriteLine("O volume do cilindro é: " + volume);

            Console.ReadLine();
        }
    }
}
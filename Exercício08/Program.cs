namespace Exercício08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lata lata = new Lata();

            Console.WriteLine("Calculando o volume de um cilindro");

            Console.WriteLine();

            Console.Write("Digite a altura do cilindro: ");
            lata.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o raio do cilindro: ");
            lata.raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double volume = lata.CalcularVolume();

            Console.WriteLine("O volume do cilindro é: " + volume);

            Console.ReadLine();
        }
    }
}
namespace Exercício05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.WriteLine("Calculando o volume de uma esfera");

            Console.WriteLine();

            Console.Write("Digite o valor do raio: ");
            esfera.raio = Convert.ToDouble(Console.ReadLine());
            
            double volume = esfera.CalcularVolume();
            Console.WriteLine("O volume da esfera é: " + volume);

            Console.ReadLine();
        }
    }
}
namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();

            Console.WriteLine("Calculando o Volume de uma caixa");

            Console.WriteLine();

            Console.Write("Digite a largura da caixa: ");
            caixa.largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            caixa.altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o comprimeto da caixa: ");
            caixa.comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            decimal volume = caixa.CalcularVolume();

            Console.WriteLine("O volume da caixa é: " + volume + "metros cúbicos");

            Console.ReadLine();
        }
    }
}
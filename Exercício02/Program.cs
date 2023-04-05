namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.WriteLine("Convertendo graus Fahrenheit em graus celsius");

            Console.WriteLine();

            Console.Write("Digite a temperatura e graus Fahrenheit: ");
            temperatura.fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double celsius = temperatura.ConversaoDeTemperatura();

            Console.WriteLine("A conversão para graus Celsius é: " + celsius);

            Console.ReadLine();
        }
    }
}
namespace Exercício06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            Console.WriteLine("Convertendo graus Celsius em graus Fahrenheit");

            Console.WriteLine();

            Console.Write("Digite a temperatura e graus Celsius: ");
            temperatura.celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = temperatura.ConverterTemperatura();
            Console.WriteLine("A conversão para graus Fahrenheit é: " + fahrenheit);

            Console.ReadLine();
        }
    }
}
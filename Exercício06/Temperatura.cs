namespace Exercício06
{
    public class Temperatura
    {
        public double celsius;

        public double ConverterTemperatura()
        {
            double fahrenheit = celsius * 1.8 + 32;

            return fahrenheit;
        }
    }
}
namespace Exercício02
{
    public class Temperatura
    {
        public double fahrenheit;

        public double ConversaoDeTemperatura()
        {
            
            double celsius = fahrenheit - 32 / 1.8;

            return celsius;
        }

    }
}
namespace Exercício08
{
    public class Lata
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            double volume = raio * raio * Math.PI * altura;

            return volume;
        }
    }
}
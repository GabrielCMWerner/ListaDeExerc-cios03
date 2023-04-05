namespace Exercício05
{
    public class Esfera
    {
        public double raio;
        public double raio3;

        public void CalcularRaio3()
        {
            raio3 = raio * raio * raio;

        }

        public double CalcularVolume()
        {
            
            double volume = 4 / 3 * Math.PI * raio3;

            return volume;
        }
    }
}
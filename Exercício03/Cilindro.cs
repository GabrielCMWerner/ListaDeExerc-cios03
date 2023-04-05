namespace Exercício03
{
    public class Cilindro
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            double volume = raio* raio *Math.PI * altura;

            return volume;
        }
    }
}
namespace Exercício10
{
    internal class MediaPonderada
    {
        public int nota1;
        public int nota2;
        public double peso1;
        public double peso2;

        public double CalcularMediaPonderada()
        {
            double media = (nota1 * peso1) + (nota2 * peso2);

            return media;
        }
    }
}
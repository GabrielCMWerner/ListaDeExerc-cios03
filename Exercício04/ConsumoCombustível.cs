namespace Exercício04
{
    public class ConsumoCombustível
    {
        public double quilometragemi;
        public double quilometrosrodados;
        public double litros;
 
        public double CalcularMedia()
        {
            double media = quilometrosrodados / litros;

            return media;
        }

        public double CalcularQuilometragemFinal()
        {
            double quilometragemf = quilometragemi + quilometrosrodados;

            return quilometragemf;
        }
    }
}
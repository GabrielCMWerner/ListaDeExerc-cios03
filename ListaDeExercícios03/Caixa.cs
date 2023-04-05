namespace Exercício01
{
    public class Caixa
    {
        public decimal comprimento;
        public decimal altura;
        public decimal largura;

        public decimal CalcularVolume()
        {
            decimal volume = largura * comprimento * altura;

            return volume;
        }
    }
}
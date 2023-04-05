namespace Exercício07
{
    public class Salario
    {
        public double salariobase;
        public double vendas;
        public double comissao;

        public double CalcularSalario()
        {
            double salariototal = salariobase + (vendas * (comissao * salariobase / 100));

            return salariototal;
        }
    }
}
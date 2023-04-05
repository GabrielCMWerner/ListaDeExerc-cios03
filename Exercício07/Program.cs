namespace Exercício07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.WriteLine("Calculando o salario total de um vendedor");

            Console.WriteLine();

            Console.Write("Digite o salário base: ");
            salario.salariobase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            salario.vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (em %): ");
            salario.comissao = Convert.ToDouble(Console.ReadLine());

            double salariototal = salario.CalcularSalario();

            Console.WriteLine();

            Console.Write("O salalrio total é igual a: " + salariototal);

            Console.ReadLine();
        }
    }
}
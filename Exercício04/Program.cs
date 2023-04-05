namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustível consumo = new ConsumoCombustível();

            Console.WriteLine("Calculando a media de combustivel consumida pelo veiculo");


            Console.WriteLine();


            Console.Write("Digite a quilometragem inicial: ");
            consumo.quilometragemi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem rodada: ");
            consumo.quilometrosrodados = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de litros consumidos: ");
            consumo.litros = Convert.ToDouble(Console.ReadLine());

            double media = consumo.CalcularMedia();
            double quilometragemf = consumo.CalcularQuilometragemFinal();

            Console.WriteLine();


            Console.WriteLine("A média de consumo de combustivel por quilometro rodado foi de: " + media);


            Console.WriteLine("A quilometragem do veiculo após o percurso é de: " + quilometragemf);

            Console.ReadLine();
        }
    }
}
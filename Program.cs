using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:

            double R = 0;
            double h = 0;

            Console.Write("Digite o raio da base do cilindro: ");

            R = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a altura do cilindro: ");

            h = double.Parse(Console.ReadLine());

            //Cálculo do volume

            double V = Math.PI * Math.Pow(R, 2) * h;

            Console.WriteLine();

            //Volume do Cílindro
            Console.WriteLine($"Volume do cilindro: {V} ");

            Console.WriteLine();

        CalcularNovamente:
            Console.Write("Deseja calcular novamente ? (s/n) : ");

            string calcNovamente = Console.ReadLine();

            Console.WriteLine();

            switch (calcNovamente)
            {
                case "s":
                    goto Inicio;
                    break;

                case "S":
                    goto Inicio;
                    break;

                case "n":
                    break;

                case "N":
                    break;

                default:
                    Console.WriteLine("Digite uma opção válida !");
                    goto CalcularNovamente;
                    break;
            }
        }
    }
}
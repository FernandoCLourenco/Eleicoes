using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayslan_aaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    internal class Program {
        static double total(double votos, double totalv  )
        {
            return (votos / totalv) * 100;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de votos de Donald Trump : ");
            double votosd = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos de Kamala Harris : ");
            double votosk = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos nulos : ");
            double votosn = double.Parse(Console.ReadLine());

            double totalv = votosd + votosk+ votosn;

            double TotalD = total(votosd , totalv);
            double TotalK = total(votosk, totalv);

            double Totaln = total(votosn, totalv);

            Console.WriteLine("Resultados");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Donald Trump recebeu {TotalD:F2}% dos votos");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Kamala Harris recebeu {TotalK:F2}% dos votos");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"A quantidade de votos nulos foi de {Totaln:F2}%");

            Console.ReadKey();

        }
    }
}



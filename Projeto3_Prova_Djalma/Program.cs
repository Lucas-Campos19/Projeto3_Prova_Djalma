using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3_Prova_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, result = 0, B;
            int cod;

            Console.WriteLine(" 1 - Triangulo;");
            Console.WriteLine(" 2 - Paralelogramo;");
            Console.WriteLine(" 3 - Trapézio.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            
            Console.Write(" Escolha uma dessas figuras geometricas listadas acima, pressione o número para escoher uma das figuras:");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.Write(" Digite a base da forma geométrica:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.Write(" Digite a altura da forma geométrica:");
            h = Double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            switch (cod)
            {
                case 1:
                    result = (b * h) / 2;
                    break;
                case 2:
                    result = b * h;
                    break;
                case 3:
                    Console.Write("Digite o outro lado da base do Trapézio:");
                    B = Double.Parse(Console.ReadLine());
                    result = (B + b) / 2;
                    result = result * h;
                    break;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" A área dessa forma geométrica é:" + result );
            Console.ReadKey();





















        }
    }
}

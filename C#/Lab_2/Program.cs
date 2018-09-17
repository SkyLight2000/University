using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення X1min: ");
            string sx1Min = Console.ReadLine();
            double x1Min = Double.Parse(sx1Min);
            Console.Write("Введiть кiнцеве значення X1max: ");
            string sx1Max = Console.ReadLine();
            double x1Max = double.Parse(sx1Max);
            Console.Write("Введiть прирiст dX1: ");
            string sdx1 = Console.ReadLine();
            double dx1 = double.Parse(sdx1);
            Console.Write("Введiть початкове значення X2min: ");
            string sx2Min = Console.ReadLine();
            double x2Min = Double.Parse(sx2Min);
            Console.Write("Введiть кiнцеве значення X2max: ");
            string sx2Max = Console.ReadLine();
            double x2Max = double.Parse(sx2Max);
            Console.Write("Введiть прирiст dX2: ");
            string sdx2 = Console.ReadLine();
            double dx2 = double.Parse(sdx2);
            double y;
            double x1 = x1Min;
            double x2 = x2Min;
            double sum = 0;
            for (double x = x1Min; x <= x1Max; x += dx1)
            {
                Console.Write("\t{0}", x);
            }
            Console.WriteLine();
            for (x2 = x2Min; x2 <= x2Max; x2 += dx2)
            {
                Console.Write("{0}\t", x2);
                for (x1 = x1Min; x1 <= x1Max; x1 += dx1)
                {
                    y = (Math.Sqrt(Math.Pow(x1, 3) + Math.Pow(x2, 5)) / 1000) + 65;
                    Console.Write("{0:#.####}\t", y);
                    if (y > 0)
                    {
                        sum += y;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum = {0:#.####}", sum);
            Console.ReadKey();
        }
    }
}
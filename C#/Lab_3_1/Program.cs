using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1
{
    public delegate double FuncDelegate(double x);
    class Program
    {
        public static double QuadCentral(double a, double b, double n, FuncDelegate func)
        {
            double h = (b - a) / n;
            double q = 0;
            for (double x = a; x < b; x += h)
            {
                q += func(x + h / 2);
            }
            return q * h;
        }
        static double f1(double x)
        {
            return Math.Pow((2 * x) * ((5 * x) / (2 * x + 53 * Math.Pow(5 * x, 2))), 2);
        }

        static double f2(double x)
        {
            return (Math.Sqrt(Math.Pow(x, 3) + Math.Pow(x, 5)) / 1000) + 65;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введiть кiлькiсть дiлянок n: ");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            FuncDelegate[] funcs = { f1, f2 };
            foreach(FuncDelegate f in funcs)
            {
                double r = QuadCentral(a, b, n, f);
                Console.WriteLine("Integral: [{0}, {1}] = {2}", a, b, r);
            }
        }
    }
}

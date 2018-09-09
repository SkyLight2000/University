using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть початкове значення Xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);
            Console.Write("Введіть кінцеве значення Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = Double.Parse(sxMax);
            Console.Write("Введіть приріст dx: ");
            string sdx = Console.ReadLine();
            double dx = Double.Parse(sdx);

            double x = xMin;
            double y;
            double sum = 0;

            while (x <= xMax)
            {
                double x1 = x, x2 = 3 * x;
                y = (Math.Pow(Math.Sin(x1), 3) + 45 + x2) / (2 * Math.Pow(x1, 4) + 4 * x2);
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;
                sum += y;
            }
            Console.WriteLine("Sum = {0}", sum);

            if (Math.Abs(x - xMax - dx) > 0.0001)
            {
                y = (Math.Pow(Math.Sin(xMax), 3) + 45 + xMax) / (2 * Math.Pow(xMax, 4) + 4 * xMax);
                Console.WriteLine("x = { 0}\t\t y = { 1 }", xMax, y);
            }
            Console.ReadKey();
        }
    }
}

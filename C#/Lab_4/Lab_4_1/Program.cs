using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        const double StartX = 2;
        const double StartY = 4;
        const double dX = 0.7;
        const double dY = 0.5;
        static double Function(double x)
        {
            return x * Math.Sin(x);
        }

        static double Function2(double x1, double x2)
        {
            return 4 * Math.Sin(3 + x1 * x2) / (34 - 9 * Math.Pow(x2, 3));
        }
        static void Main(string[] args)
        {
            double x = StartX;
            double[,] arr = new double[5, 5];
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                double y = StartY;
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = Function2(x, y);
                    x += dX;
                    y += dY;
                    Console.Write("{0:0.0000} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double aMin = 0;
            double aMax = 0;
            double aAvg = 0;
            double n = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] < aMin)
                    {
                        aMin = arr[i, j];
                    }
                    if (arr[i, j] > aMax)
                    {
                        aMax = arr[i, j];
                    }
                    aAvg += arr[i, j];
                }
            }
            aAvg = aAvg / arr.Length;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                for (int j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] < aAvg)
                    {
                        n++;
                    }
                }
            }
            Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
            Console.WriteLine("Кiлькiсть елементiв менших за середнє значення масиву: {0}", n);
            Console.ReadLine();
        }
    }
}
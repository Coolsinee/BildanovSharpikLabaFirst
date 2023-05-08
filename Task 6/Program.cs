using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static double firstfunc(double l)
        {
            return Math.Log10(l * l - 3 * l + 2);
        }
        static double BisCMethod(double a, double b, double epsilon)
        {
            if (a >= b)
            {
                throw new ArgumentException("Некорректный интервал");
            }

            double fA = firstfunc(a);
            double fB = firstfunc(b);

            if (fA * fB >= 0)
            {
                throw new ArgumentException("Функция не меняет знак на концах интервала");
            }

            while (b - a >= epsilon)
            {
                double c = (a + b) / 2;
                double fC = firstfunc(c);

                if (fC == 0)
                {
                    return c;
                }
                else if (fA * fC < 0)
                {
                    b = c;
                    fB = fC;
                }
                else
                {
                    a = c;
                    fA = fC;
                }
            }
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0.9;
            double epsilon = 0.001;
            double l = BisCMethod(a, b, epsilon);
            Console.WriteLine($"Корень уравнения: {l:F3}");
        }
    }
}

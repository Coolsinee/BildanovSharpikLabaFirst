using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuals_1
{
    internal class Program
    {
        static void vvod(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void fortask1(int[] a, double[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < -4)
                {
                    b[i] = ((a[i] * a[i] - 1 / a[i]) / (3 * a[i]) * ((a[i] + 3) / (1 + a[i])));
                }
                else if (a[i] >= -4 && a[i] < Math.PI * 6)
                {
                    b[i] = Math.Pow(a[i] - 5, 2) * Math.Pow(Math.Sin(a[i] * 2), 2);
                }
                else
                {
                    b[i] = 35 / 3;
                }
            }
        }
        static double average(double[] c, int a, int b)
        {
            double av = 0;
            int j = 1;
            for (int k = 0; k < c.Length; k++)
            {
                if (c[k] >= a && c[k] <= b)
                {
                    av += c[k];
                    j++;
                }
            }
            if (j == 1) { return 0; }
            return av / j;
        }
        static int entrycheck(int[] a, double[] b)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (-1 * a[i] + 8 <= b[i] && a[i] <= 8 && a[i] >= 0 && b[i] >= 0 && b[i] <= 8)
                {
                    c++;
                }
                else if (a[i] - 8 >= b[i] && a[i] <= 8 && a[i] >= 0 && b[i] <= 0 && b[i] >= -8)
                {
                    c++;
                }
                else if (a[i] >= -4 && a[i] <= 0 && b[i] >= 0 && b[i] <= 8 && Math.Pow(a[i], 2) + Math.Pow(b[i], 2) <= 64)
                {
                    c++;
                }
                else if (a[i] >= -8 && a[i] <= 0 && b[i] <= 0 && b[i] >= -8 && Math.Pow(a[i], 2) + Math.Pow(b[i], 2) <= 64)
                {
                    c++;
                }
                else if (a[i] >= -8 && a[i] <= 8 && b[i] == 0)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            int[] a = new int[8];
            double[] b = new double[8];
            double av;
            vvod(a);
            Console.Write("Введите два числа: ");
            int d = Convert.ToInt32(Console.ReadLine()), f = Convert.ToInt32(Console.ReadLine());
            fortask1(a, b);
            Console.WriteLine("Массив f(x): ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(b[i] + " ");
            }
            if (d <= f)
            {
                av = average(b, d, f);
            }
            else
            {
                av = average(b, f, d);
            }
            Console.WriteLine("Среднее значение между а и b = " + av);
            Console.WriteLine("Всего точек в этой области = " + entrycheck(a, b));
        }
    }
}

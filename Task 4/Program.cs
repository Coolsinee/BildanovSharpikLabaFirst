using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static double func(double x)
        {
            if (x < -3) return (1 + Math.Pow(x, 2)) / (2 * x);
            else if (x >= Math.PI / 4) return 7.0 / 3;
            else return (Math.Pow(x, 2) - 3) * Math.Sin(x);
        }
        static void Arr_x(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        static bool Hit(double a, double b)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) <= 16 && 0 <= b && b <= 4 && 0 >= a && a >= -4)
            {
                return true;
            }
            else if (0 >= a && a >= -4 && -4 <= b && b <= 0 && b >= -a - 4)
            {
                return true;
            }
            else if (a >= 0 && a <= 2 && 0 <= b && b <= 4 && b <= -2 * a + 4)
            {
                return true;
            }
            else if (a >= 0 && a <= 2 && b <= 0 && b >= -4)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr_x = new double[n];
            double[] arr_y = new double[n];
            Arr_x(arr_x);
            for (int i = 0; i < arr_x.Length; i++)
            {
                arr_y[i] = func(arr_x[i]);
            }
            for (int i = 0; i < arr_x.Length; i++)
            {
                if (Hit(arr_x[i], arr_y[i])) { Console.WriteLine($"{arr_x[i]} \t| {arr_y[i]} \t| True"); }
                else { Console.WriteLine($"{arr_x[i]} \t| {arr_y[i]} \t| False"); }
            }
        }
    }
}

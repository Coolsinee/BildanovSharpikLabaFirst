using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static double Maximum(double first, double second, double third)
        {
            return Math.Max(Math.Max(first, second), third);
        }
        static double Translate(double type, int v)
        {
            return type * v;
        }

        static void Main(string[] args)
        {
            const double charka = 0.123, shkalik = 0.06;
            string firstname, secondname, thirdname;
            int x, y, z, w;
            Console.WriteLine("Введите именя трех друзей: ");
            firstname = Console.ReadLine();
            secondname = Console.ReadLine();
            thirdname = Console.ReadLine();
            Console.WriteLine("Введите x, y, z, w");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            double first = Translate(charka, x);
            double second = Translate(shkalik, y);
            double third = Translate(charka, z) + Translate(shkalik, w);
            double overall = first + second + third;
            Console.WriteLine(firstname + " выпил " + first + " литров");
            Console.WriteLine(secondname + " выпил " + second + " литров");
            Console.WriteLine(thirdname + " выпил " + third + " литров");
            Console.WriteLine("\nВыпили от полулитра до литра: ");
            if (first > 0.5 && first < 1) Console.WriteLine(firstname);
            if (second > 0.5 && second < 1) Console.WriteLine(secondname);
            if (third > 0.5 && third < 1) Console.WriteLine(thirdname);
            Console.WriteLine("\nВсего ребята выпили: \n" + overall + " литров");
            Console.WriteLine("\nМаксимально выпитый объем одним из 3 друзей:\n" + Maximum(first, second, third));
        }
    }
}

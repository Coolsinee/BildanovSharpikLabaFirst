using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static bool Default(int x)
        {
            int count = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) { count++; }
            }
            if (count == 0) { return true; }
            else { return false; }
        }
        static void Numbers(int n)
        {
            for (int i = 2; i < n + 1; i++)
            {
                if (Default(i)) { Console.WriteLine(i); }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое неотрицательное число: ");
            int n = int.Parse(Console.ReadLine());
            Numbers(n);
        }
    }
}

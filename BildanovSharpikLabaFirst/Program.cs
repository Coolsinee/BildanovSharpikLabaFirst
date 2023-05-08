using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здаровствуй, бренный мир /)_/)\n" + "Это приложение для высчитывания твоего возраста через год.  (useless)\n" + "Введите свое имя: ");
            string nametag = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10 && age <= 20)
                Console.WriteLine("Здравствуй, " + nametag + "\nВ следующем году тебе будет: " + (age + 1) + " лет");
            else
            {
                int lastNumberAge = age % 10;
                switch (lastNumberAge)
                {
                    case 1:
                        Console.WriteLine("Здравствуй, " + nametag + "\nВ следующем году тебе будет: " + (age + 1) + " год");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        break;
                        Console.WriteLine("Здравствуй, " + nametag + "\nВ следующем году тебе будет: " + (age + 1) + " года");
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 0:
                        Console.WriteLine("Здравствуй, " + nametag + "\nВ следующем году тебе будет: " + (age + 1) + " лет");
                        break;
                }
            }
        }
    }
}

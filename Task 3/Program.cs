using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Age(int l)
        {
            string year;
            if (l % 10 == 1) { year = " год"; }
            else if (l % 10 == 2 || l % 10 == 3 || l % 10 == 4) { year = "  года"; }
            else { year = " лет"; }
            Console.WriteLine("Вам " + l + year);
        }
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Введите дату рождения: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            int age = today.Year - birthday.Year;
            if (today.Month == birthday.Month && today.Day < birthday.Day || today.Month < birthday.Month)
            { age--; }
            Age(age);
        }
    }
}

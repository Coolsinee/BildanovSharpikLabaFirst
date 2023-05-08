using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int g = int.Parse(Console.ReadLine());
            int[] arr = new int[g];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите элемент массива с индексом - {i}: \t ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int c = 0;
            Console.WriteLine("Введите элемент, который необходимо удалить: ");
            int element = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != element)
                {
                    c++;
                }
            }
            int[] new_array = new int[c];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] != element)
                {
                    new_array[j] = arr[i];
                    j++;
                }
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write($"{new_array[i]} ");
            }
        }
    }
}

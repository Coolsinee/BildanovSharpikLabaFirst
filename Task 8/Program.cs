using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[70];
            Random anyrandom = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = anyrandom.Next(-200, 200);
            }

            for (int i = 0; i < array.Length; i += 2)
            {
                int minindex = i;
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[minindex])
                    {
                        minindex = j;
                    }
                }
                if (minindex != i)
                {
                    int flag = array[i];
                    array[i] = array[minindex];
                    array[minindex] = flag;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}

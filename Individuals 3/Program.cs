using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuals_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3; // количество ромбов
            double[] areas = new double[n];
            double[] perimeters = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите сторону ромба {i + 1}:");
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"Введите высоту ромба {i + 1}:");
                double height = double.Parse(Console.ReadLine());

                double area = CalculateRhombusArea(side, height);
                areas[i] = area;

                double perimeter = CalculateRhombusPerimeter(side);
                perimeters[i] = perimeter;

                Console.WriteLine($"Площадь ромба {i + 1}: {area:F2}");
                Console.WriteLine($"Периметр ромба {i + 1}: {perimeter:F2}");
                Console.WriteLine();
            }

            double sumOfAreasMenshieChem10 = 0;
            double maxPerimeter = 0;
            double AreaAndPerimeterOfSecondRhombus = 0;

            for (int i = 0; i < n; i++)
            {
                if (areas[i] < 10)
                {
                    sumOfAreasMenshieChem10 += areas[i];
                }

                if (perimeters[i] > maxPerimeter)
                {
                    maxPerimeter = perimeters[i];
                }

                if (i == 1)
                {
                    AreaAndPerimeterOfSecondRhombus = areas[i] * perimeters[i];
                }
            }

            Console.WriteLine($"Сумма площадей ромбов, меньших 10: {sumOfAreasMenshieChem10:F2}");
            Console.WriteLine($"Наибольший периметр: {maxPerimeter:F2}");
            Console.WriteLine($"Произведение площади и периметра 2-го ромба: {AreaAndPerimeterOfSecondRhombus:F2}");
        }

        static double CalculateRhombusArea(double side, double height)
        {
            return side * height;
        }

        static double CalculateRhombusPerimeter(double side)
        {
            return 4 * side;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuals_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 0, 8},
                {9, 10, 11, 12},
                {13, 14, 0, 16},
                {17, 18, 19, 20},
                {21, 22, 23, 0}
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int colsWithZeros = 0;
            int maxSeriesRowIndex = -1;
            int maxSeriesLength = 0;

            for (int j = 0; j < cols; j++)
            {
                bool foundZero = false;

                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        foundZero = true;
                        break;
                    }
                }

                if (foundZero)
                {
                    colsWithZeros++;
                }
            }

            Console.WriteLine($"Количество столбцов, содержащих хотя бы один нулевой элемент: {colsWithZeros}");

            for (int i = 0; i < rows; i++)
            {
                int currentSeriesLength = 1;
                int maxCurrentSeriesLength = 1;
                int prevValue = matrix[i, 0];

                for (int j = 1; j < cols; j++)
                {
                    int currentValue = matrix[i, j];

                    if (currentValue == prevValue)
                    {
                        currentSeriesLength++;

                        if (currentSeriesLength > maxCurrentSeriesLength)
                        {
                            maxCurrentSeriesLength = currentSeriesLength;
                        }
                    }
                    else
                    {
                        currentSeriesLength = 1;
                    }

                    prevValue = currentValue;
                }

                if (maxCurrentSeriesLength > maxSeriesLength)
                {
                    maxSeriesLength = maxCurrentSeriesLength;
                    maxSeriesRowIndex = i;
                }
            }

            if (maxSeriesRowIndex >= 0)
            {
                Console.WriteLine($"Номер строки, в которой находится самая длинная серия одинаковых элементов: {maxSeriesRowIndex}");
            }
            else
            {
                Console.WriteLine("Матрица не содержит серий одинаковых элементов");
            }
        }
    }
}

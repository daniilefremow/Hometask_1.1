using System;

namespace Hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число cтрок массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов массива: ");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            int summa = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Введите mas[{0},{1}]", i, j);
                    mas[i, j] = int.Parse(Console.ReadLine());

                    if (mas[i, j] % 2 == 0)
                    {
                        summa += mas[i, j];
                    }
                }

            }
            Console.WriteLine("Сумма всех четных элементов = {0}", summa);
            Console.ReadLine();
        }
    }
}

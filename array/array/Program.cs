using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество столбцов массивов");
            int n = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Введите количество строк массивов");
            int m = int.Parse(Console.ReadLine());
            int[ , ] mass1 = new int[n, m];
            Console.WriteLine("Введите значения первого массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mass1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[ , ] mass2 = new int[n, m];
            Console.WriteLine("Введите значения второго массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mass2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] mass = new int[n, m];
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    mass[i, j] = mass1[i, j] + mass2[i, j];
                }
            }
            Console.WriteLine("Результат сложения массивов");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

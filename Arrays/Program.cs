//#define ARAYS1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARAYS1
            Console.WriteLine("Arrays");
            Console.Write("Введите размер массива: ");
            int n = 5;//Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Размер массива: {arr.Length}");
            Console.WriteLine($"Количество измерений: {arr.Rank}");
            Console.WriteLine($"Размер массива: {arr.GetLength(0)}");

            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            //int sum = 0;
            //double Sr = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];

            //}
            //    Sr =(double) sum / arr.Length;
            //Console.WriteLine($"{ sum}");
            //Console.WriteLine($"{Sr}");
            Console.WriteLine($"Сумма элементов: {arr.Sum()}");
            Console.WriteLine($"Среднеарифметическое: {arr.Average()}");
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min()); 
#endif
            Console.WriteLine("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество элементов строки: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] i_arr_2 = new int[rows, cols];
            Random rand = new Random(0);
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = rand.Next(100);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма элементов:{i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"\nСреднеарифметическое элементов:{i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"\nМинимальный элемент элементов:{i_arr_2.Cast<int>().Min()}");
            Console.WriteLine($"\nМаксимальный элементов:{i_arr_2.Cast<int>().Max()}");
        }
    }
}





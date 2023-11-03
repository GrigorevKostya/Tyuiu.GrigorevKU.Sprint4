using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorevKU.Sprint4.Task3.V11.Lib;
namespace Tyuiu.GrigorevKU.Sprint4.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 8, 6, 9, 4, 5 }, { 9, 4, 8, 5, 6 }, { 9, 7, 9, 8, 4 }, { 4, 6, 5, 7, 8 }, { 6, 6, 7, 6, 4 } };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Григорьев К. Ю. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил Григорьев К. Ю. | ИИПб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает кол-во нечетных элементов массива.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Количество нечетных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}

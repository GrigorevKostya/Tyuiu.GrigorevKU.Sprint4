using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorevKU.Sprint4.Task0.V25.Lib;
namespace Tyuiu.GrigorevKU.Sprint4.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Григорьев К. Ю. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил Григорьев К. Ю. | ИИПб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает сумму четных элементов массива.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.WriteLine("Исходный массив: ");
            for (int i =0; i <= numsArray.Length -1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}

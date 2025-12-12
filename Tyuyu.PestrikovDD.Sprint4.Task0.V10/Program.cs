using Tyuiu.PestrikovDD.Sprint4.Task0.V10.Lib;

namespace Tyuiu.PestrikovDD.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Пестриков Д. Д. | ИСТНБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Пестриков Данила Дмитриевич | ИСТНб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}             *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.WriteLine("Исходный массив:");
            foreach (int num in numsArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечётных элементов массива:");
            Console.WriteLine(ds.GetSumOddArrEl(numsArray));
            Console.ReadKey();

        }
    }
}
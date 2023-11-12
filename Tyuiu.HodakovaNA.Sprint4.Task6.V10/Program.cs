using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint4.Task6.V10.Lib;

namespace Tyuiu.HodakovaNA.Sprint4.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс ArrayФайл                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Ходакова НАдежда Антоновна | АСОиУб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных ['Театр', 'Кино', 'Музей', 'Парк',          *");
            Console.WriteLine("* 'Зоопарк', 'Концерт', 'Выставка'], используя класс Array, выведите      *");
            Console.WriteLine("* элементы массива, длина которых меньше 7 символов.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            var Data = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine(Data[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Элементы массива, длина которых меньше 7:");

            string[] nums = ds.Calculate(Data);
            var res = string.Join(", ", nums);
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}

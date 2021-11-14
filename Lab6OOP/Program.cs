            using System;
            using System.IO;
            using System.Linq;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            Console.WriteLine("Данные из файла:");
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine($"Среднее арифметическое:{array.Average()}");
            Console.WriteLine($"Сумма:{array.Sum()}");
        }
    }
}
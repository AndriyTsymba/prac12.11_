using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = new int[5];
            int sum = 0;
            int product = 1;
            int max = int.MinValue;
            int min = int.MaxValue;

            Console.WriteLine("Введіть 5 чисел:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];

                product *= numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.WriteLine($"Сума чисел: {sum}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Добуток чисел: {product}");
        }
    }
}
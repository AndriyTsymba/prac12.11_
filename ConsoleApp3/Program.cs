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

            Console.WriteLine("Введіть шестизначне число:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100000 && number <= 999999)
            {
                string reversedNumber = new string(number.ToString().Reverse().ToArray());

                Console.WriteLine($"Перевернуте число: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Введене число не є шестизначним.");
            }


        }
    }
}
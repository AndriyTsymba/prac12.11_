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

            Console.Write("vvedit znachennya: ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.Write("vvedit vidsotok: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            double result = (value * percentage) / 100;

            Console.WriteLine($"{percentage} % vid {value} = {result}");
        }
    }
}
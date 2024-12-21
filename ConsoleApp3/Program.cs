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

            Console.WriteLine("vvedit daty");
            string input = Console.ReadLine();


            DateTime date;
            if (!DateTime.TryParse(input, out date))
            {
                Console.WriteLine("data perebor.");
                return;
            }

            string season = GetSeason(date.Month);

            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeek}");
        }

        static string GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
                return "Winter";
            if (month >= 3 && month <= 5)
                return "Spring";
            if (month >= 6 && month <= 8)
                return "Summer";
            return "Autumn";
        }
    }
}
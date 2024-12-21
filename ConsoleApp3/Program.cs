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

            Console.WriteLine("Введіть число A (A < B):");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число B (A < B):");
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("Число A повинно бути меншим за число B.");
                return;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, i, number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < number; ++i)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}

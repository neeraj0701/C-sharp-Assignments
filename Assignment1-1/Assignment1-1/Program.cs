using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            int i = 0;
            int j = string2.Length;
            int counter = 0;
            for (i = 0; i < string1.Length - j; i++)
            {
                if (string1.Substring(i, j) == string2)
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(counter);
        }
    }
}

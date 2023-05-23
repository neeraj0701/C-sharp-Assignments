using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            String bigger = Console.ReadLine();
            int greatest = 0, greatest1 = 0;
            for (int i = 0; i < bigger.Length - 4; i++)
            {
                greatest1 = (bigger[i] - '0') * (bigger[i + 1] - '0') * (bigger[i + 2] - '0') * (bigger[i + 3] - '0');
                if (greatest < greatest1)
                {
                    greatest = greatest1;
                }
            }
            Console.WriteLine(greatest);
        }
    }
}

using System;
using System.Threading;

namespace Program1
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("enter the first string");
            string string1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string string2 = Console.ReadLine();
            Validation validation = new Validation();

            //its check whether given input is correct or wrong
            if (!validation.IsValid(string1, string2))
            {
                Console.WriteLine("wrong input");
            }

            else
            {
                SubStrings subStrings = new SubStrings(string1, string2);
                Console.WriteLine("no. of times occured : " + subStrings.CountOfSubStrings(string1, string2));
                int[] indexes = subStrings.IndexesOfSubStrings(string1, string2);
                Console.Write("index positions : ");

                if (subStrings.CountOfSubStrings(string1,string2)>0)
                {   
                    for(int iterator = 0;iterator < subStrings.CountOfSubStrings(string1, string2); iterator++)
                    {
                        Console.Write(indexes[iterator]+" ");
                    }
                }
            }
        }
    }
}

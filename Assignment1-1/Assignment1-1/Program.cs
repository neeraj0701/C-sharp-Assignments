using System;

namespace Program1
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Validation validation = new Validation();
            while (true)
            {
                if (!validation.IsValid(string1, string2))
                {
                    Console.WriteLine("check your input");
                    string1 = Console.ReadLine();
                    string2 = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            SubStrings subStrings = new SubStrings();
            Console.WriteLine(subStrings.CountOfSubStrings(string1,string2));
            subStrings.IndexesOfSubStrings(string1,string2);
        }
    }
}

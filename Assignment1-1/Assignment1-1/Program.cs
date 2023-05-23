﻿using System;

namespace Program1
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Validation validate = new Validation();
            while (true)
            {
                if (!validate.IsValid(string1, string2))
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
            Console.WriteLine("No.of times occured = "+subStrings.CountOfSubStrings(string1,string2));
        }
    }
}

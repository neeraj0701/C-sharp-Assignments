using System;
using System.Numerics;

namespace Program2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger bigInteger = BigInteger.Parse(Console.ReadLine());
            Validation validate = new Validation();

            while (true)
            {
                if (!validate.IsValid(bigInteger))
                {
                    Console.WriteLine("check your input");
                    bigInteger = BigInteger.Parse(Console.ReadLine());
                }

                else
                {
                    break;
                }
            }
            
            String large = bigInteger.ToString();
            GreatestProduct greatestProduct = new GreatestProduct();
            Console.WriteLine(greatestProduct.greatestAdjacentDigitsProduct(large));
        }
    }
}

using System;
using System.Numerics;

namespace Program2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            BigInteger bigInteger = BigInteger.Parse(inputOutput.Input());
            String larger = bigInteger.ToString();
            Validation validate = new Validation();

            if (!validate.IsValid(larger))
            {
                Console.WriteLine("wrong input");
            }

            int[] large = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                large[i] = input[i];
            }
            //String large = bigInteger.ToString();
            //GreatestProduct greatestProduct = new GreatestProduct();
            //Console.WriteLine(greatestProduct.greatestAdjacentDigitsProduct(large));
        }
    }
}

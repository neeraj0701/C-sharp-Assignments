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

            int[] large = new int[larger.Length];
            for(int i = 0; i < larger.Length; i++)
            {
                large[i] = larger[i];
            }
            //String large = bigInteger.ToString();
            //GreatestProduct greatestProduct = new GreatestProduct();
            //Console.WriteLine(greatestProduct.greatestAdjacentDigitsProduct(large));
        }
    }
}

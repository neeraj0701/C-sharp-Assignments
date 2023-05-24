using System;

namespace Program2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Validation validate = new Validation();

            if (!validate.IsValid(input))
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

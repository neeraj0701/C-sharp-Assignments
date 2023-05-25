using System;
using System.Numerics;

namespace Program2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            GreatestProduct greatestProduct = new GreatestProduct();
            BigInteger bigInteger = BigInteger.Parse(inputOutput.Input());
            Console.WriteLine(bigInteger);
            Validation validate = new Validation();

            if (validate.IsValid(bigInteger))
            {
                string large = bigInteger.ToString();
                inputOutput.DisplayOutput(greatestProduct.GreatestAdjacentDigitsProduct(large));
            }
        }
    }
}

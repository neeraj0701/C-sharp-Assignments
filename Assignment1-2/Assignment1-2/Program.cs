﻿using System;
using System.Numerics;

namespace Program2
{
    /// <summary>
    /// class that contains main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method where program execution start
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            GreatestProduct greatestProduct = new GreatestProduct();
            BigInteger bigInteger = BigInteger.Parse(inputOutput.Input());
            Validation validate = new Validation();

            if (validate.IsValid(bigInteger))
            {
                string large = bigInteger.ToString();
                inputOutput.DisplayOutput(greatestProduct.GreatestAdjacentDigitsProduct(large));
            }
        }
    }
}

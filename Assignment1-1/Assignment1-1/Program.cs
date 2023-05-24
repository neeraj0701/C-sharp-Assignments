using System;

namespace Program1
{
    /// <summary>
    /// class that contains main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// below is main method where execution begins
        /// </summary>
        public static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            string string1 = inputOutput.Input1();
            string string2 = inputOutput.Input2();
            Validation validation = new Validation();

            if (!validation.IsInput1Valid(string1) && !validation.IsInput2Valid(string2))
            {
                inputOutput.DisplayInputValidate(0);
            }

            else if (!validation.IsInput1Valid(string1))
            {
               inputOutput.DisplayInputValidate(1);
            }

            else if (!validation.IsInput2Valid(string2))
            {
                inputOutput.DisplayInputValidate(2);
            }

            else if (!validation.IsValid(string1, string2))
            {
                inputOutput.DisplayInputValidate(3);
            }

            else
            {
                SubStrings subStrings = new SubStrings();
                inputOutput.DisplayOutput(subStrings.CountOfSubStrings(string1, string2), subStrings.IndexesOfSubStrings(string1, string2), subStrings.CountOfSubStrings(string1, string2));
            }
        }
    }
}

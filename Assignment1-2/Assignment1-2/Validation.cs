using System;
using System.Numerics;
using Program2;
/// <summary>
/// contains methods which implements the validations
/// </summary>
public class Validation
{
    /// <summary>
    /// method returns that given input is correct or wrong
    /// </summary>
    /// <param name="bigInteger"></param>
    /// <returns></returns>
    public bool IsValid(BigInteger bigInteger)
    {
        InputOutput inputOutput = new InputOutput();
        int counter = 0;

        while (counter <= 4 && bigInteger > 0)
        {
            bigInteger = bigInteger / 10;
            counter++;
        }

        if (counter < 4)
        {
            inputOutput.DisplayInputValid();
            return false;
        }

        return true;
    }
}


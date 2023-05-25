using System;
using System.Diagnostics;
using System.Numerics;
using Program2;

public class Validation
{
    public bool IsValid(BigInteger bigInteger)
    {
        InputOutput inputOutput = new InputOutput();
        int counter = 0;

        while (counter <= 4)
        {
            bigInteger = bigInteger / 10;
            counter++;
        }

        if (bigInteger < 4)
        {
            inputOutput.DisplayInputValid();
            return false;
        }

        return true;
    }
}


using System;
using System.Numerics;
using Program2;

public class Validation
{
    public bool IsValid(BigInteger bigInteger)
    {
        int reminder = 0, count = 0;

        while (bigInteger > 0 && count <= 4)
        {
            reminder = (int)bigInteger % 10;
            count++;
            bigInteger /= 10;
        }

        if (count < 4)
        {
            return false;
        }

        return true;
    } 
}


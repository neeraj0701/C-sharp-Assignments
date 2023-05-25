using System;
using Program2;

public class UtilityFunctions
{
    public int LengthOfString(string chars)
    {
        int counter = 0;

        foreach (char c in chars)
        {
            counter++;
        }

        return counter;
    }
}


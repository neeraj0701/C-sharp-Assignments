using System;
using Program2;

/// <summary>
/// contains all the utility methods
/// </summary>
public class UtilityFunctions
{
    /// <summary>
    /// returns the length of string
    /// </summary>
    /// <param name="chars"></param>
    /// <returns></returns>
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


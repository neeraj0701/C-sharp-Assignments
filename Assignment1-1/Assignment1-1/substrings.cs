using System;
using Program1;

/// <summary>
/// used for logic purpose
/// </summary>
public class SubStrings
{
    /// <summary>
    /// logic for count of substrings in string
    /// </summary>
    /// <param name="string1"></param>
    /// <param name="string2"></param>
    /// <returns></returns>
    public int CountOfSubStrings(string string1, string string2)
    {
        UtilityFunctions utilityFunctions = new UtilityFunctions();
        int lengthOfString1 = utilityFunctions.LengthOfString(string1);
        int lengthOfString2 = utilityFunctions.LengthOfString(string2);
        int counter = 0;

        if (lengthOfString1 == lengthOfString2 && string1 == string2)
        {
            counter++;
        }

        else
        {
            for (int iterator = 0; iterator < lengthOfString1 - (lengthOfString2 - 1); iterator++)
            {
                if (utilityFunctions.SubStringsOfString(string1, iterator, lengthOfString2) == string2)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    /// <summary>
    /// count of starting index positions where string2 is occurred in string1
    /// </summary>
    /// <param name="string1"></param>
    /// <param name="string2"></param>
    /// <returns></returns>
    public int[] IndexesOfSubStrings(string string1, string string2)
    {
        UtilityFunctions utilityFunctions = new UtilityFunctions();
        int lengthOfString1 = utilityFunctions.LengthOfString(string1);
        int lengthOfString2 = utilityFunctions.LengthOfString(string2);
        int[] indexes = new int[CountOfSubStrings(string1, string2)];
        int index = 0;

        if (lengthOfString1 == lengthOfString2)
        {
            if (string1 == string2)
            {
                indexes[0] = 0;
            }
        }

        else
        {
            for (int iterator = 0; iterator < lengthOfString1 - (lengthOfString2 - 1); iterator++)
            {
                if (utilityFunctions.SubStringsOfString(string1, iterator, lengthOfString2) == string2)
                {
                    if (index < CountOfSubStrings(string1, string2))
                    {
                        indexes[index] = iterator;
                        index++;
                    }
                }
            }
        }

        return indexes;
    }
}

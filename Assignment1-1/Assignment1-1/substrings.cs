using System;
using Program1;

public class SubStrings
{
    int lengthOfString1;
    int lengthOfString2;

    //below constructor will initialize above values
    public SubStrings(string string1,string string2) 
    {
        lengthOfString1 = Functions.LengthOfString(string1);
        lengthOfString2 = Functions.LengthOfString(string2);
    }

    //below method will returns the count of string2 occurred in string1
    public int CountOfSubStrings(string string1, string string2)
    {
        int counter = 0;

        if (lengthOfString1 == lengthOfString2 && string1 == string2)
        {
            counter++;
        }

        else
        {
            for (int iterator = 0; iterator < lengthOfString1 - (lengthOfString2 - 1); iterator++)
            {
                if (Functions.SubStringsOfString(string1, iterator, lengthOfString2) == string2)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    //its prints the starting index positions where string2 is occurred in string1
    public int[] IndexesOfSubStrings(string string1, string string2)
    {
        int[] indexes = new int[CountOfSubStrings(string1, string2)];
        int index=0;

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
                if (Functions.SubStringsOfString(string1, iterator, lengthOfString2) == string2)
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

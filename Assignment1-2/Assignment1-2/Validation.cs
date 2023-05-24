using System;
using Program2;

public class Validation
{
    public bool IsValid(string input)
    {
        for(int i = 0; i < input.Length; i++)
        {
            if (!(input[i]-'0' >=0  && input[i]-'0' <=9))
            {
                return false;
            }
        }

        if (input.Length < 4)
        {
            return false;
        }

        return true;
    } 
}


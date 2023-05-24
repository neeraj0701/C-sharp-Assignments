using System;
using Program1;

public class Functions
{
    // the below method will returns length of string
    public static int LengthOfString(string chars)
    {
        int counter = 0;

        foreach (char c in chars)
        {
            counter++;
        }

        return counter;
    }

    //the below method will returns substring of string
    public static string SubStringsOfString(string chars,int start,int length)
    {
        string subStr="";

        for(int i = start; i < start + length; i++)
        {
            subStr += chars[i];
        }

        return subStr;
    }
}


using System;
using Program1;

/// <summary>
/// utility functions 
/// </summary>
public class UtilityFunctions
{
    /// <summary>
    /// the below method will returns length of string
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

    /// <summary>
    /// the below method will returns substring of string
    /// </summary>
    /// <param name="chars"></param>
    /// <param name="start"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public string SubStringsOfString(string chars,int start,int length)
    {
        string subStr="";

        for(int i = start; i < start + length; i++)
        {
            subStr += chars[i];
        }

        return subStr;
    }
}


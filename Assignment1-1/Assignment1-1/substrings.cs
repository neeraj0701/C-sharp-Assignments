using System;
using System.Reflection;
using Program1;

public class SubStrings
{
    public int CountOfSubStrings(string string1, string string2)
    {
        int counter = 0;
        if (string1.Length == string2.Length && string1 == string2)
        {
            counter++;
        }
        for (int i = 0, j = string2.Length; i < string1.Length - (j - 1); i++)
        {
            if (string1.Substring(i, j) == string2)
            {
                counter++;
            }
        }
        return counter;
    }
    public void IndexesOfSubStrings(string string1, string string2)
    {
        if (string1.Length == string2.Length)
        {
            if(string1 == string2)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        else
        {
            for (int i = 0, j = string2.Length; i < string1.Length - (j - 1); i++)
            {
                if (string1.Substring(i, j) == string2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

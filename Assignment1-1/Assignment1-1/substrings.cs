using System;
using Program1;

    public class SubStrings
    {
        public int CountOfSubStrings(string string1,string string2)
        {
            int counter = 0;
            for (int i = 0,j=string2.Length; i < string1.Length - j; i++)
            {
                if (string1.Substring(i, j) == string2)
                {
                    counter++;
                }
            }
            return counter;
        }
    }


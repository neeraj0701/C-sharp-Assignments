using System;
using Program1;

    public class Validation
    {
        public bool IsValid(string string1,string string2)
        {

            if (string1.Length < string2.Length) 
            { 
                return false;
            }

            return true;
        }
    }


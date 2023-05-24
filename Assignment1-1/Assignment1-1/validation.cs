using System;
using Program1;

    public class Validation
    {
        //its returns true if string1 is greater than string2
        //and false if string1 is less than string2
        public bool IsValid(string string1,string string2)
        {
            if (Functions.LengthOfString(string1) < Functions.LengthOfString(string2) || (Functions.LengthOfString(string1)==0 || Functions.LengthOfString(string2)==0)) 
            { 
                return false;
            }

            return true;
        }
    }


using System;
using Program1;
    
    /// <summary>
    /// class used for validation of inputs
    /// </summary>
    public class Validation
    {       
        /// <summary>
        /// validates the string1
        /// </summary>
        /// <param name="string1"></param>
        /// <returns></returns>
        public bool IsInput1Valid(string string1)
        {
            UtilityFunctions utilityFunctions = new UtilityFunctions();
            if (utilityFunctions.LengthOfString(string1)==0) 
            { 
                return false;
            }
            
            return true;
        }
        
        /// <summary>
        /// validate the string2
        /// </summary>
        /// <param name="string2"></param>
        /// <returns></returns>
        public bool IsInput2Valid(string string2) 
        {
            UtilityFunctions utilityFunctions = new UtilityFunctions();
            if (utilityFunctions.LengthOfString(string2) == 0)
            {
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// validates that string1 has more length than string2
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public bool IsValid(string string1,string string2)
        {
            UtilityFunctions utilityFunctions = new UtilityFunctions();
            if(utilityFunctions.LengthOfString(string1) < utilityFunctions.LengthOfString(string2))
            {
                return false;
            }

            return true;
        }
    }


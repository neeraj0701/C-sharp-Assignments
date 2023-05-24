using System;
using System.Runtime.CompilerServices;
using Program1;

/// <summary>
/// class for method IsValid 
/// </summary>
public class Validation
{
    /// <summary>
    /// validates the inputs
    /// </summary>
    /// <param name="string1"></param>
    /// <returns></returns>
    public bool IsValid(string string1, string string2)
    {
        UtilityFunctions utilityFunctions = new UtilityFunctions();
        InputOutput inputOutput = new InputOutput();

        if (string1 == string.Empty && string2 == string.Empty)
        {
            inputOutput.DisplayInputValidate(0);
            return false;
        }

        else if (string1 == string.Empty)
        {
            inputOutput.DisplayInputValidate(1);
            return false;
        }

        else if (string2 == string.Empty && string2 == string.Empty)
        {
            inputOutput.DisplayInputValidate(2);
            return false;
        }

        else if (utilityFunctions.LengthOfString(string1) < utilityFunctions.LengthOfString(string2))
        {
            inputOutput.DisplayInputValidate(3);
            return false;
        }
        else
        {
            return true;
        }

    }
}

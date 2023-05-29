using System;
using Program3;

/// <summary>
/// class contains all methods that implement solution
/// </summary>
public class AddingBinaries
{
    /// <summary>
    /// convert float number to binary
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public string FloatToBinary(float number)
    {
        string chars = number.ToString();
        int number1 = Int32.Parse(chars.Substring(0, chars.IndexOf('.')));
        float number2 = float.Parse(chars.Substring(chars.IndexOf('.')));
        string binary = string.Empty;

        while (number1 > 0)
        {
            binary = (number1 % 2) + binary;
            number1 /= 2;
        }

        binary += '.';
        string temporary;
        int count = 1;

        while (number2 < 1 && count <= 23)
        {
            number2 *= 2;
            binary += (int)number2;

            if (number2 > 1)
            {
                temporary = number2.ToString();
                number2 = float.Parse(temporary.Substring(temporary.IndexOf('.')));
            }

            count++;
        }

        return binary;
    }

    /// <summary>
    /// adds two binaries
    /// </summary>
    /// <param name="number1"></param>
    /// <param name="number2"></param>
    /// <returns></returns>
    public string AddingTwoBinaries(string number1, string number2)
    {
        string number11 = number1.Substring(0, number1.IndexOf('.'));
        string number12 = number1.Substring(number1.IndexOf('.'));
        string number21 = number2.Substring(0, number2.IndexOf("."));
        string number22 = number2.Substring(number2.IndexOf("."));
        int length11 = number11.Length, length12 = number12.Length, length21 = number21.Length, length22 = number22.Length;
        
        if (length11 > length21)
        {
            for (int iterator = 0; iterator < length11 - length21; iterator++)
            {
                number21 = '0' + number21;
            }
        }

        else
        {
            for (int iterator = 0; iterator < length21 - length11; iterator++)
            {
                number11 = '0' + number11;
            }
        }

        if (length12 > length22)
        {
            for (int iterator = 0; iterator < length12 - length22; iterator++)
            {
                number22 += "0";
            }
        }

        else
        {
            for (int iterator = 0; iterator < length22 - length12; iterator++)
            {
                number12 += "0";
            }
        }

        number1 = number11 + number12;
        number2 = number21 + number22;
        string number = string.Empty;
        int carry = 0, sum, length1 = number1.Length - 1, length2 = number2.Length - 1;

        while (length1 >= 0 || length2 >= 0)
        {
            if ((number1[length1] == '.' && number2[length2] == '.'))
            {
                number = '.' + number;
            }

            else
            {
                sum = (number1[length1] - '0') + (number2[length2] - '0') + carry;
                carry = sum / 2;
                number = (sum % 2) + number;
            }

            length1--;
            length2--;
        }

        if (carry > 0)
        {
            number = '1' + number;
        }

        return number;
    }

    /// <summary>
    /// converts binary to float
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public float BinaryToFloat(string number)
    {
        int number1 = 0;
        float number2 = 0f;
        int power = 0;

        for (int iterator = number.IndexOf('.') - 1; iterator >= 0; iterator--)
        {
            number1 += (number[iterator] - '0') * (int)Math.Pow(2, power);
            power++;
        }

        power = -1;

        for (int iterator = number.IndexOf('.') + 1; iterator < number.Length; iterator++)
        {
            number2 += (number[iterator] - '0') * (float)Math.Pow(2, power);
            power--;
        }

        return number1 + number2;
    }
}


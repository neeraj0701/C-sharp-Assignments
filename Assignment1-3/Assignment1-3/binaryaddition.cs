using System;
using System.ComponentModel;
using System.Linq;
using Program3;
public class BinaryAddition
{
    public string FloatToBinary(float number)
    {
        string string1 = number.ToString();
        int number1 = Int32.Parse(string1.Substring(0, string1.IndexOf('.')));
        float number2 = float.Parse(string1.Substring(string1.IndexOf('.')));
        Console.WriteLine(number2);
        string reminder = string.Empty;

        while (number1 > 0)
        {
            reminder += number1 % 2;
            number1 /= 2;
        }

        reminder += '.';
        string temporary2 = number2.ToString() + ':';
        Console.WriteLine(reminder);
        string temporary = string.Empty;

        while (number2 < 1)
        {
            number2 *= 2;
            reminder += (int)number2;
            if (number2 > 1)
            {
                temporary = number2.ToString();
                number2 = float.Parse(temporary.Substring(temporary.IndexOf('.')));
            }
            if (temporary2.Contains(number2.ToString()))
            {
                break;
            }
            temporary2 += number2.ToString() + ':';
        }

        Console.WriteLine(reminder);
        Console.WriteLine(temporary2);

        return reminder;
    }

    public string AddingTwoBinaries(string number1, string number2)
    {
        int length = (number1.Length > number2.Length) ? number1.Length : number2.Length;
        if(length == number1.length)
        {

        }
        else
        {

        }
        for (int i=0;i< length; i++)
        {

        }
    }
}


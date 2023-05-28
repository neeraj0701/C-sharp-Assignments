using System;
using Program2;

/// <summary>
/// contains methods which implements both input and output methods
/// </summary>
public class InputOutput
{
    /// <summary>
    /// take an input number
    /// </summary>
    /// <returns></returns>
    public string Input()
    {
        Console.WriteLine("Enter the number");
        String number = Console.ReadLine();
        return number;
    }

    /// <summary>
    /// display that number input is incorrect
    /// </summary>
    public void DisplayInputValid()
    {
        Console.WriteLine("no. of digits should be more than or equal to four");
    }

    /// <summary>
    /// displays the output
    /// </summary>
    /// <param name="greatest"></param>
    public void DisplayOutput(int greatest)
    {
        Console.WriteLine("greatest adjacent digits product : "+greatest);
    }
}


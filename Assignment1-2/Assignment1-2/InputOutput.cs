using System;
using Program2;

public class InputOutput
{
    public string Input()
    {
        Console.WriteLine("Enter the number");
        String number = Console.ReadLine();
        return number;
    }

    public void DisplayInputValid()
    {
        Console.WriteLine("no. of digits should be more than or equal to four");
    }

    public void DisplayOutput(int greatest)
    {
        Console.WriteLine(greatest);
    }
}


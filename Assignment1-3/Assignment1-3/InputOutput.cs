using System;
using Program3;

/// <summary>
/// contains all input and output display methods
/// </summary>
public class InputOutput
{
    /// <summary>
    /// take input1 and return input1
    /// </summary>
    /// <returns></returns>
    public float Input1()
    {
        Console.WriteLine("enter the first decimal value");
        return float.Parse(Console.ReadLine());
    
    }

    /// <summary>
    /// take input2 and return input2
    /// </summary>
    /// <returns></returns>
    public float Input2()
    {
        Console.WriteLine("enter the second decimal value");
        return float.Parse(Console.ReadLine());

    }

    /// <summary>
    /// display the output
    /// </summary>
    /// <param name="number"></param>
    public void DisplayOutput(float number)
    {
        Console.WriteLine(number);
    }
}


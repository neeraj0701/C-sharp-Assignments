using System;
using Program3;

public class InputOutput
{
    public float Input1()
    {
        Console.WriteLine("enter the first float value");
        return float.Parse(Console.ReadLine());
    }

    public float Input2()
    {
        Console.WriteLine("enter the second float value");
        return float.Parse(Console.ReadLine());
    }
}


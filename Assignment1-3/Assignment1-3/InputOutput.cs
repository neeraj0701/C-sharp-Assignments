using System;
using Program3;
public class InputOutput
{
    public float Input1()
    {
        Console.WriteLine("enter the first decimal value");
        return float.Parse(Console.ReadLine());
    
    }

    public float Input2()
    {
        Console.WriteLine("enter the second decimal value");
        return float.Parse(Console.ReadLine());

    }

    public void DisplayOutput(float number)
    {
        Console.WriteLine(number);
    }
}


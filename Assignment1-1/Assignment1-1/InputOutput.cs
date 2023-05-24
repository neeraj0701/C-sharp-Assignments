using System;
using Program1;
/// <summary>
/// used for read input and write output
/// </summary>
public class InputOutput
{
    /// <summary>
    /// read input from user 
    /// </summary>
    /// <returns></returns>
    public string Input1()
    {
        Console.WriteLine("enter the first string");
        string string1 = Console.ReadLine();
        return string1;
    }

    /// <summary>
    /// read input fro user
    /// </summary>
    /// <returns></returns>
    public string Input2()
    {
        Console.WriteLine("enter the second string");
        string string2 = Console.ReadLine();
        return string2;
    }

    /// <summary>
    /// display the wrong inputs based on validations
    /// </summary>
    /// <param name="flag"></param>
    public void DisplayInputValidate(int flag)
    {
        if (flag==0)
        {
            Console.WriteLine("both inputs are wrong");
        }

        else if (flag==1)
        {
            Console.WriteLine("wrong input1");
        }

        else if (flag==2)
        {
            Console.WriteLine("wrong input2");
        }

        else if (flag==3)
        {
            Console.WriteLine("check the size of inputs");
        }
    }

    /// <summary>
    /// display the output
    /// </summary>
    /// <param name="counter"></param>
    /// <param name="indexes"></param>
    /// <param name="length"></param>
    public void DisplayOutput(int counter, int[] indexes,int length)
    {
        Console.WriteLine("no. of times occured : " +counter);
        Console.WriteLine("index positions : ");
        if (length > 0)
        {
            for (int iterator = 0; iterator < length; iterator++)
            {
                Console.Write(indexes[iterator] + " ");
            }
        }
    }
}


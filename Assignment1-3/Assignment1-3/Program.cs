using System;

namespace Program3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            //float number1 = inputOutput.Input1();
            //float number2 = inputOutput.Input2();   
            BinaryAddition binaryAddition = new BinaryAddition();
            //Console.WriteLine(binaryAddition.FloatToBinary(number1));
            //Console.WriteLine(binaryAddition.FloatToBinary(number2));
            float n = 50.5f;
            string a = "";
            while (n >= 1)
            {
                a = (n % 2) + a;
                n = n / 2;
            }
            Console.Write(a);

            //Console.WriteLine(0.8*0.1);
        }
    }
}

using System; 

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            AddingBinaries addingBinaries = new AddingBinaries();
            float number1 = inputOutput.Input1();
            float number2 = inputOutput.Input2();
            string binary1 = addingBinaries.FloatToBinary(number1);
            string binary2 = addingBinaries.FloatToBinary(number2);
            string binary = addingBinaries.AddingTwoBinaries(binary1, binary2);
            inputOutput.DisplayOutput(addingBinaries.BinaryToFloat(binary));
        }
    }
}

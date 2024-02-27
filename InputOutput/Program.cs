using System.Globalization;

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            Console.Write("Output");
            Console.WriteLine(":");
            Console.WriteLine("=======================");

            Output.PrintFormattedData();
            Console.WriteLine("=======================");

            Output.PrintConcatenatedString();
            Console.WriteLine("=======================");

            Output.PrintConvertedValues();
            Console.WriteLine("=======================");

            Console.Write("Input");
            Console.WriteLine(":");
            Console.WriteLine("=======================");

            Input.ReadBasicInputData();
            Console.WriteLine("=======================");

            Input.ReadFullName();
            Console.WriteLine("=======================");

            Input.ReadAndCastData();
            Console.WriteLine("=======================");
        }
    }
}

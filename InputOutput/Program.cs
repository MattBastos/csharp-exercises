using System.Globalization;

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            Console.Write("InputOutput");
            Console.WriteLine(":");
            Console.WriteLine("=======================");

            Output.PrintFormattedData();
            Console.WriteLine("=======================");

            Output.PrintConcatenatedString();
            Console.WriteLine("=======================");
        }
    }
}

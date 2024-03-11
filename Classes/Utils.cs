using System.Globalization;

namespace Classes
{
    class Utils
    {
        public static double ReadDoubleFromConsole()
    {
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            
            string? input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double result))
            {
                return Math.Round(result, 2);
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    }
}
// Every data typed by the user is a string

namespace InputOutput
{
    class Input
    {
        public static void ReadBasicInputData()
        {
            Console.WriteLine("What's your name?");

            string? name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}!");
        }

        public static void ReadFullName()
        {
            Console.WriteLine("What's your full name?");

            string? fullName = Console.ReadLine();

            if (fullName != null)
            {
                string[] names = fullName.Split(' ');

                if (names.Length >= 2)
                {
                    string firstName = names[0];
                    string lastName = names[1];
                    
                    Console.WriteLine($"Your full name is {firstName} {lastName}!");
                }
                else
                {
                    Console.WriteLine("Please enter both first and last names.");
                }
            }
        }

        public static void ReadAndCastData()
        {
            Console.WriteLine("What's your favorite number?");

            string? favoriteNumber = Console.ReadLine();

            if (favoriteNumber != null)
            {
                if (int.TryParse(favoriteNumber, out int result))
                {
                    Console.WriteLine($"Your favorite was converted to type int: {favoriteNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}

using System.Globalization;

namespace InputOutput
{
    class Output
    {
        public static void PrintFormattedData()
        {
            Console.WriteLine("Formatted Data:");
            double balance = 10.3578;

            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void PrintConcatenatedString()
        {
            string name = "Tracer";
            int age = 20;
            double balance = 30.35784;

            Console.WriteLine("Placeholders:");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", name, age, balance);
            Console.WriteLine("-----------------------");

            Console.WriteLine("Interpolation:");
            Console.WriteLine($"{name} tem {age} e tem saldo igual a {balance:F2} reais.");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Concatenation:");
            Console.WriteLine(name + " tem " + age + " e tem saldo igual a " + balance.ToString("F2") + " reais.");
        }
    }
}

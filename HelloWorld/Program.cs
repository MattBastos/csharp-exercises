// Create New Project = dotnet new console/web -n NameOfTheProject
// Run Main = dotnet run

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("=======================");

            BasicTypes.PrintBasicNumberType();
            Console.WriteLine("=======================");

            BasicTypes.PrintBasicBooleanType();
            Console.WriteLine("=======================");

            BasicTypes.PrintBasicStringType();
            Console.WriteLine("=======================");

            BasicTypes.PrintBasicObjectType();
        }
    }
}

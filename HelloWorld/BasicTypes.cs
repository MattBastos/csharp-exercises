namespace HelloWorld
{
    class BasicTypes
    {
        public static void PrintBasicNumberType()
        {
            Console.WriteLine("Int Numbers:");

            byte firstByte = 126;
            int firstInt = 1000;
            long firstLong = 2147483648L; // float variables must have an L

            Console.WriteLine(firstByte);
            Console.WriteLine(firstInt);
            Console.WriteLine(firstLong);

            Console.WriteLine("-----------------------");

            Console.WriteLine("Float Numbers:");

            float firstFloat = 4.5f; // float variables must have an f
            double firstDouble = 5.5;

            Console.WriteLine(firstFloat);
            Console.WriteLine(firstDouble);
        }

        public static void PrintBasicBooleanType()
        {
            Console.WriteLine("Boolean:");
            bool isComplete = true;
            Console.WriteLine(isComplete);
        }

        public static void PrintBasicStringType()
        {
            Console.WriteLine("String:");
            char gender = 'M'; // char variables must use single quote
            char uniCode = '\u0041';
            string name = "Hanzo"; // strings types are immutable

            Console.WriteLine(gender);
            Console.WriteLine(uniCode);
            Console.WriteLine(name);
        }

        public static void PrintBasicObjectType()
        {
            Console.WriteLine("Object:"); // objects are generics, it can receive any type of value
            object firstObject = "Genji";
            object secondObject = 10;

            Console.WriteLine(firstObject);
            Console.WriteLine(secondObject);
        }
    }
}

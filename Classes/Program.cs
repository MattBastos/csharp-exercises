namespace Classes
{
    class Program()
    {
        static void Main()
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("What are the measurements of the triangle x?");
            x.aSide = Utils.ReadDoubleFromConsole();
            x.bSide = Utils.ReadDoubleFromConsole();
            x.cSide = Utils.ReadDoubleFromConsole();

            Console.WriteLine("What are the measurements of the triangle y?");
            y.aSide = Utils.ReadDoubleFromConsole();
            y.bSide = Utils.ReadDoubleFromConsole();
            y.cSide = Utils.ReadDoubleFromConsole();

            double xArea = x.CalculateTriangleArea();
            double yArea = y.CalculateTriangleArea();

            Console.WriteLine($"X Area = {xArea:F4}");
            Console.WriteLine($"Y Area = {yArea:F4}");

            if (xArea > yArea)
            {
                Console.WriteLine("Greatest area: X");
            }
            else
            {
                Console.WriteLine("Greatest area: Y");
            }
        }
    }
}

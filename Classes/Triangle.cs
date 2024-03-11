namespace Classes
{
    class Triangle
    {
        public double aSide;
        public double bSide;
        public double cSide;

        public double CalculateTriangleArea()
        {
            double perimeter = (aSide + bSide + cSide) / 2.0;
            return Math.Sqrt(perimeter * (perimeter - aSide) * (perimeter - bSide) * (perimeter - cSide));
        }
    }
}

namespace FindArea
{
    public static class Triangle
    {
        public static double ThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2; //perimeter

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool RightAngledTriangle(double a, double b, double c)
        {
            if(a > 0 && b > 0 && c > 0)
            {
                return (a * a + b * b + c * c) - Math.Pow(Math.Max(Math.Max(a, b), c), 2) == Math.Pow(Math.Max(Math.Max(a, b), c), 2);
            }

            return false;
        }
    }
}

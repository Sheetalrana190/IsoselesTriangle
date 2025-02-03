namespace IsoselesTriangle
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string result;
            if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                result = "The triangl is Isosceles Triangle.";
            }
            else
            {
                result = "The triangle is NOT Isosceles Triangle.";
            }
            return result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 7;
            string result = Triangle.ValidTriangle(firstSide, secondSide, thirdSide);
            Console.WriteLine(result);
        }
    }


}

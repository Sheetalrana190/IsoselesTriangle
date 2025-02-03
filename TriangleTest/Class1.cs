using NUnit.Framework;
using NUnit.Framework.Legacy;
using IsoselesTriangle;
namespace TriangleTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ValidTriangle_Input5and5and7_ReturnsValidTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 7;
            string expected = "The triangl is Isosceles Triangle.";

            // Act
            string actual = Triangle.ValidTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input5and6and7_ReturnsNotValidTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 7;
            string expected = "The triangl is Isosceles Triangle.";

            // Act
            string actual = Triangle.ValidTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}

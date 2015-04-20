using BreakingLiskovSubtitutionPrinciple;
using NUnit.Framework;

namespace TestBreakingLSP
{
    [TestFixture]
    public class TestShapes
    {
        [Test]
        public void ShouldCalculateAreaOfRectangle()
        {
            var rectangle = new Rectangle {Height = 5, Width = 4};

            Assert.That(rectangle.Area(), Is.EqualTo(20));
        }
        
        [Test]
        public void ShouldCalculateAreaOfSquare()
        {
            Rectangle rectangle = new Square {Height = 5, Width = 4};

            Assert.That(rectangle.Area(), Is.EqualTo(20));
        }
    }
}

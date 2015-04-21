using System.Collections.Generic;
using NUnit.Framework;

namespace Implementing_LSP
{
    public class TestLSP
    {
        [Test]
        public void ShouldCalculateTotalAreaOfAllShapes()
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Rectangle(4, 5));
            shapes.Add(new Triangle(3, 3));
            shapes.Add(new Square(4));
            shapes.Add(new Circle(6));

//          Notice that is we add more and more types of shape the code to 
//          calculate total area doesn’t need to change (so it's also Open to Extension & Closed to Modification!)

            decimal totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea = totalArea + shape.Area();
            }

            Assert.That(System.Math.Round(totalArea, 2), Is.EqualTo(153.10m));
        }

    }
}
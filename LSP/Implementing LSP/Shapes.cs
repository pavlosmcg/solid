using System;

namespace Implementing_LSP
{
    public interface IShape
    {
        decimal Area();
    }

    public class Rectangle : IShape
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; private set; }
        public int Width { get; private set; }

        public decimal Area()
        {
            return Height*Width;
        }
    }

    public class Square : IShape
    {
        private Rectangle _rectangle;

        public Square(int height)
        {
            _rectangle = new Rectangle(height, height);
        }

        public decimal Area()
        {
            return _rectangle.Area();
        }
    }

    public class Triangle : IShape
    {
        public Triangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; private set; }
        public int Width { get; private set; }

        public decimal Area()
        {
            return (Height*Width)/2;
        }
    }

    public class Circle : IShape
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public decimal Area()
        {
            return (decimal) Math.PI*Radius*Radius;
        }
    }
#region 
//    Rather than putting IF statements or switches all over your codebase, a better solution is to define a 
//    contract for interacting with our shapes (IShape) which defines a blue-print for all shapes to adhere to.
//
//    Now we can interact with all shapes in the same way (Polymorphically), by working with the 
//    Interface instead of the specific implementations of a shape.
#endregion
}
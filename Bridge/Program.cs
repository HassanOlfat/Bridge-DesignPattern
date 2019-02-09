using System;
using Bridge.Color;
using Bridge.Shape;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IColor blue = new Blue();
            IColor red = new Red();
            var blueCircle = new Circle(blue);
            blueCircle.ApplyColor();
            blueCircle.Draw();

            var redSquare = new Square(red);
            redSquare.ApplyColor();
            redSquare.Draw();
            Console.ReadKey();
        }
    }
}

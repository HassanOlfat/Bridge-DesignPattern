using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Color;

namespace Bridge.Shape
{
   public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override void ApplyColor()
        {
            GetColor().ApplyColor();
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle :"+ GetColor());
        }
    }
}

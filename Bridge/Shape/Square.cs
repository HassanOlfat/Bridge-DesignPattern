using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Color;

namespace Bridge.Shape
{
    class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override void ApplyColor()
        {
            GetColor().ApplyColor();
        }

        public override void Draw()
        {
           Console.WriteLine("Draw Square");
        }
    }
}

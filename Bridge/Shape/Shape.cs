using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Color;

namespace Bridge.Shape
{
   public abstract class  Shape
   {
       private readonly IColor _color;
        protected Shape(IColor color)
        {
            this._color = color;
        }

       public IColor GetColor()
       {
           return _color;

       }
       

        public abstract void ApplyColor();
        public abstract void Draw();

    }
}

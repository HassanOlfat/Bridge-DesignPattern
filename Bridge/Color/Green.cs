using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Color
{
    class Green : IColor
    {
        public void ApplyColor()
        {
          Console.WriteLine("Set Green");
        }
    }
}

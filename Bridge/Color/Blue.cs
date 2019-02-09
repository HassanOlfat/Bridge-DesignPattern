using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Color
{
    class Blue : IColor
    {
        public void ApplyColor()
        {
           Console.WriteLine("Set Blue");
        }
    }
}

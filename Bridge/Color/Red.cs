using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Color
{
    class Red : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Set Red");
        }
    }
}

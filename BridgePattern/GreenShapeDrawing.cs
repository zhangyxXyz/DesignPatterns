﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo_桥接模式_
{
    class GreenShapeDrawing : IDrawing
    {
        public void DrawShape()
        {
            Console.WriteLine("this shape's color is Green.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo_桥接模式_
{
    class Rectangle : Shape
    {
        public Rectangle(IDrawing drawing) : base(drawing)
        {
        }

        public override void Draw()
        {
            Console.Write("Draw a Rectangle,");
            drawing.DrawShape();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo_桥接模式_
{
    class Circle : Shape
    {
        public Circle(IDrawing drawing) : base(drawing)
        {
        }
        public override void Draw()
        {
            Console.Write("Draw a Circle,");
            drawing.DrawShape();
        }
    }
}

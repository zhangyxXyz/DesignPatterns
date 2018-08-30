using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo_桥接模式_
{
    class Client
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(new RedShapeDrawing());
            redCircle.Draw();
            Shape greenCicle = new Circle(new GreenShapeDrawing());
            greenCicle.Draw();
            Shape redRectangle = new Rectangle(new RedShapeDrawing());
            redRectangle.Draw();
            Shape greenRectangle = new Rectangle(new GreenShapeDrawing());
            greenRectangle.Draw();
        }
    }
}

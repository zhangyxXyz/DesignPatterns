using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo_桥接模式_
{
    abstract class Shape
    {
        protected IDrawing drawing;
        public Shape(IDrawing drawing)
        {
            this.drawing = drawing;
        }
        public abstract void Draw();
    }
}

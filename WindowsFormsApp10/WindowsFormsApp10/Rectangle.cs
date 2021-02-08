using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Rectangle : Decorator
    {
        //draw
        public Rectangle(IDraw draw) : base(draw) { }
        public override void DrawFigure()
        {
            draw.DrawFigure();
            Graphics holst = draw.GetGraphics();
            holst.FillRectangle(new SolidBrush(Color.Red), 70, 70, 70, 70);
        }
    }
}

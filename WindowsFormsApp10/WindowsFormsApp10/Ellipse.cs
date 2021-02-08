using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Ellipse:Decorator
    {
        public Ellipse(IDraw draw) : base(draw) { }
        public override void DrawFigure()
        {
            draw.DrawFigure();
            Graphics holst = draw.GetGraphics();
            holst.FillEllipse(new SolidBrush(Color.Yellow), 80, 80, 70, 70);
        }
    }
}

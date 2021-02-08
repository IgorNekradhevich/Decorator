using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Facade
    {
        IDraw draw;
        Rectangle rectangle;
        Ellipse ellipse;
        Text text;
        public Facade ( Graphics graphics)
        {
            draw = new Draw();
            draw.SetGraphics(graphics);
        }
        public void  DrawAll(string text)
        {
            draw = new Rectangle(draw);
            draw = new Ellipse(draw);
            draw = new Text(text, draw);
            draw.DrawFigure();
        }
    }
}

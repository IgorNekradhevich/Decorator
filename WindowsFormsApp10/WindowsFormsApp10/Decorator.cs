using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    abstract class Decorator : IDraw
    {

     protected   IDraw draw;
        public Decorator(IDraw draw)
        {
            this.draw = draw;
        }
       public  Graphics GetGraphics()
        {
            return draw.GetGraphics();
        }
        abstract public void DrawFigure();

        public void SetGraphics(Graphics graphics)
        {//x=x
            draw.SetGraphics(draw.GetGraphics());
        }
    }
}

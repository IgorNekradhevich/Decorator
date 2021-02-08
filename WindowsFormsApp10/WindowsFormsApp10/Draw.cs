using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Draw: IDraw
    {
      Graphics graphics;
        public void SetGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void DrawFigure()
        {
          //  graphics.FillRectangle(new SolidBrush(Color.Red), 10, 10, 10, 10);
        }

        public Graphics GetGraphics()
        {
            return graphics;
        }
    }
}

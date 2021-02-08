using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    interface IDraw
    {
        void DrawFigure();
        Graphics GetGraphics();
        void SetGraphics(Graphics graphics);
    }
}

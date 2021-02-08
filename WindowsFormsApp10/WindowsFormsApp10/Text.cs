using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Text:Decorator
    {
        string text;
        public Text(string text, IDraw draw): base (draw)
        {
            this.text = text;
        }

        public override void DrawFigure()
        {
            draw.DrawFigure();
            Font font = new Font("Arial", 20);
            Graphics graphics = draw.GetGraphics();
            graphics.DrawString(text, font, new SolidBrush(Color.Green), 100, 100);
        }
    }
}

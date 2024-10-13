using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    class Ellipse
    {
        Point Begin, End;
        public void Draw(Graphics graphics, Pen p, Point startPoint, int width, int height)
        {
            Begin.X = startPoint.X;
            Begin.Y = startPoint.Y;
            End.X = startPoint.X + width;
            End.Y = startPoint.Y + height;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawEllipse(p, startPoint.X, startPoint.Y, width, height);
        }
    }
}

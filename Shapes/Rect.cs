using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    class Rect
    {
        Point Begin, End;
        
        public void Draw(Graphics graphics, Pen p, Point startPoint, int width, int height)
        {
            Begin.X = startPoint.X;
            Begin.Y = startPoint.Y;
            End.X = startPoint.X + width;
            End.X = startPoint.Y + height;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawRectangle(p, startPoint.X, startPoint.Y, width, height);
        }
    }
}

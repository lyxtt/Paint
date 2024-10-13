using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    internal class Polygon
    {
        Point Begin, End, a, b, c;
        
        public void Draw(Graphics graphics, Pen p, Point startPoint, int width, int height)
        {
            Begin.X = startPoint.X;
            Begin.Y = startPoint.Y;
            End.X = startPoint.X + width;
            End.Y = startPoint.Y + height;
            a.X = startPoint.X + width / 2;
            a.Y = Begin.Y;
            b.X = Begin.X;
            b.Y = End.Y;
            c.X = End.X;
            c.Y = End.Y;
            PointF[] Points =
            {
              a,b,c
            };
            graphics.DrawPolygon(p, Points);
        }
    }
}

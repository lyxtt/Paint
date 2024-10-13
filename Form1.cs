using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        Point start;
        string tool;
        bool paint = false;
        int x, y, w, h;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Stack<Bitmap> UndoStack, RedoStack;
        public Form1()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 1000;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            UndoStack = new Stack<Bitmap>();
            RedoStack = new Stack<Bitmap>();
            pic_color.BackColor = Color.Black;
            new_color = Color.Black;
        }


        private void btn_pencil_Click(object sender, EventArgs e)
        {
            tool = "pencil";
        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            tool = "eraser";
        }

        private void btn_AddText_Click(object sender, EventArgs e)
        {
            tool = "add text";
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            tool = "ellipse";
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            tool = "rect";
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            tool = "polygon";
        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            tool = "line";
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            tool = "fill";
        }

        private void btn_Zoomout_Click(object sender, EventArgs e)
        {
            if (trB_zoom.Value > 1)
                trB_zoom.Value -= 1;
        }

        private void btn_Zoomin_Click(object sender, EventArgs e)
        {
            if (trB_zoom.Value < 10)
                trB_zoom.Value += 1;
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bm.Clone());
                bm = UndoStack.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {
                UndoStack.Push((Bitmap)bm.Clone());
                bm = RedoStack.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btn_save_Click(sender, e);
            }
            g.Clear(Color.White);
            pic.Image = bm;
            tool = "";
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JPeg Image|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved Successfully...");
            }
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (.bmp;.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bm = (Bitmap)Image.FromFile(ofd.FileName);
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }
        private void pic_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = new_color;
            p.Color = new_color;
        }
        private void lineWidth_Scroll(object sender, EventArgs e)
        {
            p.Width = lineWidth.Value;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        public void zoom()
        {
            UndoStack.Push((Bitmap)bm.Clone());
            RedoStack.Clear();
            bm = new Bitmap(bm,
                width: Convert.ToInt32(pic.Width * (float)trB_zoom.Value / 10),
                height: Convert.ToInt32(pic.Height * (float)trB_zoom.Value / 10));
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = Graphics.FromImage(bm);
            pic.Image = bm;
        }
        private void trB_zoom_Scroll(object sender, EventArgs e)
        {
            zoom();

        }

        private void trB_zoom_ValueChanged(object sender, EventArgs e)
        {
            zoom();
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(tool == "fill")
            {
                //UndoStack.Push((Bitmap)bm.Clone());
                //RedoStack.Clear();
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
            if (tool == "add text")
            {
                FrmAddText textForm = new FrmAddText();
                textForm.StartPosition = FormStartPosition.CenterParent;
                if (textForm.ShowDialog() == DialogResult.OK)
                {
                    UndoStack.Push((Bitmap)bm.Clone());
                    RedoStack.Clear();
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    Font textFont = new Font(Font.FontFamily, 30, Font.Style);

                    g.DrawString(textForm.ReturnValue, textFont, new SolidBrush(pic_color.BackColor), e.Location);
                    pic.Invalidate();
                }
                textForm.Dispose();
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            start.X = e.X;
            start.Y = e.Y;
            if (tool == "pencil" || tool == "eraser")
            {
                UndoStack.Push((Bitmap)bm.Clone());
                RedoStack.Clear();
            }

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (tool == "pencil")
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(p, start, e.Location);
                    start.X = e.X;
                    start.Y = e.Y;
                } else if(tool == "eraser")
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(erase, start, e.Location);
                    start.X = e.X;
                    start.Y = e.Y;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            w = e.X - start.X;
            h = e.Y - start.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            
            if (tool == "ellipse")
            {
                UndoStack.Push((Bitmap)bm.Clone());
                RedoStack.Clear();
                Ellipse shape = new Ellipse();
                shape.Draw(g, p, start, w, h);
            }
            else if (tool == "rect")
            {
                UndoStack.Push((Bitmap)bm.Clone());
                RedoStack.Clear();
                Rect shape = new Rect();
                shape.Draw(g, p, start, w, h);
            }
            else if (tool == "polygon")
            {
                UndoStack.Push((Bitmap)bm.Clone());
                RedoStack.Clear();
                Polygon shape = new Polygon();
                shape.Draw(g, p, start, w, h);
            } else if(tool == "line")
            {
                UndoStack.Push((Bitmap)bm.Clone());
                RedoStack.Clear();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(p, start.X, start.Y, e.X, e.Y);
            }
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                if (tool == "ellipse")
                {
                    Ellipse shape = new Ellipse();
                    shape.Draw(graphics, p, start, w, h);
                }
                if (tool == "rect")
                {
                    Rect shape = new Rect();
                    shape.Draw(graphics, p, start, w, h);
                }
                if (tool == "polygon")
                {
                    Polygon shape = new Polygon();
                    shape.Draw(graphics, p, start, w, h);
                }
                if (tool == "line")
                {
                    graphics.DrawLine(p, start.X, start.Y, x, y);
                }
            }
        }
    }
}

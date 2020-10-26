using System.Drawing;
using System.Windows.Forms;

namespace lesson5
{
    public static class Draw
    {

        public static void drawCircle(PictureBox box, int lineWidth, string lineColor, string filling)
        {

            int width = box.Width - 20;
            int height = box.Height - 20;

            Graphics g = box.CreateGraphics();
            g.Clear(Color.Bisque);
            Pen pen = new Pen(Color.FromName(lineColor), lineWidth);
            SolidBrush brush = new SolidBrush(Color.FromName(filling));
             
            g.DrawEllipse(pen, 10, 10, width, height);
            g.FillEllipse(brush, 10, 10, width, height);
            
        }
        
        public static void DrawQuadrate(PictureBox box, int lineWidth, string lineColor, string filling)
        {

            int width = box.Size.Width - 20;
            int height = box.Size.Height - 20;

            Graphics g = box.CreateGraphics();
            g.Clear(Color.Bisque);
            Pen pen = new Pen(Color.FromName(lineColor), lineWidth);
            SolidBrush brush = new SolidBrush(Color.FromName(filling));
             
            g.DrawRectangle(pen, 10, 10, width, height);
            g.FillRectangle(brush, 10, 10, width, height);
            
        }
        
        public static void DrawTriangle(PictureBox box, int lineWidth, string lineColor, string filling)
        {

            int width = box.Size.Width;
            int height = box.Size.Height;

            Graphics g = box.CreateGraphics();
            g.Clear(Color.Bisque);
            Pen pen = new Pen(Color.FromName(lineColor), lineWidth);
            SolidBrush brush = new SolidBrush(Color.FromName(filling));
             
            PointF firstPoint = new PointF(10, height - 10);
            PointF secondPoint = new PointF(width/2, 10);
            PointF thirdPoint = new PointF(width - 10, height - 10);

            PointF[] points = {firstPoint, secondPoint, thirdPoint};
            
            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
            
        }
        
    }
}
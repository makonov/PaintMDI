using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.DrawingModes
{
    public class LineDrawingMode : IDrawingMode
    {

        private Point startPoint;
        private Point endPoint;

        public void StartDrawing(MouseEventArgs e)
        {
            startPoint = e.Location;
            endPoint = e.Location;
        }

        public void ContinueDrawing(Graphics graphics, MouseEventArgs e)
        {
            graphics.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), startPoint, e.Location);
            endPoint = e.Location;
        }

        public void EndDrawing(MouseEventArgs e, Bitmap bitmap, List<Point> points)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), startPoint, endPoint);
            }
        }

    }
}

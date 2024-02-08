using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.DrawingModes
{
    public interface IDrawingMode
    {
        void StartDrawing(MouseEventArgs e);
        void ContinueDrawing(Graphics graphics, MouseEventArgs e);
        void EndDrawing(MouseEventArgs e, Bitmap bitmap, List<Point> points);
    }
}

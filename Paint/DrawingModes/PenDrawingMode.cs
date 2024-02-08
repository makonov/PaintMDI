using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.DrawingModes
{
    public class PenDrawingMode : IDrawingMode
    {
        private Point startPoint;

        public void StartDrawing(MouseEventArgs e)
        {
            // Сохраняем начальные координаты для пера
            startPoint = e.Location;
        }

        public void ContinueDrawing(Graphics graphics, MouseEventArgs e)
        {
            // Продолжение рисования для пера
            graphics.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), startPoint, e.Location);

            // Обновляем начальные координаты после рисования линии
            startPoint = e.Location;
        }

        public void EndDrawing(MouseEventArgs e, Bitmap bitmap, List<Point> points)
        {
            // Завершение рисования для пера
        }
    }

}

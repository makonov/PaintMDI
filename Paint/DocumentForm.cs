using Paint.DrawingModes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class DocumentForm : Form
    {
        private int x, y;
        private int figureStartX, figureStartY;
        public Bitmap Bitmap { get; private set; }
        public string Path { get; set; }
        public bool HasUnsavedChanges { get; set; }
        public MainForm ParentForm { get; set; }
        public int OriginalWidth {  get; set; }
        public int OriginalHeight { get; set; }
        private float zoomFactor = 1.0f;

        public DocumentForm()
        {
            InitializeComponent();
            Width = 300;
            Height = 200;
            OriginalWidth = Width; OriginalHeight = Height;
            Bitmap = new Bitmap(300, 200);
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.Clear(Color.White);
            }
            HasUnsavedChanges = false;
            Text = $"Документ {MainForm.NewDocumentCount}";
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void SetZoom(float factor)
        {
            if (factor > 0)
            {
                zoomFactor = factor;
                SetCanvasSize((int)(OriginalWidth * zoomFactor), (int)(OriginalHeight * zoomFactor));
            }
        }

        public void ResetZoom()
        {
            zoomFactor = 1.0f;
            SetCanvasSize(OriginalWidth, OriginalHeight);
        }


        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            if (MainForm.DrawingMode == DrawingMode.Ellipse || MainForm.DrawingMode == DrawingMode.Star)
            {
                figureStartX = x;
                figureStartY = y;
            }

            HasUnsavedChanges = true;
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (MainForm.DrawingMode)
                {
                    case DrawingMode.Pen:
                        DrawPen(e.X, e.Y);
                        break;

                    case DrawingMode.Line:
                        DrawTemporaryLine(e.X, e.Y);
                        break;

                    case DrawingMode.Ellipse:
                        DrawTemporaryEllipse(e.X, e.Y);
                        break;

                    case DrawingMode.Eraser:
                        Erase(e.X, e.Y);
                        break;
                    case DrawingMode.Star:
                        DrawTemporaryStar(e.X, e.Y);
                        break;
                }
            }
        }

        private void DocumentForm_MouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.DrawingMode)
            {
                case DrawingMode.Line:
                    DrawLine(e.X, e.Y);
                    break;

                case DrawingMode.Ellipse:
                    DrawEllipse(e.X, e.Y);
                    break;

                case DrawingMode.Star:
                    DrawStar(e.X, e.Y);
                    break;
            }
        }

        private void DrawPen(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                Pen pen = new Pen(MainForm.Color, MainForm.PenWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, this.x / zoomFactor, this.y / zoomFactor, x / zoomFactor, y / zoomFactor);
            }
            Invalidate();
            this.x = x;
            this.y = y;
        }

        private void DrawTemporaryLine(int x, int y)
        {
            Refresh();
            using (Graphics g = CreateGraphics())
            {
                g.ScaleTransform(zoomFactor, zoomFactor);
                g.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), this.x / zoomFactor, this.y / zoomFactor, x / zoomFactor, y / zoomFactor);
            }
        }

        private void DrawLine(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.DrawLine(new Pen(MainForm.Color, MainForm.PenWidth), this.x / zoomFactor, this.y / zoomFactor, x / zoomFactor, y / zoomFactor);
            }
            Invalidate();
        }

        private void DrawTemporaryEllipse(int x, int y)
        {
            Refresh();
            using (Graphics g = CreateGraphics())
            {
                int width = (int)((x - figureStartX) / zoomFactor);
                int height = (int)((y - figureStartY) / zoomFactor);
                g.ScaleTransform(zoomFactor, zoomFactor);
                g.DrawEllipse(new Pen(MainForm.Color, MainForm.PenWidth), figureStartX / zoomFactor, figureStartY / zoomFactor, width, height);
            }
        }

        private void DrawEllipse(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                int width = (int)((x - figureStartX) / zoomFactor);
                int height = (int)((y - figureStartY) / zoomFactor);
                g.DrawEllipse(new Pen(MainForm.Color, MainForm.PenWidth), figureStartX / zoomFactor, figureStartY / zoomFactor, width, height);
            }
            Invalidate();
        }

        private void DrawTemporaryStar(int x, int y)
        {
            Refresh();
            using (Graphics g = CreateGraphics())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                double R, r;
                if (x - figureStartX > y - figureStartY)
                    r = (x - figureStartX) / 2;
                else
                    r = (y - figureStartY) / 2;
                R = r / MainForm.StarRadius;

                int n = MainForm.StarVertices;
                double alpha = -Math.PI / 2;
                double x0 = figureStartX + r, y0 = figureStartY + r;

                PointF[] points = new PointF[2 * n + 1];
                double a = alpha, da = Math.PI / n, l;
                for (int k = 0; k < 2 * n + 1; k++)
                {
                    l = k % 2 == 0 ? r : R;
                    points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                    a += da;
                }

                float scaledPenWidth = MainForm.PenWidth * zoomFactor;
                using (Pen pen = new Pen(MainForm.Color, scaledPenWidth))
                {
                    g.DrawLines(pen, points);
                }
            }
        }

        private void DrawStar(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                double R, r;
                if (x - figureStartX > y - figureStartY)
                    r = (x - figureStartX) / 2;
                else
                    r = (y - figureStartY) / 2;
                R = r / MainForm.StarRadius;

                int n = MainForm.StarVertices;
                double alpha = -Math.PI / 2;
                double x0 = figureStartX + r, y0 = figureStartY + r;

                PointF[] points = new PointF[2 * n + 1];
                double a = alpha, da = Math.PI / n, l;
                for (int k = 0; k < 2 * n + 1; k++)
                {
                    l = k % 2 == 0 ? r : R;
                    points[k] = new PointF((float)((x0 + l * Math.Cos(a)) / zoomFactor), (float)((y0 + l * Math.Sin(a)) / zoomFactor));
                    a += da;
                }

                using (Pen pen = new Pen(MainForm.Color, MainForm.PenWidth))
                {
                    g.DrawLines(pen, points);
                }
            }

            Invalidate();
        }


        private void Erase(int x, int y)
        {
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                EraseRegion(g, x, y);
            }
            Invalidate();
        }

        private void EraseRegion(Graphics g, int x, int y)
        {
            int eraserSize = (int)(MainForm.PenWidth * zoomFactor);

            int eraserX = (int)((x - eraserSize / 2) / zoomFactor);
            int eraserY = (int)((y - eraserSize / 2) / zoomFactor);
            int scaledEraserSize = (int)(eraserSize / zoomFactor);
            Rectangle eraserRect = new Rectangle(eraserX, eraserY, scaledEraserSize, scaledEraserSize);

            g.SetClip(eraserRect);
            g.Clear(Color.White);
            g.ResetClip();
        }

        public void ZoomIn()
        {
            SetZoom(zoomFactor * 1.1f);
        }

        public void ZoomOut()
        {
            SetZoom(zoomFactor / 1.1f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.ScaleTransform(zoomFactor, zoomFactor);
            e.Graphics.DrawImage(Bitmap, 0, 0);
        }

        public void SetCanvasSize(int width, int height)
        {
            Bitmap previousBitmap = Bitmap;
            Bitmap = new Bitmap(OriginalWidth, OriginalHeight);
            Width = width; Height = height;
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.Clear(Color.White);
                if (previousBitmap != null)
                {
                    g.DrawImage(previousBitmap, Point.Empty);
                }
            }
            Invalidate();
            HasUnsavedChanges = true;
        }


        public void LoadImage(string imagePath)
        {
            try
            {
                using (Bitmap newBitmap = new Bitmap(imagePath))
                {
                    Bitmap = new Bitmap(newBitmap);
                }

                SetCanvasSize(Bitmap.Width, Bitmap.Height);
                HasUnsavedChanges = false;
                Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DocumentForm_SizeChanged(object sender, EventArgs e)
        {
            //SetCanvasSize(Width, Height);
        }

        private void DocumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверяем, нужно ли сохранять изменения
            if (ParentForm is not null && HasUnsavedChanges)
            {
                bool saveAs = Path == null ? true : false;
                DialogResult result = saveAs == true ?
                    MessageBox.Show($"Сохранить {Text} перед закрытием?", "Внимание", MessageBoxButtons.YesNoCancel) :
                    MessageBox.Show($"Сохранить изменения файла {Text} перед закрытием?", "Внимание", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Вызываем метод сохранения из MainForm
                    if (!ParentForm.SaveDocument(this, saveAs))
                    {
                        e.Cancel = true;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // Отменяем закрытие формы
                    e.Cancel = true;
                }
            }
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {

        }
    }

}

using PluginInterface;
using System.Drawing;

namespace ImageSplittingLibrary
{
    [Version(1, 0)]
    public class ImageSplitting : IPlugin
    {
        public string Name => "Разбиение изображения";

        public string Author => "Чуприянов Макар";

        public void Transform(Bitmap bitmap)
        {
            int partWidth = bitmap.Width / 3;
            int partHeight = bitmap.Height / 3;

            List<Bitmap> parts = new List<Bitmap>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Rectangle sourceRectangle = new Rectangle(j * partWidth, i * partHeight, partWidth, partHeight);
                    Bitmap part = new Bitmap(partWidth, partHeight);
                    using (Graphics g = Graphics.FromImage(part))
                    {
                        g.DrawImage(bitmap, 0, 0, sourceRectangle, GraphicsUnit.Pixel);
                    }
                    parts.Add(part);
                }
            }

            Random rand = new Random();
            for (int i = parts.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Bitmap temp = parts[i];
                parts[i] = parts[j];
                parts[j] = temp;
            }

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        g.DrawImage(parts[i * 3 + j], j * partWidth, i * partHeight);
                    }
                }
            }
        }
    }
}

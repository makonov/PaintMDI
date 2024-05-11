using PluginInterface;
using System.Drawing;

namespace ContrastEnhancementLibrary
{
    [Version(1, 0)]
    public class ContrastEnhancement : IPlugin
    {
        public string Name => "Увеличение контраста";

        public string Author => "Чуприянов Макар";

        public void Transform(Bitmap bitmap)
        {
            int[] histogram = GetHistogram(bitmap);

            int minBrightness = 0;

            for (int i = 0; i < 256; i++)
            {
                if (histogram[i] > 0)
                {
                    minBrightness = i;
                    break;
                }
            }

            double a = 2.0;
            double с = -a * minBrightness;

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    int r = (int)(a * pixelColor.R + с);
                    int g = (int)(a * pixelColor.G + с);
                    int b = (int)(a * pixelColor.B + с);

                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
        }

        private int[] GetHistogram(Bitmap bitmap)
        {
            int[] histogram = new int[256];

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int brightness = (int)(pixelColor.GetBrightness() * 255);
                    histogram[brightness]++;
                }
            }

            return histogram;
        }
    }
}


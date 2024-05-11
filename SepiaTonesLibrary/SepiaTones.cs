using PluginInterface;
using System.Drawing;

namespace SepiaTonesLibrary
{
    [Version(1, 0)]
    public class SepiaTones : IPlugin
    {
        public string Name => "Оттенки сепии";

        public string Author => "Чуприянов Макар";

        public void Transform(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);

                        int r = (int)(pixelColor.R * 0.393 + pixelColor.G * 0.769 + pixelColor.B * 0.189);
                        int g = (int)(pixelColor.R * 0.349 + pixelColor.G * 0.686 + pixelColor.B * 0.168);
                        int b = (int)(pixelColor.R * 0.272 + pixelColor.G * 0.534 + pixelColor.B * 0.131);

                        r = Math.Min(255, Math.Max(0, r));
                        g = Math.Min(255, Math.Max(0, g));
                        b = Math.Min(255, Math.Max(0, b));

                        bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
            }   
        }
    }
}

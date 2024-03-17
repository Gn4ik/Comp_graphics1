using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.MatrixFilters
{
    internal class EmbossingFilter : Filters
    {
        public EmbossingFilter() { }

        protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
        {
            float[,] kernel = new float[,] { { 0, 1, 0 }, { 1, 0, -1 }, { 0, -1, 0 } };

            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resR = 0;
            float resG = 0;
            float resB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, image.Width - 1);
                    int idY = Clamp(y + l, 0, image.Height - 1);
                    Color neighbourColor = image.GetPixel(idX, idY);
                    resR += neighbourColor.R * kernel[k + radiusX, l + radiusY];
                    resG += neighbourColor.G * kernel[k + radiusX, l + radiusY];
                    resB += neighbourColor.B * kernel[k + radiusX, l + radiusY];
                }
            }

            resR = Clamp((int)resR + 255, 0, 510) / 2;
            resG = Clamp((int)resG + 255, 0, 510) / 2;
            resB = Clamp((int)resB + 255, 0, 510) / 2;

            return Color.FromArgb((int)resR, (int)resG, (int)resB);
        }
    }
}

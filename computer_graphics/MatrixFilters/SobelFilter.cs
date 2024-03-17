using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.MatrixFilters
{
    internal class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {
        }
        public Bitmap calculateNewBitmap(Bitmap image)
        {
            var bmp = new Bitmap(image);

            byte[,] pixels = new byte[bmp.Width, bmp.Height];
            byte[,] sobeled = new byte[bmp.Width, bmp.Height];

            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                for (int j = 0; j < pixels.GetLength(1); j++)
                {
                    pixels[i, j] = bmp.GetPixel(i, j).G;
                }
            }

            float[,] gx = new float[bmp.Width, bmp.Height];
            float[,] gy = new float[bmp.Width, bmp.Height];

            for (int i = 1; i < pixels.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < pixels.GetLength(1) - 1; j++)
                {
                    gx[i, j] = pixels[i - 1, j + 1] + 2 * pixels[i, j + 1] + pixels[i + 1, j + 1] - (
                                pixels[i - 1, j - 1] + 2 * pixels[i, j - 1] + pixels[i + 1, j - 1]);
                    gy[i, j] = pixels[i + 1, j - 1] + 2 * pixels[i + 1, j] + pixels[i + 1, j + 1] - (
                               pixels[i - 1, j - 1] + 2 * pixels[i - 1, j] + pixels[i - 1, j + 1]);

                    float sobeled_pixel = MathF.Sqrt(gx[i, j] * gx[i, j] + gy[i, j] * gy[i, j]);
                    sobeled_pixel = sobeled_pixel > 255 ? 255 : sobeled_pixel;

                    byte byte_pixel = Convert.ToByte(sobeled_pixel);
                    sobeled[i, j] = byte_pixel;
                }
            }
            Bitmap bitmapSobeled = new Bitmap(image);
            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                for (int j = 0; j < pixels.GetLength(1); j++)
                {
                    Color color = Color.FromArgb(sobeled[i, j], sobeled[i, j], sobeled[i, j]);
                    bitmapSobeled.SetPixel(i, j, color);
                }
            }
            return bitmapSobeled;
        }
    }
}

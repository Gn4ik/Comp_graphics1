using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
    internal class Rotate
    {
        internal Bitmap RotateFilter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            double angle = 45;
            double centerX = image.Width / 2;
            double centerY = image.Height / 2;
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Вычисление новых координат
                    double newX = (x - centerX) * Math.Cos(angle) - (y - centerY) * Math.Sin(angle) + centerX;
                    double newY = (x - centerX) * Math.Sin(angle) + (y - centerY) * Math.Cos(angle) + centerY;

                    if (newX >= 0 && newX < image.Width && newY >= 0 && newY < image.Height)
                    {
                        resultImage.SetPixel((int)newX, (int)newY, image.GetPixel(x, y));
                    }
                }
            }
            return resultImage;
        }
    }
}

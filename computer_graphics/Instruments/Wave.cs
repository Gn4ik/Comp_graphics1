using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
    internal class Wave
    {
        internal Bitmap Wave1Filter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    double newX = x + 20 * Math.Sin(2 * Math.PI * y / 100);
                    if (newX >= 0 && newX < image.Width)
                    {
                        resultImage.SetPixel((int)newX, y, image.GetPixel(x, y));
                    }
                }
            }
            return resultImage;
        }
        internal Bitmap Wave2Filter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    double newY = y + 20 * Math.Sin(2 * Math.PI * x / 100);
                    if (x >= 0 && x < image.Width && newY >= 0 && newY < image.Height)
                    {
                        resultImage.SetPixel(x, (int)newY, image.GetPixel(x, y));
                    }
                }
            }
            return resultImage;
        }
    }
}

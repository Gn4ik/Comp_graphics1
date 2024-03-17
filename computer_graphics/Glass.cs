using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
    internal class Glass
    {
        internal Bitmap GlassFilter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                Random random = new Random();
                for (int x = 0; x < image.Width; x++)
                {
                    //Random random = new Random();
                    double newX = x + (random.Next(-2, 4)) * 10;
                    double newY = y + (random.Next(-2, 4)) * 10;

                    if (newX >= 0 && newX < image.Width && newY >= 0 && newY < image.Height)
                    {
                        resultImage.SetPixel(x, y, image.GetPixel((int)newX, (int)newY));
                    }
                }
            }
            return resultImage;
        }
    }
}

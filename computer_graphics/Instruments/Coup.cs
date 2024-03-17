using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
    internal class Coup
    {
        internal Bitmap CoupFilter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);

            // Применение фильтра
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int newX = x + 100; // Формула для расчета нового значения x
                    int newY = y; // Новое значение y

                    if (newX < image.Width && newY < image.Height)
                    {
                        resultImage.SetPixel(newX, newY, image.GetPixel(x, y));
                    }
                }
            }
            return resultImage;
        }
    }
}

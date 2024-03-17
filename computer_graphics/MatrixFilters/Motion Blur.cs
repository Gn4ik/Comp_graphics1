using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.MatrixFilters
{
    internal class Motion_Blur
    {
        //public Motion_Blur() {
        //	createKernel(5);
        //}
        //public void createKernel(int size)
        //{
        //	kernel = new float[size, size];
        //	for (int i = 0; i < size; i++)
        //	{
        //		for (int j = 0; j < size; j++)
        //		{
        //			kernel[i,j] = 0.0f;
        //		}
        //	}
        //	for(int i = 0; i < size; i++)
        //	{
        //		kernel[i,i] = 1.0f * (1/size);
        //	}
        //}
        public Bitmap ApplyMotionBlurFilter(Bitmap image, int size)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);

            int radius = size / 2;

            for (int x = radius; x < image.Width - radius; x++)
            {
                for (int y = radius; y < image.Height - radius; y++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    for (int i = -radius; i <= radius; i++)
                    {
                        Color pixel = image.GetPixel(x + i, y);
                        sumR += pixel.R;
                        sumG += pixel.G;
                        sumB += pixel.B;
                    }

                    int avgR = sumR / size;
                    int avgG = sumG / size;
                    int avgB = sumB / size;

                    resultImage.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return resultImage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.MatrixFilters
{
    internal class EdgeDetection
    {
        public Bitmap SharrFilter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);

            int[,] kernelX = new int[,] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
            int[,] kernelY = new int[,] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };

            int width = image.Width;
            int height = image.Height;

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);
                            gradientX += kernelX[i + 1, j + 1] * pixel.R;
                            gradientY += kernelY[i + 1, j + 1] * pixel.R;
                        }
                    }

                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);

                    int grayValue = Math.Min(255, magnitude);
                    Color newPixel = Color.FromArgb(grayValue, grayValue, grayValue);

                    resultImage.SetPixel(x, y, newPixel);
                }
            }

            return resultImage;
        }

        public Bitmap PrewittFilter(Bitmap image)
        {
            Bitmap resultImage = new Bitmap(image.Width, image.Height);

            int[,] kernelX = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] kernelY = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };

            int width = image.Width;
            int height = image.Height;

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);
                            gradientX += kernelX[i + 1, j + 1] * pixel.R;
                            gradientY += kernelY[i + 1, j + 1] * pixel.R;
                        }
                    }

                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);

                    int grayValue = Math.Min(255, magnitude);
                    Color newPixel = Color.FromArgb(grayValue, grayValue, grayValue);

                    resultImage.SetPixel(x, y, newPixel);
                }
            }

            return resultImage;
        }
    }
}

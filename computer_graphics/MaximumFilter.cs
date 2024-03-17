using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
	internal class MaximumFilter : MatrixFilter
	{
		public MaximumFilter()
		{
			createKernel(3); // Задаем размер ядра фильтра, например, 3x3
		}

		protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
		{
			int kernelRadiusX = kernel.GetLength(0) / 2;
			int kernelRadiusY = kernel.GetLength(1) / 2;

			byte maxR = 0;
			byte maxG = 0;
			byte maxB = 0;

			for (int i = -kernelRadiusY; i <= kernelRadiusY; i++)
			{
				for (int j = -kernelRadiusX; j <= kernelRadiusX; j++)
				{
					int ni = Clamp(x + j, 0, sourceImage.Width - 1);
					int nj = Clamp(y + i, 0, sourceImage.Height - 1);

					Color neighborColor = sourceImage.GetPixel(ni, nj);

					maxR = Math.Max(maxR, neighborColor.R);
					maxG = Math.Max(maxG, neighborColor.G);
					maxB = Math.Max(maxB, neighborColor.B);
				}
			}

			return Color.FromArgb(maxR, maxG, maxB);
		}

		public void createKernel(int size)
		{
			kernel = new float[size, size]; // Ядро фильтра "максимума"

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					kernel[i, j] = 1; // Все значения равны 1 для определения максимума
				}
			}
		}
	}
}

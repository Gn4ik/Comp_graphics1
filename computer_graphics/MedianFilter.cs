using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
	internal class MedianFilter
	{
		public Bitmap ApplyMedianFilter(Bitmap image, int kernelSize)
		{
			Bitmap result = new Bitmap(image.Width, image.Height);

			int Rad = kernelSize / 2;

			for (int x = Rad; x < image.Width - Rad; x++)
			{
				for (int y = Rad; y < image.Height - Rad; y++)
				{
					int[] redValues = new int[kernelSize * kernelSize];
					int[] greenValues = new int[kernelSize * kernelSize];
					int[] blueValues = new int[kernelSize * kernelSize];
					int index = 0;

					for (int i = -Rad; i <= Rad; i++)
					{
						for (int j = -Rad; j <= Rad; j++)
						{
							Color pixel = image.GetPixel(x + i, y + j);
							redValues[index] = pixel.R;
							greenValues[index] = pixel.G;
							blueValues[index++] = pixel.B;
						}
					}

					Array.Sort(redValues);
					Array.Sort(greenValues);
					Array.Sort(blueValues);

					Color medianColor = Color.FromArgb(redValues[kernelSize * kernelSize / 2],
													   greenValues[kernelSize * kernelSize / 2],
													   blueValues[kernelSize * kernelSize / 2]);

					result.SetPixel(x, y, medianColor);
				}
			}

			return result;
		}
	}
}

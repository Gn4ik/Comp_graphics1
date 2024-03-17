using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
	internal class GrayWorld
	{
		public Bitmap grayWorldFilter(Bitmap image)
		{
			double avgR = 0;
			double avgG = 0;
			double avgB = 0;
			int N = image.Height * image.Width;
			Color color;
			for(int x = 0; x < image.Width; x++)
			{
				for (int y = 0; y < image.Height; y++)
				{
					color = image.GetPixel(x, y);
					avgR += color.R;
					avgG += color.G;
					avgB += color.B;
				}
			}
			avgR/= N; avgG /= N; avgB/= N;
			double AVG = (avgR + avgG + avgB)/3;
			int resultR;
			int resultG;
			int resultB;
			Color resultcolor;

			Bitmap resultImage = new Bitmap(image.Width, image.Height);

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					resultR = (int)(image.GetPixel(i, j).R * (AVG / avgR));
					resultG = (int)(image.GetPixel(i, j).G * (AVG / avgG));
					resultB = (int)(image.GetPixel(i, j).B * (AVG / avgB));
					resultcolor = Color.FromArgb(resultR, resultG, resultB);
					resultImage.SetPixel(i, j, resultcolor);
				}
			}

			return resultImage;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
	internal class Grad: MathMorphology
	{
		public Bitmap Gradient(Bitmap sourceImage, int[][] mask)
		{
			Dilation dil = new Dilation();
			Bitmap dilationResult = dil.DilationFilter(sourceImage, mask);
			Erosion er = new Erosion();
			Bitmap erosionResult = er.ErosionFilter(sourceImage, mask);

			Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

			for (int y = 0; y < sourceImage.Height; y++)
			{
				for (int x = 0; x < sourceImage.Width; x++)
				{
					Color dilationPixel = dilationResult.GetPixel(x, y);
					Color erosionPixel = erosionResult.GetPixel(x, y);

					int diffR = Math.Abs(dilationPixel.R - erosionPixel.R);
					int diffG = Math.Abs(dilationPixel.G - erosionPixel.G);
					int diffB = Math.Abs(dilationPixel.B - erosionPixel.B);

					Color newPixel = Color.FromArgb(diffR, diffG, diffB);
					resultImage.SetPixel(x, y, newPixel);
				}
			}

			return resultImage;
		}
	}
}

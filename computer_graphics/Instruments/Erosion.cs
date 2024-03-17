﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
    internal class Erosion: MathMorphology
    {
		public Bitmap ErosionFilter(Bitmap sourceImage, int[][] mask)
		{
			//{
			//new int[] {0, 0, 1, 0, 0},
			//new int[] {0, 1, 1, 1, 0},
			//new int[] {1, 1, 1, 1, 1},
			//new int[] {0, 1, 1, 1, 0},
			//new int[] {0, 0, 1, 0, 0},
			//};
			Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

			int MH = mask.Length;
			int MW = mask[0].Length;

			for (int y = MH / 2; y < sourceImage.Height - MH / 2; y++)
			{
				for (int x = MW / 2; x < sourceImage.Width - MW / 2; x++)
				{
					int min = 255;
					for (int j = -MH / 2; j <= MH / 2; j++)
					{
						for (int i = -MW / 2; i <= MW / 2; i++)
						{
							Color pixel = sourceImage.GetPixel(x + i, y + j);
							int pixelValue = (pixel.R + pixel.G + pixel.B) / 3;

							if (mask[j + MH / 2][i + MW / 2] == 1 && pixelValue < min)
							{
								min = pixelValue;
							}
						}
					}
					Color newPixel = Color.FromArgb(min, min, min);
					resultImage.SetPixel(x, y, newPixel);
				}
			}
			return resultImage;
		}
	}
}

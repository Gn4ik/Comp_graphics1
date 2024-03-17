using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
	internal class SepiaFilter : Filters
	{
		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			int k = 15;
			Color sourcecolor = image.GetPixel(x, y);
			int Intencity = (int)(0.299 * sourcecolor.R + 0.587 * sourcecolor.G + 0.114 * sourcecolor.B);
			int resultR = Intencity + 2 * k;
			int resultG = Intencity + (int)(0.5 * k);
			int resultB = Intencity - 1 * k;
			Color resultcolor = Color.FromArgb(Clamp(resultR), Clamp(resultG), Clamp(resultB));
			return resultcolor;
		}
	}
}

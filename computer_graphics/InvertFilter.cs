using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics
{
	internal class InvertFilter : Filters
	{
		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			Color sourceColor = image.GetPixel(x, y);
			Color resultColor = Color.FromArgb(255 -  sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
			return resultColor;
		}
	}
}

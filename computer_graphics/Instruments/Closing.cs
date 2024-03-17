using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
	internal class Closing: MathMorphology
	{
		public Bitmap ClosingFilter(Bitmap sourceImage, int[][] mask)
		{
			Dilation dilation = new Dilation();
			Bitmap resultImage = dilation.DilationFilter(sourceImage, mask);
			Erosion er = new Erosion();
			resultImage = er.ErosionFilter(resultImage, mask);

			return resultImage;
		}
	}
}

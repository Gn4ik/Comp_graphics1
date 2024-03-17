using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics.Instruments
{
    internal class OpeningFilter: MathMorphology
    {
		public Bitmap Opening(Bitmap sourceImage, int[][] mask)
		{
			Erosion er = new Erosion();
			Bitmap resultImage = er.ErosionFilter(sourceImage, mask);
			Dilation dilation = new Dilation();
			resultImage = dilation.DilationFilter(resultImage, mask);

			return resultImage;
		}
	}
}

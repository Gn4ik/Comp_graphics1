using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using computer_graphics.MatrixFilters;

namespace computer_graphics
{
    internal class GlowingEdges
	{
		public Bitmap ApplyGlowingEdgesFilter(Bitmap image)
		{
			int radius = 1;
			int kernelSize = 3;

			// Применяем медианный фильтр
			MedianFilter filter = new MedianFilter();
			Bitmap medianFiltered = filter.ApplyMedianFilter(image, 1);

			// Применяем фильтр для выделения контуров (например, оператор Прюитта)
			EdgeDetection detection = new EdgeDetection();
			Bitmap edgeFiltered = detection.PrewittFilter(medianFiltered);
			MaximumFilter maximumFilter = new MaximumFilter();

			Bitmap result = maximumFilter.processImage(edgeFiltered);

			return result;
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace computer_graphics
{
	abstract class Filters
	{
		protected int Clamp(int value)
		{
			return Math.Max(0, Math.Min(value, 255));
		}

		protected int Clamp(int val, int min, int max)
		{
			if (val < min) { return min; }
			if (val > max) { return max; }
			return val;
		}
		protected abstract Color calculateNewPixelColor(Bitmap image, int x, int y);
		public Bitmap processImage(Bitmap image, BackgroundWorker worker)
		{
			Bitmap resultImage = new Bitmap(image.Width, image.Height);

			for (int i = 0; i < image.Width; i++)
			{
				worker.ReportProgress((int)((float)i / resultImage.Width * 100));
				if (worker.CancellationPending) return null;
				for (int j = 0; j < image.Height; j++)
				{
					resultImage.SetPixel(i, j , calculateNewPixelColor(image, i, j));
				}
			}

			return resultImage;
		}
		public Bitmap processImage(Bitmap image)
		{
			Bitmap resultImage = new Bitmap(image.Width, image.Height);

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					resultImage.SetPixel(i, j, calculateNewPixelColor(image, i, j));
				}
			}

			return resultImage;
		}
	}
	abstract class MathMorphology
	{
		//
	}
	internal class GrayFilter: Filters
	{
		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			Color sourcecolor = image.GetPixel(x, y);
			int Intencity = (int)(0.299 * sourcecolor.R + 0.587 * sourcecolor.G + 0.114 * sourcecolor.B);
			Color resultcolor = Color.FromArgb(Intencity, Intencity, Intencity);
			return resultcolor;
		}
	}
	
	internal class Binary: Filters
	{
		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			Color sourceColor = image.GetPixel(x, y);
			int thresholdR = 128; // Порог для красного канала
			int thresholdG = 128; // Порог для зеленого канала
			int thresholdB = 128; // Порог для синего канала

			// Бинаризация на основе среднего значения канала
			int avg = (sourceColor.R + sourceColor.G + sourceColor.B) / 3;
			byte resultValue = (byte)((avg < 128) ? 0 : 255);

			Color resultcolor = Color.FromArgb(resultValue, resultValue, resultValue);
			return resultcolor;
		}
	}

	internal class Brightness : Filters
	{
		private int constant = 100;
		public Brightness(int consta){
			constant = consta;
		}
		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			Color sourceColor = image.GetPixel(x, y);

			// Увеличение яркости для каждого канала цвета
			int newRed = Clamp(sourceColor.R + constant); // Увеличение красного канала
			int newGreen = Clamp(sourceColor.G + constant); // Увеличение зеленого канала
			int newBlue = Clamp(sourceColor.B + constant); // Увеличение синего канала

			Color resultColor = Color.FromArgb(newRed, newGreen, newBlue);

			return resultColor;
		}
	}
	internal class MatrixFilter : Filters {
		protected float[,] kernel = null;
		protected MatrixFilter() { }
		public MatrixFilter(float[,] kernel)
		{
			this.kernel = kernel;
		}

		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			int radiusX = kernel.GetLength(0)/2;
			int radiusY = kernel.GetLength(1)/2;
			float resR = 0;
			float resG = 0;
			float resB = 0;
			for (int l = -radiusY; l <= radiusY; l++)
				for(int k = -radiusX; k <= radiusX; k++)
				{
					int idX = Clamp(x + k, 0, image.Width - 1);
					int idY = Clamp(y + l, 0, image.Height - 1);
					Color neighbourColor = image.GetPixel(idX, idY);
					resR += neighbourColor.R * kernel[k + radiusX, l + radiusY];
					resG += neighbourColor.G * kernel[k + radiusX, l + radiusY];
					resB += neighbourColor.B * kernel[k + radiusX, l + radiusY];
				}

			return Color.FromArgb(
				Clamp((int)resR), Clamp((int)resG), Clamp((int)resB));
		}
	}
}

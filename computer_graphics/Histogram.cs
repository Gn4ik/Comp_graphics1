using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_graphics
{
	internal class Histogram : Filters
	{
		public Bitmap CreateHistogramImage(Bitmap image)
		{
			int[] histogram = new int[256]; // Создаем массив для хранения гистограммы

			// Проход по каждому пикселю изображения и подсчет гистограммы
			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					Color pixel = image.GetPixel(x, y);
					int intensity = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B); // Вычисляем интенсивность пикселя
					histogram[intensity]++; // Увеличиваем счетчик для данного уровня интенсивности
				}
			}

			int minIntensity = 0;
			int maxIntensity = 255;

			while (histogram[minIntensity] == 0) minIntensity++;
			while (histogram[maxIntensity] == 0) maxIntensity--;

			// Линейное растяжение гистограммы
			Bitmap stretchedImage = new Bitmap(image.Width, image.Height);
			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					Color pixel = image.GetPixel(x, y);
					int newR = Clamp((int)((pixel.R - minIntensity) * 255.0 / (maxIntensity - minIntensity)));
					int newG = Clamp((int)((pixel.G - minIntensity) * 255.0 / (maxIntensity - minIntensity)));
					int newB = Clamp((int)((pixel.B - minIntensity) * 255.0 / (maxIntensity - minIntensity)));

					// Применение новой интенсивности
					Color newPixel = Color.FromArgb(newR, newG, newB);
					stretchedImage.SetPixel(x, y, newPixel);
				}
			}

			return stretchedImage;
		}

		protected override Color calculateNewPixelColor(Bitmap image, int x, int y)
		{
			throw new NotImplementedException();
		}
	}
}

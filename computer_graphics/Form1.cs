using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using computer_graphics.Instruments;
using computer_graphics.MatrixFilters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace computer_graphics
{
	public partial class Form1 : Form
	{
		Bitmap image;
		Bitmap buffImage;
		private float initialFormWidth;
		private float initialFormHeight;
		private BindingSource bindingSource = new BindingSource();
		private Stack<Bitmap> actionsHistory = new Stack<Bitmap>(); // Стек для хранения истории действий


		public Form1()
		{
			InitializeComponent();
			this.initialFormWidth = this.ClientSize.Width;
			this.initialFormHeight = this.ClientSize.Height;
			bindingSource.DataSource = actionsHistory;
		}
		private bool NotImage()
		{
			if (pictureBox1.Image == null)
			{
				Form form = new Form();
				Label label = new Label();
				label.Text = "No image available!";
				form.Text = "WARNING!";
				form.Controls.Add(label);
				form.Width = 320;
				form.Height = 200;
				label.Top = form.Height / 2 - 50;
				label.Left = form.Width / 2 - 50;
				form.StartPosition = FormStartPosition.Manual;
				form.Left = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
				form.Top = (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2;
				form.Show();
				return true;
			}
			return false;
		}
		private int[][] CreateStructElem()
		{
			int[][] structuringElement = null;

			using (Form form = new Form())
			{
				form.Text = "Set Structuring Element";
				form.Width = 650;
				form.Height = 250;

				DataGridView dataGridView = new DataGridView();
				dataGridView.Dock = DockStyle.Fill;
				dataGridView.ColumnCount = 5; // Задаем количество столбцов
				dataGridView.RowHeadersVisible = false;
				dataGridView.ColumnHeadersVisible = false;
				dataGridView.RowCount = 6;
				dataGridView.AllowUserToAddRows = false; 
				dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
				dataGridView.Size = new System.Drawing.Size();

				for (int i = 0; i < dataGridView.ColumnCount; i++)
				{
					dataGridView.Columns[i].ValueType = typeof(int); // Устанавливаем тип данных в колонках
				}
				dataGridView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
				System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
				buttonOk.Text = "OK";
				buttonOk.Dock = DockStyle.Bottom;
				buttonOk.Click += (sender, e) =>
				{
					int cols = dataGridView.ColumnCount;
					int rows = dataGridView.RowCount - 1;
					structuringElement = new int[rows + 1][];

					for (int i = 0; i < rows + 1; i++)
					{
						structuringElement[i] = new int[cols];
						for (int j = 0; j < cols; j++)
						{
							if (dataGridView[j, i].Value != null && int.TryParse(dataGridView[j, i].Value.ToString(), out int val))
							{
								structuringElement[i][j] = val;
							}
							else
							{
								structuringElement[i][j] = 0; // Значение по умолчанию, если не число или пусто
							}
						}
					}

					MessageBox.Show("Structuring Element set successfully!");
					form.Close();
				};

				form.Controls.Add(dataGridView);
				form.Controls.Add(buttonOk);
				form.ShowDialog();
			}

			return structuringElement;
		}

		private void saveCurrentState()
		{
			actionsHistory.Push(new Bitmap(pictureBox1.Image)); // Сохранение текущего состояния
			bindingSource.ResetBindings(false);
		}

		private void undoLastAction()
		{
			if (actionsHistory.Count > 0)
			{
				Bitmap previousState = actionsHistory.Pop();
				pictureBox1.Image = new Bitmap(previousState); // Восстанавливаем предыдущее состояние
				bindingSource.ResetBindings(false);
				pictureBox1.Refresh();
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.Z))
			{
				undoLastAction();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			float scaleX = (float)this.ClientSize.Width / initialFormWidth;
			float scaleY = (float)this.ClientSize.Height / initialFormHeight;

			foreach (Control control in Controls)
			{
				control.Left = (int)(control.Left * scaleX);
				control.Top = (int)(control.Top * scaleY);
				control.Width = (int)(control.Width * scaleX);
				control.Height = (int)(control.Height * scaleY);
			}

			initialFormWidth = this.ClientSize.Width;
			initialFormHeight = this.ClientSize.Height;
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image files|*.png;*.jpg|All files(*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				image = new Bitmap(dialog.FileName);
			}
			pictureBox1.Image = image;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void pointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Filters filter = new GrayFilter();
			//backgroundWorker1.RunWorkerAsync(filter);
			Bitmap resultimage = filter.processImage((Bitmap)pictureBox1.Image);
			pictureBox1.Image = resultimage;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Filters filter = new Binary();
			//backgroundWorker1.RunWorkerAsync(filter);
			Bitmap resultimage = filter.processImage((Bitmap)pictureBox1.Image);
			pictureBox1.Image = resultimage;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void standardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			pictureBox1.Image = image;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = true;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			Brightness filter = new Brightness(trackBar1.Value);
			Bitmap resultimage = filter.processImage((Bitmap)pictureBox1.Image);
			pictureBox1.Image = resultimage;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void blurFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			pictureBox1.Refresh();
			Filters filter = new BlurFilter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
			if (backgroundWorker1.CancellationPending != true)
				buffImage = newImage;
		}

		private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (!e.Cancelled)
			{
				pictureBox1.Image = buffImage;
				pictureBox1.Refresh();
			}
			progressBar1.Value = 0;
		}

		private void gaussianFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			pictureBox1.Refresh();
			Filters filter = new GaussianFilter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void invertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			pictureBox1.Refresh();
			Filters filter = new InvertFilter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			pictureBox1.Refresh();
			Filters filter = new SepiaFilter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void sobelFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			pictureBox1.Refresh();
			SobelFilter filter = new SobelFilter();
			pictureBox1.Image = filter.calculateNewBitmap((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void highSharpnessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			pictureBox1.Refresh();
			Filters filter = new HighSharpness();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			saveCurrentState();
			Filters filter = new EmbossingFilter();
			backgroundWorker1.RunWorkerAsync(filter);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Image files|*.png;*.jpg|All files(*.*)|*.*";
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			string filename = saveFileDialog1.FileName;
			pictureBox1.Image.Save(filename);
			MessageBox.Show("Файл сохранен");
		}

		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			undoLastAction();
		}

		private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Histogram histogram = new Histogram();
			Bitmap histogramImage = histogram.CreateHistogramImage((Bitmap)pictureBox1.Image);
			//DisplayHistogramImage(histogramImage);
			pictureBox1.Image = histogramImage;
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			GrayWorld grayWorld = new GrayWorld();
			pictureBox1.Image = grayWorld.grayWorldFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			MedianFilter filter = new MedianFilter();
			pictureBox1.Image = filter.ApplyMedianFilter((Bitmap)pictureBox1.Image, 7);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void wave1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Wave filter = new Wave();
			pictureBox1.Image = filter.Wave1Filter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void wave2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Wave filter = new Wave();
			pictureBox1.Image = filter.Wave2Filter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Rotate filter = new Rotate();
			pictureBox1.Image = filter.RotateFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void glassFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Glass filter = new Glass();
			pictureBox1.Image = filter.GlassFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void coupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Coup filter = new Coup();
			pictureBox1.Image = filter.CoupFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void sharrFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			EdgeDetection filter = new EdgeDetection();
			pictureBox1.Image = filter.SharrFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void prewittFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			EdgeDetection filter = new EdgeDetection();
			pictureBox1.Image = filter.PrewittFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void glowingEdgesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			GlowingEdges filter = new GlowingEdges();
			pictureBox1.Image = filter.ApplyGlowingEdgesFilter((Bitmap)pictureBox1.Image);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Motion_Blur filter = new Motion_Blur();
			pictureBox1.Image = filter.ApplyMotionBlurFilter((Bitmap)pictureBox1.Image, 7);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Dilation filter = new Dilation();
			int[][] mask = CreateStructElem();
			pictureBox1.Image = filter.DilationFilter((Bitmap)pictureBox1.Image, mask);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Erosion filter = new Erosion();
			int[][] mask = CreateStructElem();
			pictureBox1.Image = filter.ErosionFilter((Bitmap)pictureBox1.Image, mask);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void openingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			OpeningFilter filter = new OpeningFilter();
			int[][] mask = CreateStructElem();
			pictureBox1.Image = filter.Opening((Bitmap)pictureBox1.Image, mask);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void closingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Closing filter = new Closing();
			int[][] mask = CreateStructElem();
			pictureBox1.Image = filter.ClosingFilter((Bitmap)pictureBox1.Image, mask);
			saveCurrentState();
			pictureBox1.Refresh();
		}

		private void gradToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NotImage() == true) return;
			trackBar1.Visible = false;
			Grad filter = new Grad();
			int[][] mask = CreateStructElem();
			pictureBox1.Image = filter.Gradient((Bitmap)pictureBox1.Image, mask);
			saveCurrentState();
			pictureBox1.Refresh();
		}



		//private void DisplayHistogramImage(Bitmap histogramImage)
		//{
		//	Form histogramForm = new Form();
		//	PictureBox pictureBox = new PictureBox();
		//	pictureBox.Image = histogramImage;
		//	pictureBox.Width = histogramImage.Width;
		//	pictureBox.Height = histogramImage.Height;
		//	histogramForm.Controls.Add(pictureBox);
		//	histogramForm.ClientSize = new Size(pictureBox.Width + 20, pictureBox.Height + 40);

		//	histogramForm.Show();
		//}
	}
}
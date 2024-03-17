namespace computer_graphics
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			filtersToolStripMenuItem = new ToolStripMenuItem();
			pointToolStripMenuItem = new ToolStripMenuItem();
			matrixToolStripMenuItem = new ToolStripMenuItem();
			standardToolStripMenuItem = new ToolStripMenuItem();
			brightnessToolStripMenuItem = new ToolStripMenuItem();
			matrixToolStripMenuItem1 = new ToolStripMenuItem();
			blurFilterToolStripMenuItem = new ToolStripMenuItem();
			gaussianFilterToolStripMenuItem = new ToolStripMenuItem();
			sobelFilterToolStripMenuItem = new ToolStripMenuItem();
			highSharpnessToolStripMenuItem = new ToolStripMenuItem();
			embossingToolStripMenuItem = new ToolStripMenuItem();
			motionBlurToolStripMenuItem = new ToolStripMenuItem();
			invertToolStripMenuItem = new ToolStripMenuItem();
			sepiaToolStripMenuItem = new ToolStripMenuItem();
			histogramToolStripMenuItem = new ToolStripMenuItem();
			histogramToolStripMenuItem1 = new ToolStripMenuItem();
			grayWorldToolStripMenuItem = new ToolStripMenuItem();
			medianFilterToolStripMenuItem = new ToolStripMenuItem();
			waveFilterToolStripMenuItem = new ToolStripMenuItem();
			waveFilterToolStripMenuItem1 = new ToolStripMenuItem();
			wave1ToolStripMenuItem = new ToolStripMenuItem();
			wave2ToolStripMenuItem = new ToolStripMenuItem();
			rotateToolStripMenuItem = new ToolStripMenuItem();
			coupToolStripMenuItem = new ToolStripMenuItem();
			dilationToolStripMenuItem = new ToolStripMenuItem();
			erosionToolStripMenuItem = new ToolStripMenuItem();
			openingToolStripMenuItem = new ToolStripMenuItem();
			closingToolStripMenuItem = new ToolStripMenuItem();
			glassFilterToolStripMenuItem = new ToolStripMenuItem();
			edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
			sharrFilterToolStripMenuItem = new ToolStripMenuItem();
			prewittFilterToolStripMenuItem = new ToolStripMenuItem();
			glowingEdgesToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			backToolStripMenuItem = new ToolStripMenuItem();
			pictureBox1 = new PictureBox();
			trackBar1 = new TrackBar();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			progressBar1 = new ProgressBar();
			button1 = new Button();
			bindingSource1 = new BindingSource(components);
			gradToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, filtersToolStripMenuItem, editToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(790, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(141, 26);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.Size = new Size(141, 26);
			saveAsToolStripMenuItem.Text = "Save as";
			saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
			// 
			// filtersToolStripMenuItem
			// 
			filtersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pointToolStripMenuItem, matrixToolStripMenuItem, standardToolStripMenuItem, brightnessToolStripMenuItem, matrixToolStripMenuItem1, invertToolStripMenuItem, sepiaToolStripMenuItem, histogramToolStripMenuItem, medianFilterToolStripMenuItem, waveFilterToolStripMenuItem, glassFilterToolStripMenuItem, edgeDetectionToolStripMenuItem });
			filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
			filtersToolStripMenuItem.Size = new Size(62, 24);
			filtersToolStripMenuItem.Text = "Filters";
			// 
			// pointToolStripMenuItem
			// 
			pointToolStripMenuItem.Name = "pointToolStripMenuItem";
			pointToolStripMenuItem.Size = new Size(224, 26);
			pointToolStripMenuItem.Text = "GrayScaleFilter";
			pointToolStripMenuItem.Click += pointToolStripMenuItem_Click;
			// 
			// matrixToolStripMenuItem
			// 
			matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
			matrixToolStripMenuItem.Size = new Size(224, 26);
			matrixToolStripMenuItem.Text = "Binary";
			matrixToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
			// 
			// standardToolStripMenuItem
			// 
			standardToolStripMenuItem.Name = "standardToolStripMenuItem";
			standardToolStripMenuItem.Size = new Size(224, 26);
			standardToolStripMenuItem.Text = "Standard";
			standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
			// 
			// brightnessToolStripMenuItem
			// 
			brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
			brightnessToolStripMenuItem.Size = new Size(224, 26);
			brightnessToolStripMenuItem.Text = "Brightness";
			brightnessToolStripMenuItem.Click += brightnessToolStripMenuItem_Click;
			// 
			// matrixToolStripMenuItem1
			// 
			matrixToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { blurFilterToolStripMenuItem, gaussianFilterToolStripMenuItem, sobelFilterToolStripMenuItem, highSharpnessToolStripMenuItem, embossingToolStripMenuItem, motionBlurToolStripMenuItem });
			matrixToolStripMenuItem1.Name = "matrixToolStripMenuItem1";
			matrixToolStripMenuItem1.Size = new Size(224, 26);
			matrixToolStripMenuItem1.Text = "Matrix";
			// 
			// blurFilterToolStripMenuItem
			// 
			blurFilterToolStripMenuItem.Name = "blurFilterToolStripMenuItem";
			blurFilterToolStripMenuItem.Size = new Size(190, 26);
			blurFilterToolStripMenuItem.Text = "BlurFilter";
			blurFilterToolStripMenuItem.Click += blurFilterToolStripMenuItem_Click;
			// 
			// gaussianFilterToolStripMenuItem
			// 
			gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
			gaussianFilterToolStripMenuItem.Size = new Size(190, 26);
			gaussianFilterToolStripMenuItem.Text = "GaussianFilter";
			gaussianFilterToolStripMenuItem.Click += gaussianFilterToolStripMenuItem_Click;
			// 
			// sobelFilterToolStripMenuItem
			// 
			sobelFilterToolStripMenuItem.Name = "sobelFilterToolStripMenuItem";
			sobelFilterToolStripMenuItem.Size = new Size(190, 26);
			sobelFilterToolStripMenuItem.Text = "SobelFilter";
			sobelFilterToolStripMenuItem.Click += sobelFilterToolStripMenuItem_Click;
			// 
			// highSharpnessToolStripMenuItem
			// 
			highSharpnessToolStripMenuItem.Name = "highSharpnessToolStripMenuItem";
			highSharpnessToolStripMenuItem.Size = new Size(190, 26);
			highSharpnessToolStripMenuItem.Text = "HighSharpness";
			highSharpnessToolStripMenuItem.Click += highSharpnessToolStripMenuItem_Click;
			// 
			// embossingToolStripMenuItem
			// 
			embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
			embossingToolStripMenuItem.Size = new Size(190, 26);
			embossingToolStripMenuItem.Text = "Embossing";
			embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
			// 
			// motionBlurToolStripMenuItem
			// 
			motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
			motionBlurToolStripMenuItem.Size = new Size(190, 26);
			motionBlurToolStripMenuItem.Text = "Motion Blur";
			motionBlurToolStripMenuItem.Click += motionBlurToolStripMenuItem_Click;
			// 
			// invertToolStripMenuItem
			// 
			invertToolStripMenuItem.Name = "invertToolStripMenuItem";
			invertToolStripMenuItem.Size = new Size(224, 26);
			invertToolStripMenuItem.Text = "Invert ";
			invertToolStripMenuItem.Click += invertToolStripMenuItem_Click;
			// 
			// sepiaToolStripMenuItem
			// 
			sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
			sepiaToolStripMenuItem.Size = new Size(224, 26);
			sepiaToolStripMenuItem.Text = "Sepia";
			sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
			// 
			// histogramToolStripMenuItem
			// 
			histogramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { histogramToolStripMenuItem1, grayWorldToolStripMenuItem });
			histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
			histogramToolStripMenuItem.Size = new Size(224, 26);
			histogramToolStripMenuItem.Text = "Color correction";
			// 
			// histogramToolStripMenuItem1
			// 
			histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
			histogramToolStripMenuItem1.Size = new Size(166, 26);
			histogramToolStripMenuItem1.Text = "Histogram";
			histogramToolStripMenuItem1.Click += histogramToolStripMenuItem1_Click;
			// 
			// grayWorldToolStripMenuItem
			// 
			grayWorldToolStripMenuItem.Name = "grayWorldToolStripMenuItem";
			grayWorldToolStripMenuItem.Size = new Size(166, 26);
			grayWorldToolStripMenuItem.Text = "Gray World";
			grayWorldToolStripMenuItem.Click += grayWorldToolStripMenuItem_Click;
			// 
			// medianFilterToolStripMenuItem
			// 
			medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
			medianFilterToolStripMenuItem.Size = new Size(224, 26);
			medianFilterToolStripMenuItem.Text = "MedianFilter";
			medianFilterToolStripMenuItem.Click += medianFilterToolStripMenuItem_Click;
			// 
			// waveFilterToolStripMenuItem
			// 
			waveFilterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { waveFilterToolStripMenuItem1, rotateToolStripMenuItem, coupToolStripMenuItem, dilationToolStripMenuItem, erosionToolStripMenuItem, openingToolStripMenuItem, closingToolStripMenuItem, gradToolStripMenuItem });
			waveFilterToolStripMenuItem.Name = "waveFilterToolStripMenuItem";
			waveFilterToolStripMenuItem.Size = new Size(224, 26);
			waveFilterToolStripMenuItem.Text = "Instruments";
			// 
			// waveFilterToolStripMenuItem1
			// 
			waveFilterToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { wave1ToolStripMenuItem, wave2ToolStripMenuItem });
			waveFilterToolStripMenuItem1.Name = "waveFilterToolStripMenuItem1";
			waveFilterToolStripMenuItem1.Size = new Size(224, 26);
			waveFilterToolStripMenuItem1.Text = "WaveFilter";
			// 
			// wave1ToolStripMenuItem
			// 
			wave1ToolStripMenuItem.Name = "wave1ToolStripMenuItem";
			wave1ToolStripMenuItem.Size = new Size(136, 26);
			wave1ToolStripMenuItem.Text = "Wave1";
			wave1ToolStripMenuItem.Click += wave1ToolStripMenuItem_Click;
			// 
			// wave2ToolStripMenuItem
			// 
			wave2ToolStripMenuItem.Name = "wave2ToolStripMenuItem";
			wave2ToolStripMenuItem.Size = new Size(136, 26);
			wave2ToolStripMenuItem.Text = "Wave2";
			wave2ToolStripMenuItem.Click += wave2ToolStripMenuItem_Click;
			// 
			// rotateToolStripMenuItem
			// 
			rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
			rotateToolStripMenuItem.Size = new Size(224, 26);
			rotateToolStripMenuItem.Text = "Rotate";
			rotateToolStripMenuItem.Click += rotateToolStripMenuItem_Click;
			// 
			// coupToolStripMenuItem
			// 
			coupToolStripMenuItem.Name = "coupToolStripMenuItem";
			coupToolStripMenuItem.Size = new Size(224, 26);
			coupToolStripMenuItem.Text = "Coup";
			coupToolStripMenuItem.Click += coupToolStripMenuItem_Click;
			// 
			// dilationToolStripMenuItem
			// 
			dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
			dilationToolStripMenuItem.Size = new Size(224, 26);
			dilationToolStripMenuItem.Text = "Dilation";
			dilationToolStripMenuItem.Click += dilationToolStripMenuItem_Click;
			// 
			// erosionToolStripMenuItem
			// 
			erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
			erosionToolStripMenuItem.Size = new Size(224, 26);
			erosionToolStripMenuItem.Text = "Erosion";
			erosionToolStripMenuItem.Click += erosionToolStripMenuItem_Click;
			// 
			// openingToolStripMenuItem
			// 
			openingToolStripMenuItem.Name = "openingToolStripMenuItem";
			openingToolStripMenuItem.Size = new Size(224, 26);
			openingToolStripMenuItem.Text = "Opening";
			openingToolStripMenuItem.Click += openingToolStripMenuItem_Click;
			// 
			// closingToolStripMenuItem
			// 
			closingToolStripMenuItem.Name = "closingToolStripMenuItem";
			closingToolStripMenuItem.Size = new Size(224, 26);
			closingToolStripMenuItem.Text = "Closing";
			closingToolStripMenuItem.Click += closingToolStripMenuItem_Click;
			// 
			// glassFilterToolStripMenuItem
			// 
			glassFilterToolStripMenuItem.Name = "glassFilterToolStripMenuItem";
			glassFilterToolStripMenuItem.Size = new Size(224, 26);
			glassFilterToolStripMenuItem.Text = "GlassFilter";
			glassFilterToolStripMenuItem.Click += glassFilterToolStripMenuItem_Click;
			// 
			// edgeDetectionToolStripMenuItem
			// 
			edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sharrFilterToolStripMenuItem, prewittFilterToolStripMenuItem, glowingEdgesToolStripMenuItem });
			edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
			edgeDetectionToolStripMenuItem.Size = new Size(224, 26);
			edgeDetectionToolStripMenuItem.Text = "EdgeDetection";
			// 
			// sharrFilterToolStripMenuItem
			// 
			sharrFilterToolStripMenuItem.Name = "sharrFilterToolStripMenuItem";
			sharrFilterToolStripMenuItem.Size = new Size(187, 26);
			sharrFilterToolStripMenuItem.Text = "SharrFilter";
			sharrFilterToolStripMenuItem.Click += sharrFilterToolStripMenuItem_Click;
			// 
			// prewittFilterToolStripMenuItem
			// 
			prewittFilterToolStripMenuItem.Name = "prewittFilterToolStripMenuItem";
			prewittFilterToolStripMenuItem.Size = new Size(187, 26);
			prewittFilterToolStripMenuItem.Text = "PrewittFilter";
			prewittFilterToolStripMenuItem.Click += prewittFilterToolStripMenuItem_Click;
			// 
			// glowingEdgesToolStripMenuItem
			// 
			glowingEdgesToolStripMenuItem.Name = "glowingEdgesToolStripMenuItem";
			glowingEdgesToolStripMenuItem.Size = new Size(187, 26);
			glowingEdgesToolStripMenuItem.Text = "GlowingEdges";
			glowingEdgesToolStripMenuItem.Click += glowingEdgesToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(49, 24);
			editToolStripMenuItem.Text = "Edit";
			// 
			// backToolStripMenuItem
			// 
			backToolStripMenuItem.Name = "backToolStripMenuItem";
			backToolStripMenuItem.Size = new Size(123, 26);
			backToolStripMenuItem.Text = "Back";
			backToolStripMenuItem.Click += backToolStripMenuItem_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(0, 27);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(790, 607);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// trackBar1
			// 
			trackBar1.Location = new Point(0, 578);
			trackBar1.Maximum = 100;
			trackBar1.Minimum = -100;
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(790, 56);
			trackBar1.TabIndex = 2;
			trackBar1.Value = 1;
			trackBar1.Visible = false;
			trackBar1.Scroll += trackBar1_Scroll;
			// 
			// backgroundWorker1
			// 
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.WorkerSupportsCancellation = true;
			backgroundWorker1.DoWork += backgroundWorker1_DoWork;
			backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
			backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(12, 640);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(615, 29);
			progressBar1.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(645, 640);
			button1.Name = "button1";
			button1.Size = new Size(133, 29);
			button1.TabIndex = 4;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// gradToolStripMenuItem
			// 
			gradToolStripMenuItem.Name = "gradToolStripMenuItem";
			gradToolStripMenuItem.Size = new Size(224, 26);
			gradToolStripMenuItem.Text = "Gradient";
			gradToolStripMenuItem.Click += gradToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(790, 685);
			Controls.Add(button1);
			Controls.Add(progressBar1);
			Controls.Add(trackBar1);
			Controls.Add(pictureBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			SizeChanged += Form1_SizeChanged;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem filtersToolStripMenuItem;
		private ToolStripMenuItem pointToolStripMenuItem;
		private ToolStripMenuItem matrixToolStripMenuItem;
		private PictureBox pictureBox1;
		private ToolStripMenuItem standardToolStripMenuItem;
		private ToolStripMenuItem brightnessToolStripMenuItem;
		private TrackBar brightnessTrackBar;
		private TrackBar trackBar1;
		private ToolStripMenuItem matrixToolStripMenuItem1;
		private ToolStripMenuItem blurFilterToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ProgressBar progressBar1;
		private Button button1;
		private ToolStripMenuItem gaussianFilterToolStripMenuItem;
		private ToolStripMenuItem invertToolStripMenuItem;
		private ToolStripMenuItem sepiaToolStripMenuItem;
		private ToolStripMenuItem sobelFilterToolStripMenuItem;
		private ToolStripMenuItem highSharpnessToolStripMenuItem;
		private ToolStripMenuItem embossingToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private BindingSource bindingSource1;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem backToolStripMenuItem;
		private ToolStripMenuItem histogramToolStripMenuItem;
		private ToolStripMenuItem histogramToolStripMenuItem1;
		private ToolStripMenuItem grayWorldToolStripMenuItem;
		private ToolStripMenuItem medianFilterToolStripMenuItem;
		private ToolStripMenuItem waveFilterToolStripMenuItem;
		private ToolStripMenuItem waveFilterToolStripMenuItem1;
		private ToolStripMenuItem wave1ToolStripMenuItem;
		private ToolStripMenuItem wave2ToolStripMenuItem;
		private ToolStripMenuItem rotateToolStripMenuItem;
		private ToolStripMenuItem glassFilterToolStripMenuItem;
		private ToolStripMenuItem coupToolStripMenuItem;
		private ToolStripMenuItem edgeDetectionToolStripMenuItem;
		private ToolStripMenuItem sharrFilterToolStripMenuItem;
		private ToolStripMenuItem prewittFilterToolStripMenuItem;
		private ToolStripMenuItem glowingEdgesToolStripMenuItem;
		private ToolStripMenuItem motionBlurToolStripMenuItem;
		private ToolStripMenuItem dilationToolStripMenuItem;
		private ToolStripMenuItem erosionToolStripMenuItem;
		private ToolStripMenuItem openingToolStripMenuItem;
		private ToolStripMenuItem closingToolStripMenuItem;
		private ToolStripMenuItem gradToolStripMenuItem;
	}
}
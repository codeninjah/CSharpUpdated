using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideshowApp
{
	public partial class Form1 : Form
	{
		private int fileNumber;
		private DateTime startTime;
		private int timer;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			//pictureBox1.ImageLocation = openFileDialog1.FileNames[fileNumber];
			//pictureBox1.Load();
			timer1.Enabled = true;
			timer2.Enabled = true;
			startTime = DateTime.Now;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DisplayFileNumber(fileNumber);
			fileNumber++;
			if (fileNumber >= openFileDialog1.FileNames.Count())
				{
				fileNumber = 0;
			}

		}

		private void DisplayFileNumber(int fileNumber)
		{
			pictureBox1.ImageLocation = openFileDialog1.FileNames[fileNumber];
			pictureBox1.Load();
			if ((DateTime.Now - startTime).TotalSeconds >= 60)
				timer1.Enabled = false;
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			var timer = DateTime.Now.Second.ToString();
			label1.Text = timer;
		}
	}
}

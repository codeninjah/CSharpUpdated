using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteTwoFilesToAThirdApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			var path = folderBrowserDialog1.SelectedPath;
			foreach (var fileName in Directory.GetFiles(path, "*.txt"))
			{
				comboBox1.Items.Add(fileName);
			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			//saveFileDialog1.ShowDialog();
			//var content = File.ReadAllText(openFileDialog1.FileName);

			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			

			openFileDialog2.ShowDialog();
			var content2 = File.ReadAllText(openFileDialog2.FileName);
			//var content3 = File.ReadAllText(openFileDialog1.FileName);
			toolStripStatusLabel1.Text = openFileDialog2.FileName;

			saveFileDialog2.ShowDialog();
			File.AppendAllText(saveFileDialog2.FileName, content2);
			//File.AppendAllText(saveFileDialog3.FileName, content2);

			
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			var content1 = File.ReadAllText(openFileDialog1.FileName);
			toolStripStatusLabel1.Text = openFileDialog1.FileName;


			saveFileDialog1.ShowDialog();
			File.AppendAllText(saveFileDialog1.FileName, content1);
			string content = File.ReadAllText(openFileDialog1.FileName);
			toolStripStatusLabel1.Text = content;
		}
	}
}

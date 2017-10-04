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

namespace CustomerForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			var attSkrivaTill = textBox1.Text + ";" + dateTimePicker1.Value.ToString("yyyy MM dd") + ";" + textBox2.Text + Environment.NewLine;
			

			saveFileDialog1.ShowDialog();
			File.AppendAllText(saveFileDialog1.FileName, attSkrivaTill);
			File.AppendAllText(saveFileDialog1.FileName, "\n");
			//File.AppendAllText(saveFileDialog3.FileName, content2);
		}
	}
}

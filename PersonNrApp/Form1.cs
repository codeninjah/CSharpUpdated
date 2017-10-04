using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonNrApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var fNamn = textBox1.Text;
			var eNamn = textBox2.Text;
			var pNummer = textBox3.Text;

			var läggIhop = fNamn + " " + eNamn + " " + pNummer;

			var s = int.Parse(pNummer.Substring(9, 1));

			if (s % 2 == 0)
			{
				greetLabel.Text = $"Välkommen fröken {fNamn}";
			}
			else
				greetLabel.Text = $"Välkommen herren {fNamn}";



		}



	}
}

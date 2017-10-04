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
		string fNamnT;
		string eNamnT;
		string personNrT;

		public Form1()
		{
			InitializeComponent();
		}

		public void EnterDetails(string fNamnT, string eNamnT, string personNrT)
		{
			this.fNamnT = fNamnT;
			this.eNamnT = eNamnT;
			this.personNrT = personNrT;
		}

		public string Greeting
		{
			get
			{
				var sexDigit = int.Parse(personNrT.Substring(9, 1));
				if (sexDigit % 2 == 1)
					return $"God morgon herr {this.eNamnT}";
				return $"God morgon fröken {this.eNamnT}";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var fNamn = textBox1.Text;
			var eNamn = textBox2.Text;
			var pNummer = textBox3.Text;

			//var läggIhop = fNamn + " " + eNamn + " " + pNummer;

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

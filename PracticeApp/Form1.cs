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
using PracticeLib;

namespace PracticeApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			var personNr = txt_PersonNr.Text;
			var namn = dtp_Fodelsedatum.Value.ToString("yyyy-MM-dd");
			
			var telefon = txt_PhoneNr.Text;
			var allauppgifter = $"{personNr};{namn};{telefon}";

			spara_tillFil.ShowDialog();
			File.WriteAllText(spara_tillFil.FileName, allauppgifter);
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void btn_Convert_Click(object sender, EventArgs e)
		{
			lasa_frånFil.ShowDialog();
			var content = File.ReadAllText(lasa_frånFil.FileName);
			Class1 test = new Class1();
			test.delaString(content);

			konvertera_tillFil.ShowDialog();				
			File.AppendAllText(konvertera_tillFil.FileName, test.delaString(content) + "\n");
			}
	}
}

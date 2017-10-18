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
				string[] dela = content.Split(';');
			var name = dela[0];
			var age = dela[1];
			var years = DateTime.Now.Year - dtp_Fodelsedatum.Value.Year;
			//var age = dela[1];
			var telefonnr = dela[2];
			var allauppgifter = $"{name} är {years} år gammal och har telefonnumret {telefonnr}";

				konvertera_tillFil.ShowDialog();				
				File.WriteAllText(konvertera_tillFil.FileName, allauppgifter);
			}
	}
}

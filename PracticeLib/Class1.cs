using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class Class1
    {
		string[] dela;
		string name;
		int years;
		string telefonnr;

		public string nameString
		{
			get
			{
				return name;
			}
		}

		public int yearsskillnad
		{
			get
			{
				return years;
			}
		}

		public string telefonnummer
		{
			get
			{
				return telefonnr;
			}
		}


		public string delaString(string s)
		{
			var dela = s.Split(';');
			 name = dela[0];
			years = DateTime.Now.Year - DateTime.Parse(dela[1]).Year;
			//var year = DateTime.Parse(dela[1]).Year;
			telefonnr = dela[2];
			var allauppgifter = $"{name} är {years} år gammal och har telefonnummret {telefonnr}" + "\n";
			return allauppgifter;

		}
	}
}

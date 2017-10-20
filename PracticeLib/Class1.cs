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
		DateTime years;
		string telefonnr;

		public string nameString
		{
			get
			{
				return name;
			}
		}

		public DateTime yearsskillnad
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
			 //years = DateTime.Now.Year - DateTime.Parse(dela[1]).Year;
			//year2 = DateTime.Now.Year - year;
			//years = DateTime.Parse(year);
			 telefonnr = dela[1];
			var allauppgifter = $"{name} har telefonnummret {telefonnr} \n";
			return allauppgifter;

		}
	}
}

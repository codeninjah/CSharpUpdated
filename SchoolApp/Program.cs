using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var skola = new School("EC Utbildning");
			var SPO15 = new Class("SPO15", 20);
			var SPO16 = new Class("SPO16", 25);
			var SPO17 = new Class("SPO17", 30);

			skola.Classer.Add(SPO15);
			skola.Classer.Add(SPO16);
			skola.Classer.Add(SPO17);

			Console.WriteLine($"{skola}");
			
		}
	}
}

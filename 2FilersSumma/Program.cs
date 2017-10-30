using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FilersSumma
{
	class Program
	{
		static void Main(string[] args)
		{
			var fil1 = "";
			var fil2 = "";
			var fil3 = "";
			var siffra1 = 0M;
			var siffra2 = 0M;
			var siffra3 = 0M;
			var lines1 = "";
			var lines2 = "";
			var output = "";

			Console.WriteLine("Ange sökväg för fil1.txt");
			fil1 = Console.ReadLine();
			Console.WriteLine("Ange sökväg för fil2.txt");
			fil2 = Console.ReadLine();
			StreamReader reader1 = new StreamReader(fil1);
			while (true)
			{
				lines1 = reader1.ReadLine();
				if (lines1 == null)
					break;
				StreamReader reader2 = new StreamReader(fil2);
				while (true)
					{
					lines2 = reader2.ReadLine();
					if (lines2 == null)
						break;
					siffra1 = decimal.Parse(lines1, CultureInfo.InvariantCulture);
					siffra2 = decimal.Parse(lines2, CultureInfo.InvariantCulture);
					siffra3 = siffra1 * siffra2;
					output += $" {siffra1} x {siffra2} = {siffra3} \n";
				}
				
				Console.WriteLine(output);
			}

			Console.WriteLine("Ange sökvägen till filen som du vill skriva till");
			fil3 = Console.ReadLine();
			StreamWriter skrivatillFil = new StreamWriter(fil3);
			skrivatillFil.WriteLine(output + "\n");
			skrivatillFil.Close();

			Console.WriteLine("Great success!");

			Console.ReadKey();
		}
	}
}

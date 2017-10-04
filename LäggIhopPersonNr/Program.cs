using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LäggIhopPersonNr
{
	class Program
	{
		static void Main(string[] args)
		{
			double summa = 0;

			int[] arr1 = new int[] { 7, 1, 0, 4, 0, 5, 7, 8, 5 };
			int[] arr2 = new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
			int[] arr3 = new int[] { 14, 1, 0, 4, 0, 5, 14, 8, 10 };
			int[] arr4 = new int[] { 5, 1, 0, 4, 0, 5, 5, 8, 1 };

			for (int i = 0; i < arr4.Length; i++)
			{
				summa = arr4.Sum(digit => digit) + 0.00;
				
			}

			summa = System.Math.Ceiling((double.Parse(summa.ToString())) * 1000000) / 1000000;

			Console.WriteLine(summa);

		}
	}
}

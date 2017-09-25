using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Dice
    {
		public int NumberOfDots;

		public void Throw()
		{
			Random antalPrickar = new Random();
			NumberOfDots = antalPrickar.Next(1, 6);
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
	public class Game
	{
		public bool YouAreAWinner;
		public void ThrowDices()
		{
			Dice DiceOne = new Dice();
			Dice DiceTwo = new Dice();
			DiceOne.Throw();
			DiceTwo.Throw();

			if (DiceOne.NumberOfDots + DiceTwo.NumberOfDots == 7)
			{
				YouAreAWinner = true;
			}
			else
				YouAreAWinner = false;

		}

	}
}

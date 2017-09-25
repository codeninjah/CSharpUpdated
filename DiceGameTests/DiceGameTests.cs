using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGame;

namespace DiceGameTests
{
	[TestClass]
	public class DiceGameTests
	{
		[TestMethod]
		public void Dices()
		{
			//Assemble
			Game Spelet = new Game();
			Spelet.ThrowDices();

			while (!Spelet.YouAreAWinner)
			{
				Spelet.ThrowDices();
			}
		}

		
	}
}

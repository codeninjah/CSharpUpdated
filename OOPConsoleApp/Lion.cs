using System;

namespace OOPConsoleApp
{
	internal class Lion : Animal
	{
		public Lion()
		{
		}

		//om man vill ha med Eat() från klassen samt det nya
		public override void Eat()
		{
			//detta ger det gamla Eat(), det som är ärvt från Animal
			base.Eat();
			//detta är det nya Eat() som läggs till 
			Console.WriteLine("Hunting prey.");
		}
	}
}
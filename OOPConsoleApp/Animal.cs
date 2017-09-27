using System;

namespace OOPConsoleApp
{
	internal class Animal
	{
		//virtual är nyckelordet ifall man vill overrida
		//dvs ha denna metod med i subklasser so har egen Eat() metod
		public virtual void Eat()
		{
			Console.WriteLine("Grumph.");
		}
	}
}
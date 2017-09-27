//importerade namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
	//när det står klass utan nyckelord framåt är den internal
	//
	class Program
	{
	
		static void Main(string[] args)
		{
			//StudentDemo();
			InheritanceDemo();
			Console.ReadLine();
		}

		private static void InheritanceDemo()
		{
			Animal anAnimal = new Animal();
			Lion aLion = new Lion();
			TellAnimalToEatTwice(aLion);
		}

		//anAnimal = virtuellt objekt
		//eftersom Eat() är virtual (i Animal), följer den arvet ända till subklassen Lion och dess Eat() metod
		private static void TellAnimalToEatTwice(Animal anAnimal)
		{
			anAnimal.Eat();
			anAnimal.Eat();
		}

		private static void StudentDemo()
		{
			var mattias = new Student();
			mattias.Name = "Mattias Asplund";
			mattias.Email = "mattias@mattiasasplund.se";
			mattias.TooTired += Mattias_TooTired;
			mattias.StudyHarder();
			mattias.StudyHarder();
			mattias.StudyHarder();

			//statisk metod --- "Console"
			Console.WriteLine($"Hello World to {mattias}");
			Console.ReadLine();
		}

		//typ av metod: call-back metod
		//den metoden cal-backas av too tired eventet på mattias
		private static void Mattias_TooTired(object sender, EventArgs e)
		{
			Console.WriteLine("Student needs to rest.");
		}
	}
}

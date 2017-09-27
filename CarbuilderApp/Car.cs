using System.Collections.Generic;
using System.Linq;

namespace CarbuilderApp
{
	internal class Car
	{
		private string name;

		public Car(string name)
		{
			this.name = name;
		}

		//Generisk lista. Listan kan fyllas med objekt som ärver en viss typ
		//Det går inte o stoppa in andra typer av föremål
		//I det här fallet Part
		public List<Part> Parts { get; internal set; }
		= new List<Part>();
		public decimal Cost {
			get
			{
				return this.Parts.Sum(part => part.Cost) * 1.3M;
			}
			}

		public override string ToString()
		{
			return this.name;
		}
	}
}
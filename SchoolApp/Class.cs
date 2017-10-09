using System;

namespace SchoolApp
{
	internal class Class : IComparable<Class>
	{
		public string namn;
		public int antalelever;

		public Class(string namn, int antalelever)
		{
			this.namn = namn;
			this.antalelever = antalelever;
		}

		public int CompareTo(Class other)
		{
			return this.antalelever.CompareTo(other.antalelever);

		}

	}

}
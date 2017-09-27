using System.Collections.Generic;
using System.Linq;

namespace SchoolApp
{
	internal class School
	{
		private string namn;


		public School(string namn)
		{
			this.namn = namn;
		}

		public List<Class> Classer { get; internal set; }
		= new List<Class>();



		public int NumberOfStudents
		{
			get
			{
				return Classer.Sum(klass => klass.antalelever);
			}
		}
		

		public override string ToString()
		{
			return namn + " har " + NumberOfStudents.ToString() + " studenter. ";
		}
	}
}
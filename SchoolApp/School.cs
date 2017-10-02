using System.Collections.Generic;
using System.Linq;
using System.Text;

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

		//public int nStudentsPerClass
		//{
		//	get
		//	{
		//		return Classer.Select(klass => klass.antalelever);
		//	}
		//}

		//public int NumberOfStudentsPerClass => Classer.Where(C => C.antalelever);

		public int AntalClasser
		{
			get
			{
				return Classer.Count();
			}
		}

		public string antalStudenterPerClass
		{
			get
			{
				var sb = new StringBuilder();
				Classer.ForEach(c => sb.Append(c.antalelever.ToString() + " "));
				return sb.ToString();
			}
		}		

		public override string ToString()
		{
			return namn + " har " + NumberOfStudents.ToString() + " studenter. " + AntalClasser + " " + antalStudenterPerClass;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
	public class Ansvar
	{
		public string namn;
		public Part ansvarig;
		public Part komissionär;
		private Part someCompany;
		private Part mattiasAsplund;
		private string roleName;

		public Ansvar(Part komissionär, Part ansvarig, string roleName)
		{
			this.komissionär = komissionär;
			this.ansvarig = ansvarig;
			this.roleName = roleName;
		}

		public override string ToString()
		{
			return $"{this.ansvarig.Namn}, {this.roleName} på {this.komissionär.Namn}"; 
		}
	}
}

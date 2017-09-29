using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    public class Part
    {
		public Part(string namn, string juridisktID)
		{
			this.Namn = namn;
			this.JuridisktID = juridisktID;
		}

		public string Namn { get; set; }
		public string JuridisktID { get; set; }

		public override string ToString()
		{
			return $"{Namn} ({JuridisktID})";
		}
	}
}

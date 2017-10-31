using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FilerTill3
{
    public class Class1
    {
		string input1 = "12.50\n17.50";
		string input2 = "2\n10";
		string output = "";
		string expected = " 12,50 x 2 = 25,00\n 12,50 x 10 = 125,00\n 17,50 x 2 = 35,00\n17,50 x 10 = 175,00";
		Assert.AreEqual(expected, output);
    }
}

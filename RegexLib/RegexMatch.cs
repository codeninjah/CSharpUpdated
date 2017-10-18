using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLib
{
    public class RegexMatch
    {
		public int CountMatching(string content, string regexPattern)
		{
			using (var reader = new StringReader(content))
			{ reader.ReadLine(); }

			string pattern = @"#VER";

			return int.Parse(content);
		}
    }
}

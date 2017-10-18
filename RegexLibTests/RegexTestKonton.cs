using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using RegexLib;

namespace RegexLibTests
{
	[TestClass]
	public class RegexTestKonton
	{
		private object streamReader;

		[TestMethod]
		public void TestMethod1()
		{

			var sut = new RegexMatch();
			var streamReader = File.OpenText(@"SIERedovisning.txt");
			var content = File.ReadAllText(@"SIERedovisning.txt");
			//File.ReadAllText
			string pattern = @"#VER";
			//var content = streamReader.ReadLine();
			var match = Regex.Match(content, pattern);
			sut.CountMatching(content, pattern);

			if (match.Success)
				Debug.WriteLine(content);

		}
	}
}

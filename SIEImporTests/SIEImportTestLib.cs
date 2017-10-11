using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;

namespace SIEImporTests
{
	[TestClass]
	public class SIEImportTestLib
	{
		[TestMethod]
		public void CanRead()
		{
			Dictionary<string, decimal> accounts = new Dictionary<string, decimal>();
			var streamReader = File.OpenText(@"SIERedovisning.txt");
			while(true)
			{
				var line = streamReader.ReadLine();
				if (line == null)
					break;
				string pattern = @"#TRANS (\d{4}) {} (-?\d*.\d*)";
				var match = Regex.Match(line, pattern);
				if (match.Success)
				{
					var accountId = match.Groups[1].Value;
					var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
					if (accounts.ContainsKey(accountId))
						accounts[accountId] += amount;
					else
						accounts[accountId] = amount;
				}

			}
			//foreach(var entry in accounts.OrderBy(e => e.Key))
			foreach (var entry in accounts)
			{
				//F2 = "Fixed number of decimal points"
				Debug.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");
			}

		}
	}
}

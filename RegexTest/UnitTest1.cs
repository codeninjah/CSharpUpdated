using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using EmployeeLib;

namespace RegexTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void RegexTest()
		{
			
			string input = @"""Mattias Asplund"" 46 35000.00 070-6186120 ";


			EmployeeConverter sut = new EmployeeConverter();
			var results = sut.Convert(input);


		}
	}
}

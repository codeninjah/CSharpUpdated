using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;

namespace PartTest
{
	[TestClass]
	public class PartTests
	{
		[TestMethod]
		public void CorrectToString()
		{
			var sut = new Part("Mattias Asplund", "19710405-7852");

			Assert.AreEqual("Mattias Asplund (19710405-7852)", sut.ToString());
		}
	}
}

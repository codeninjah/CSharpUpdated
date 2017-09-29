using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;


namespace PartTest
{
	[TestClass]
	public class AnsvarigTests
	{
		[TestMethod]
		public void CorrectToString()
		{
			var mattiasAsplund = new Part("Mattias Asplund", "01010101-0101");
			var someCompany = new Part("Some Company AB", "123456-7890");
			var sut = new Ansvar(someCompany, mattiasAsplund, "VD");

			Assert.AreEqual("Mattias Asplund, VD på Some Company AB", sut.ToString());
		}
	}
}

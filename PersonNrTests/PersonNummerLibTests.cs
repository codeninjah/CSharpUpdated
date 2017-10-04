using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonNrApp;

namespace PersonNrTests
{
	[TestClass]
	public class PersonNummerLibTests
	{
		[TestMethod]
		public void Man()
		{
			var sut = new Form1();
			var personnummer = "710405-7851";
			sut.EnterDetails("Mattias", "Asplund", personnummer);
			var expected = "God morgon herr Asplund";
			Assert.AreEqual(expected, sut.Greeting);
		}
		[TestMethod]
		public void Kvinna()
		{
			var sut = new Form1();
			var personnummer = "711207-9228";
			sut.EnterDetails("Jazmina", "Asplund", personnummer);
			var expected = "God morgon fröken Asplund";
			Assert.AreEqual(expected, sut.Greeting);
		}
	}
}

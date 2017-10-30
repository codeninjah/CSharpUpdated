using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeApp;
using PracticeLib;

namespace PracticeTestsLib
{
	[TestClass]
	public class Tester
	{
		[TestMethod]
		public void TestNameAndPhoneNumber()
		{
			Class1 sut = new Class1();
			var result = sut.delaString("Mattias;1917-05-01;0706186120");
			Assert.AreEqual(result, $"{sut.nameString} är {sut.yearsskillnad} år gammal och har telefonnummret {sut.telefonnummer}" + "\n");
			//var expected



		}
	}
}

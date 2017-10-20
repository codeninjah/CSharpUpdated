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
		public void TestMethod1()
		{
			Class1 sut = new Class1();
			var result = sut.delaString("Mattias 0706186120");
			Assert.AreEqual(result, $"{sut.nameString} har telefonnummret {sut.telefonnummer} \n");
			//var expected



		}
	}
}

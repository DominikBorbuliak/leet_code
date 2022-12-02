using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class RomanToIntegerSolutionTests
	{
		[DataTestMethod]
		[DataRow("I", 1)]
		[DataRow("II", 2)]
		[DataRow("III", 3)]
		[DataRow("IV", 4)]
		[DataRow("V", 5)]
		[DataRow("VI", 6)]
		[DataRow("VII", 7)]
		[DataRow("VIII", 8)]
		[DataRow("IX", 9)]
		[DataRow("X", 10)]
		[DataRow("LIV", 54)]
		[DataRow("LVIII", 58)]
		[DataRow("MCMXCIV", 1994)]
		public void RomanToIntTest(string input, int expected)
		{
			var actual = RomanToIntegerSolution.RomanToInt(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
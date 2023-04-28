using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class LengthOfLastWordSolutionTests
	{
		[DataTestMethod]
		[DataRow("Hello World", 5)]
		[DataRow("   fly me   to   the moon  ", 4)]
		[DataRow("luffy is still joyboy", 6)]
		[DataRow("word", 4)]
		[DataRow("    word    ", 4)]
		[DataRow("    i    ", 1)]
		[DataRow("i", 1)]
		public void LengthOfLastWordTest(string input, int expected)
		{
			var actual = LengthOfLastWordSolution.LengthOfLastWord(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
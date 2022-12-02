using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class LongestCommonPrefixSolutionTests
	{
		[DataTestMethod]
		[DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
		[DataRow(new string[] { "dog", "racecar", "car" }, "")]
		[DataRow(new string[] { "flower", "flower", "flower" }, "flower")]
		[DataRow(new string[] { "", "", "" }, "")]
		public void LongestCommonPrefixTest(string[] input, string expected)
		{
			var actual = LongestCommonPrefixSolution.LongestCommonPrefix(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
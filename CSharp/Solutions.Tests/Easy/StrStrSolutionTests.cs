using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class StrStrSolutionTests
	{
		[DataTestMethod]
		[DataRow("sadbutsad", "sad", 0)]
		[DataRow("leetcode", "leeto", -1)]
		[DataRow("sadbuttrue", "true", 6)]
		[DataRow("bbeststory", "best", 1)]
		public void StrStrTest(string haystack, string needle, int expected)
		{
			var actual = StrStrSolution.StrStr(haystack, needle);

			Assert.AreEqual(expected, actual);
		}
	}
}
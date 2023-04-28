using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class SearchInsertSolutionTests
	{
		[DataTestMethod]
		[DataRow(new int[] { 1, 3, 5, 6 }, 5, 2)]
		[DataRow(new int[] { 1, 3, 5, 6 }, 2, 1)]
		[DataRow(new int[] { 1, 3, 5, 6 }, 7, 4)]
		[DataRow(new int[] { 1, 3, 5, 6 }, 0, 0)]
		[DataRow(new int[] { 1, 3, 5, 6 }, 6, 3)]
		public void SearchInsertTest(int[] array, int target, int expected)
		{
			var actual = SearchInsertSolution.SearchInsert(array, target);

			Assert.AreEqual(expected, actual);
		}
	}
}
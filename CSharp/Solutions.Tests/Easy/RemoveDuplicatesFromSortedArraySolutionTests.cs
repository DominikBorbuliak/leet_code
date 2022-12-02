using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass()]
	public class RemoveDuplicatesFromSortedArraySolutionTests
	{
		[DataTestMethod]
		[DataRow(new int[] { 1, 1, 2}, new int[] { 1, 2 })]
		[DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
		public void RemoveDuplicatesTest(int[] input, int[] expected)
		{
			int k = RemoveDuplicatesFromSortedArraySolution.RemoveDuplicates(input);

			Assert.AreEqual(expected.Length, k);

			for (var i = 0; i < k; i++)
				Assert.AreEqual(expected[i], input[i]);
		}
	}
}
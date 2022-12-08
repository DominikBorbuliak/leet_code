using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class RemoveElementSolutionTests
	{
		[DataTestMethod]
		[DataRow(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
		[DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 0, 1, 3, 4 })]
		[DataRow(new int[] { }, 0, new int[] { })]
		[DataRow(new int[] { 2 }, 3, new int[] { 2 })]
		public void RemoveElementTest(int[] input, int valueToRemove, int[] expected)
		{
			int k = RemoveElementSolution.RemoveElement(input, valueToRemove);

			Assert.AreEqual(expected.Length, k);
			Array.Sort(input, 0, k);

			for (var i = 0; i < k; i++)
				Assert.AreEqual(expected[i], input[i]);
		}
	}
}
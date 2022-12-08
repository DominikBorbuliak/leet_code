using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass]
	public class MergeTwoSortedListsSolutionTests
	{
		[DataTestMethod]
		[DataRow(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
		[DataRow(new int[] { }, new int[] { }, new int[] { })]
		[DataRow(new int[] { }, new int[] { 0 }, new int[] { 0 })]
		public void MergeTwoListsTest(int[] array1, int[] array2, int[] expected)
		{
			var list1 = ConvertToList(array1);
			var list2 = ConvertToList(array2);

			var actual = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

			Assert.AreEqual(expected.ToString(), ConvertToArray(actual).ToString());
		}

		/// <summary>
		/// Converts array to Linked List
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		private static MergeTwoSortedListsSolution.ListNode? ConvertToList(int[] array)
		{
			MergeTwoSortedListsSolution.ListNode? firstNode = null;
			MergeTwoSortedListsSolution.ListNode? prevNode = null;

			foreach (var item in array)
			{
				var actualNode = new MergeTwoSortedListsSolution.ListNode(item);

				if (firstNode == null)
					firstNode = actualNode;

				if (prevNode != null)
					prevNode.next = actualNode;

				prevNode = actualNode;
			}

			return firstNode;
		}

		/// <summary>
		/// Converts Linked List to array
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		private static int[] ConvertToArray(MergeTwoSortedListsSolution.ListNode? node)
		{
			var result = new List<int>();

			while (node != null)
			{
				result.Add(node.val);
				node = node.next;
			}

			return result.ToArray();
		}
	}
}
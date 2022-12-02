namespace Solutions.Easy
{
	public static class MergeTwoSortedListsSolution
	{
		public class ListNode {
			public int val;
			public ListNode? next;

			public ListNode(int val = 0, ListNode? next = null) {
				this.val = val;
				this.next = next;
			}
		}

		/// <summary>
		/// https://leetcode.com/problems/merge-two-sorted-lists/
		/// </summary>
		/// <param name="list1"></param>
		/// <param name="list2"></param>
		/// <returns></returns>
		public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
		{
			if (list1 == null && list2 == null)
				return null;

			var node = new ListNode();
			var nextList1 = list1;
			var nextList2 = list2;

			if (list1 != null)
			{
				node.val = list1.val;
				nextList1 = list1.next;
			}

			if (list2 != null && (list1 == null || list2.val < list1.val))
			{
				node.val = list2.val;
				nextList2 = list2.next;
				nextList1 = list1;
			}

			node.next = MergeTwoLists(nextList1, nextList2);

			return node;
		}
	}
}

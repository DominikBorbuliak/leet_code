using System.ComponentModel.DataAnnotations;

namespace Solutions.Easy
{
	public static class SearchInsertSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/search-insert-position/
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int SearchInsert(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;
			var center = 0;

			while (left <= right)
			{
				center = (left + right) / 2;

				if (target == nums[center])
				{
					return center;
				}

				if (target < nums[center])
				{
					right = center - 1;
				}
				else
				{
					left = center + 1;
				}
			}

			if (nums[center] < target) {
				return center + 1;
			}

			return center;
		}
	}
}

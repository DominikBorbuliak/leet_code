namespace Solutions.Easy
{
	public static class RemoveDuplicatesFromSortedArraySolution
	{
		/// <summary>
		/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public static int RemoveDuplicates(int[] nums)
		{
			var index = 1;

			for (var i = 1; i < nums.Length; i++)
			{
				if (nums[index - 1] != nums[i])
				{
					nums[index] = nums[i];
					index++;
				}
			}

			return index;
		}
	}
}

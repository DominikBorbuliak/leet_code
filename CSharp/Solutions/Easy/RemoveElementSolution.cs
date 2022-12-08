namespace Solutions.Easy
{
	public class RemoveElementSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/remove-element/
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static int RemoveElement(int[] nums, int val)
		{
			if (!nums.Any())
				return 0;

			var end = nums.Length - 1;

			for (var i = 0; i < end; i++)
				if (nums[i] == val)
				{
					if (nums[end] == val)
					{
						end--;
						i--;
					}
					else
						(nums[i], nums[end]) = (nums[end], nums[i]);
				}

			return nums[end] == val ? end : end + 1;
		}
	}
}

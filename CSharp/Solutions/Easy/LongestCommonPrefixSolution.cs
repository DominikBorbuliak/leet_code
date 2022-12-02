namespace Solutions.Easy
{
	public static class LongestCommonPrefixSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/longest-common-prefix/
		/// </summary>
		/// <param name="strs"></param>
		/// <returns></returns>
		public static string LongestCommonPrefix(string[] strs)
		{
			var result = string.Empty;
			var index = 0;

			while (HasCommonLetter(strs, index))
			{
				result += strs[0][index];
				index++;
			}

			return result;
		}

		/// <summary>
		/// Checks whether all strings in array have same character at index
		/// </summary>
		/// <param name="strs"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		private static bool HasCommonLetter(string[] strs, int index)
		{
			for (var i = 0; i < strs.Length; i++)
			{
				if (index >= strs[i].Length)
					return false;

				if (!strs[0][index].Equals(strs[i][index]))
					return false;
			}

			return true;
		}
	}
}

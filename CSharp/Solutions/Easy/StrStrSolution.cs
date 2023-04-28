namespace Solutions.Easy
{
	public static class StrStrSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
		/// </summary>
		/// <param name="haystack"></param>
		/// <param name="needle"></param>
		/// <returns></returns>
		public static int StrStr(string haystack, string needle)
		{

			for (var i = 0; i < haystack.Length; i++)
			{
				if (haystack[i] == needle[0])
				{
					if (CheckNeedle(haystack, needle, i))
					{
						return i;
					}
				}
			}

			return -1;
		}

		private static bool CheckNeedle(string haystack, string needle, int startIdx)
		{
			for (var i = 1; i < needle.Length; i++)
			{
				if (startIdx + i >= haystack.Length)
				{
					return false;
				}

				if (haystack[startIdx + i] != needle[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}

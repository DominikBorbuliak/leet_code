using System.Text.RegularExpressions;

namespace Solutions.Easy
{
	public static class LengthOfLastWordSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/length-of-last-word/
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int LengthOfLastWord(string s)
		{
			var length = 0;

			for (var i = 0; i < s.Length; i++)
			{
				if (length != 0 && s[i] != ' ' && s[i - 1] == ' ')
				{
					length = 1;
				}
				else if (s[i] != ' ')
				{
					length++;
				}
			}

			return length;
		}
	}
}

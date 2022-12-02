namespace Solutions.Easy
{
	public static class RomanToIntegerSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/roman-to-integer/
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int RomanToInt(string s)
		{
			var value = 0;
			var lastCharValue = 0;

			for (var i = 0; i < s.Length; i++)
			{
				var currentChar = s[i];
				var currentCharValue = GetRomanCharValue(currentChar);

				if (lastCharValue < currentCharValue)
					value = value - 2 * lastCharValue + currentCharValue;
				else
					value += currentCharValue;

				lastCharValue = currentCharValue;
			}

			return value;
		}

		/// <summary>
		/// Returns value of one roman character
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		private static int GetRomanCharValue(char character)
		{
			return character switch
			{
				'I' => 1,
				'V' => 5,
				'X' => 10,
				'L' => 50,
				'C' => 100,
				'D' => 500,
				'M' => 1000,
				_ => 0,
			};
		}
	}
}

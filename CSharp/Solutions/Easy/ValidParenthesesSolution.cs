namespace Solutions.Easy
{
	public class ValidParenthesesSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/valid-parentheses/
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static bool IsValid(string s)
		{
			var stack = new Stack<char>();

			foreach (var parenthese in s)
			{
				var isCloseParenthese = IsCloseParenthese(parenthese);

				if (isCloseParenthese && stack.Count == 0)
					return false;

				if (isCloseParenthese)
				{
					var prevParenthese = stack.Pop();

					if (GetCorrespondingCloseParenthese(prevParenthese) != parenthese)
						return false;
				}
				else
					stack.Push(parenthese);
			}

			return stack.Count == 0;
		}

		/// <summary>
		/// Determines whether parenthese is close
		/// </summary>
		/// <param name="parenthese"></param>
		/// <returns></returns>
		public static bool IsCloseParenthese(char parenthese) => parenthese == ')' || parenthese == ']' || parenthese == '}';

		/// <summary>
		/// Returns corresponding close parenthese to provided open parenthese
		/// </summary>
		/// <param name="parenthese"></param>
		/// <returns></returns>
		public static char GetCorrespondingCloseParenthese(char parenthese)
		{
			return parenthese switch
			{
				'(' => ')',
				'[' => ']',
				'{' => '}',
				_ => parenthese
			};
		}
	}
}

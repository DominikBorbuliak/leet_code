using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.Easy.Tests
{
	[TestClass()]
	public class ValidParenthesesSolutionTests
	{
		[DataTestMethod]
		[DataRow("", true)]
		[DataRow("()", true)]
		[DataRow("()[]{}", true)]
		[DataRow("([{}])", true)]
		[DataRow("({})[][[]]", true)]
		[DataRow("(]", false)]
		[DataRow("([{}]}", false)]
		[DataRow("([{}]))", false)]
		[DataRow("(([{}])", false)]
		public void IsValidTest(string input, bool expected)
		{
			var actual = ValidParenthesesSolution.IsValid(input);

			Assert.AreEqual(expected, actual);
		}
	}
}
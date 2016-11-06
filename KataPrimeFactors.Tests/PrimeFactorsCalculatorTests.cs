using System.Collections.Generic;

using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsCalculatorTests
    {
		[TestCase(1)]
		[TestCase(2, 2)]
		public void OneHasNoPrimeFactors(int number, params int[] factors)
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int>();
			expectedResult.AddRange(factors);

			var actualResult = calculator.Calculate(number);

			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}
	}
}

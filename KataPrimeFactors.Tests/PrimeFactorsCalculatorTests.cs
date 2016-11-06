using System.Collections.Generic;

using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsCalculatorTests
    {
		[Test]
		public void OneHasNoPrimeFactors()
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int>();

			var actualResult = calculator.Calculate(1);

			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}

		[Test]
		public void ThePrimeFactorOfTwoIsTwo()
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int> {2};

			var actualResult = calculator.Calculate(2);

			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}
	}
}

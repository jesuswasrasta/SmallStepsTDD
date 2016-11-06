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
			
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void PrimeFactorOfTwoIsTwo()
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int> {2};
			var actualResult = calculator.Calculate(2);
			
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}

using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsCalculatorTests
    {
		[Test]
		public void OneHasNoPrimeFactors()
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List();

			var actualResult = calculator.Calculate(1);

			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}
	}
}

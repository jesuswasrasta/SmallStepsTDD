using System.Collections.Generic;

using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsCalculatorTests
    {
		[TestCase(1)]
		[TestCase(2, 2)]
		public void OneHasNoPrimeFactors(int number, params int[] numbers)
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int>();
			//if (numbers != null)
			{
				expectedResult.AddRange(numbers);
			}

			var actualResult = calculator.Calculate(number);
			
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}

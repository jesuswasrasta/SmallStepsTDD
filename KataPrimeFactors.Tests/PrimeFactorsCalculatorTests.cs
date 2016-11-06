using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
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
	}
}

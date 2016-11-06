﻿using System.Collections.Generic;

using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsCalculatorTests
	{
		[TestCase(1)]
		[TestCase(2, 2)]
		[TestCase(3, 3)]
		[TestCase(4, 2, 2)]
		[TestCase(5, 5)]
		[TestCase(6, 3, 2)]
		[TestCase(7, 7)]
		[TestCase(8, 2, 2, 2)]
		[TestCase(9, 3, 3)]
		[TestCase(2 * 2 * 3 * 3 * 5 * 7 * 11 * 13, 2, 2, 3, 3, 5, 7, 11, 13)]
		public void PrimeFactorsTests(int number, params int[] factors)
		{
			var calculator = new PrimeFactorsCalculator();
			var expectedResult = new List<int>();
			expectedResult.AddRange(factors);

			var actualResult = calculator.Calculate(number);

			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}
	}
}
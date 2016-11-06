using System.Collections.Generic;


namespace KataPrimeFactors
{
	public class PrimeFactorsCalculator
	{
		public List<int> Calculate(int number)
		{
			var factors = new List<int>();
			if (number > 1)
			{
				factors.Add(2);
			}
			return factors;
		}
	}
}
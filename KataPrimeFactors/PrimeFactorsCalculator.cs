using System.Collections.Generic;


namespace KataPrimeFactors
{
	public class PrimeFactorsCalculator
	{
		public List<int> Calculate(int n)
		{
			var factors = new List<int>();
			if (n > 1)
			{
				factors.Add(n);
			}
			return factors;
		}
	}
}
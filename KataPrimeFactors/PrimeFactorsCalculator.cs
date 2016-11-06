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
				while (n % 2 == 0)
				{
					factors.Add(2);
					n /= 2;
				}
				while (n % 3 == 0)
				{
					factors.Add(3);
					n /= 3;
				}
			}
			if (n > 1)
			{
				factors.Add(n);
			}
			return factors;
		}
	}
}
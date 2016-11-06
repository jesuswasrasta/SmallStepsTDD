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
				if (n % 2 == 0)
				{
					factors.Add(2);
					n /= 2;
				}
				if (n > 1)
				{
					factors.Add(n);
				}
			}

			return factors;
		}
	}
}
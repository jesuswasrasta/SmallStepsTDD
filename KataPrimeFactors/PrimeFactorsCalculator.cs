using System.Collections.Generic;


namespace KataPrimeFactors
{
	public class PrimeFactorsCalculator
	{
		public List<int> Calculate(int n)
		{
			var factors = new List<int>();
			var divisor = 2;
			while (n > 1)
			{
				while (n % divisor == 0)
				{
					factors.Add(divisor);
					n /= divisor;
				}
				divisor++;
			}
			if (n > 1)
			{
				factors.Add(n);
			}
			return factors;
		}
	}
}
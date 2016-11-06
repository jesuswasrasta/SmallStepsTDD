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
				for (; n % divisor == 0; n /= divisor)
				{
					factors.Add(divisor);
				}
				divisor++;
			}
			return factors;
		}
	}
}
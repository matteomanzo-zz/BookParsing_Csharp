using System;

namespace BookParsing
{
	public class PrimeNumber
	{
		private bool IsAPrimeNumber (int num)
		{
			if (num == 2) return true;

			if ((num == 1) || (num % 2 == 0)) return false;
				
			for (int n = 3; n < num; n += 2) {
				if (num % n == 0) return false;
			}
			return true;
		}

		public bool IsPrime (int num)
		{
			return IsAPrimeNumber(num);
		}
	}
}


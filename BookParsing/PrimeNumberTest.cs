using System;
using NUnit.Framework;

namespace BookParsing
{
	[TestFixture()]
	public class PrimeNumberTest
	{
		[Test()]
		public void ItShouldCheckIfANumberIsPrime ()
		{
			PrimeNumber number = new PrimeNumber ();
			Assert.IsTrue (number.IsPrime (76543));
			Assert.IsTrue (number.IsPrime (2));
			Assert.IsFalse (number.IsPrime (1));
			Assert.IsFalse (number.IsPrime (2050));
		}
	}
}


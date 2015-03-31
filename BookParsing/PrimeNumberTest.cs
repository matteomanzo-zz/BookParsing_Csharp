using System;
using NUnit.Framework;

namespace BookParsing
{
	[TestFixture()]
	public class PrimeNumberTest
	{
		PrimeNumber number;

		[SetUp()]
		public void Init()
		{
			number = new PrimeNumber();
		}

		[Test()]
		public void ItShouldReturnTrueIfANumberIsPrime ()
		{
			Assert.IsTrue (number.IsPrime (76543));
			Assert.IsTrue (number.IsPrime (2));
		}

		[Test()]
		public void ItShouldReturnFalseIfANumberIsNotPrime ()
		{
			Assert.IsFalse (number.IsPrime (1));
			Assert.IsFalse (number.IsPrime (2050));
		}
	}
}


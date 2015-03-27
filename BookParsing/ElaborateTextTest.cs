using NUnit.Framework;
using System;

namespace BookParsing
{
	[TestFixture ()]
	public class ElaborateTextTest
	{
		[Test ()]
		public void ItShouldStripPunctuationAndNumbers ()
		{
			ElaborateText file = new ElaborateText ();
			Assert.AreEqual ("I like  code", file.StripText("I, like 2 code."));
		}
	}
}


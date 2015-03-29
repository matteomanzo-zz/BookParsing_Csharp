using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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

		[Test()]
		public void ItShouldSplitWordsAndListThem ()
		{
			ElaborateText file = new ElaborateText ();
			var result = file.SplitWords("I like to learn");
			Assert.That (result, Has.Member("I"));
			Assert.That (result, Has.Member("like"));
			Assert.That (result, Has.No.Member("to learn"));
		}
	}
}


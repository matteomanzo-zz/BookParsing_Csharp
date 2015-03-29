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

		[Test()]
		public void ItShouldReturnTheTimesWordsAppear ()
		{
			ElaborateText file = new ElaborateText ();
			List<string> TestList = "Hey I know you Hey you know how to code".Split (' ').ToList ();
			Dictionary<string, int> TestDictionary = file.CountWords (TestList);
			foreach (KeyValuePair<string, int> word in TestDictionary) {
				Assert.AreEqual (TestDictionary ["Hey"], 2 );
				Assert.AreEqual (TestDictionary ["know"], 2);
				Assert.AreEqual (TestDictionary ["you"], 2);
				Assert.AreEqual (TestDictionary ["how"], 1);
				Assert.AreEqual (TestDictionary ["code"], 1);
				Assert.AreNotEqual (TestDictionary ["to"], 2);
			}
		}
	}
}


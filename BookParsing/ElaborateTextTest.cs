using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace BookParsing
{
	[TestFixture ()]
	public class ElaborateTextTest
	{
		ElaborateText text;

		[SetUp()]
		public void Init()
		{
			text = new ElaborateText();
		}

		[Test ()]
		public void ItShouldStripPunctuationAndNumbers ()
		{
			Assert.AreEqual ("i like  code", text.StripText("I, like 2 code."));
		}

		[Test()]
		public void ItShouldSplitWordsAndListThem ()
		{
			var result = text.SplitWords("I like to learn");
			Assert.That (result, Has.Member("like"));
		}

		[Test()]
		public void ItShouldNotLeaveWordsTogether ()
		{
			var result = text.SplitWords("I like to learn");
			Assert.That (result, Has.No.Member("to learn"));
		}

		[Test()]
		public void ItShouldReturnTheRightTimesWordsAppear ()
		{
			List<string> TestList = "Hey I know you Hey you know how to code".Split (' ').ToList ();
			Dictionary<string, int> TestDictionary = text.CountWords (TestList);
			foreach (KeyValuePair<string, int> word in TestDictionary) {
				Assert.AreEqual (TestDictionary ["Hey"], 2);
			}
		}

		[Test()]
		public void ItShouldNotReturnTheWrongTimesWordsAppear ()
		{
			List<string> TestList = "Hey I know you Hey you know how to code".Split (' ').ToList ();
			Dictionary<string, int> TestDictionary = text.CountWords (TestList);
			foreach (KeyValuePair<string, int> word in TestDictionary) {
				Assert.AreNotEqual (TestDictionary ["to"], 2);
			}
		}
	}
}


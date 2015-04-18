using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace BookParsing
{
	[TestFixture ()]
	public class ExtractWordsTest
	{
		ExtractWords text;

		[SetUp()]
		public void Init()
		{
			text = new ExtractWords();
		}

		[Test ()]
		public void ItShouldStripPunctuationAndNumbers ()
		{
			Assert.AreEqual ("i  like   code ", text.StripText("I, like 2 code."));
		}

		[Test()]
		public void ItShouldSplitWords ()
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
			string[] testArray = "Hey I know you Hey you know how to code".Split (' ');
			Dictionary<string, int> testDictionary = text.CountWords (testArray);
			foreach (KeyValuePair<string, int> word in testDictionary) {
				Assert.AreEqual (testDictionary ["Hey"], 2);
			}
		}

		[Test()]
		public void ItShouldNotReturnTheWrongTimesWordsAppear ()
		{
			string[] testArray = "Hey I know you Hey you know how to code".Split (' ');
			Dictionary<string, int> testDictionary = text.CountWords (testArray);
			foreach (KeyValuePair<string, int> word in testDictionary) {
				Assert.AreNotEqual (testDictionary ["to"], 2);
			}
		}
	}
}

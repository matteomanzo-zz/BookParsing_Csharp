using System;

namespace BookParsing
{
	public class ElaborateText
	{
		public string StripText (string input)
		{
			string[] CharsToRemove = { ";", ",", ".", "'", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };
			foreach(string character in CharsToRemove)
			{
				input = input.Replace(character, "");
			}
			return input;
		}
	}
}


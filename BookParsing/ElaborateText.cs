using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace BookParsing
{
	public class ElaborateText
	{
		public string StripText (string input)
		{
			input = input.ToLower ();
			string charsToRemove = @"[\W]";
			Regex rgx = new Regex (charsToRemove);
			string replace = " ";
			string result = rgx.Replace (input, replace);
			return result;
		}

		public string[] SplitWords (string input)
		{
			string[] wordArray = input.Split (' ');
			return wordArray;
		}

		public Dictionary<string, int> CountWords (string[] array)
		{
			Dictionary<string, int> wordDictionary = new Dictionary<string, int> ();
			foreach (string  word in array) {
				if (word.Length >= 2) {
					if (wordDictionary.ContainsKey (word)) {
						wordDictionary [word]++;
					} else {
						wordDictionary [word] = 1;
					}
				}
			}
			return wordDictionary;
		}
	}
}
	
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
			string CharsToRemove = @"[\W]";
			Regex rgx = new Regex (CharsToRemove);
			string replace = " ";
			string result = rgx.Replace (input, replace);
			return result;
		}

		public List<string> SplitWords (string input)
		{
			List<string> WordList = input.Split (' ').ToList ();
			return WordList;
		}

		public Dictionary<string, int> CountWords (List<string> list)
		{
			Dictionary<string, int> WordDictionary = new Dictionary<string, int> ();
			foreach (string  word in list) {
				if (word.Length >= 2) {
					if (WordDictionary.ContainsKey (word)) {
						WordDictionary [word]++;
					} else {
						WordDictionary [word] = 1;
					}
				}
			}
			return WordDictionary;
		}
	}
}
	
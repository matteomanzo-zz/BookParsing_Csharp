using System;
using System.Collections.Generic;
using System.IO;

namespace BookParsing
{
	public class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program ();
			string input = program.ReadFromFile ();
			program.PrintOnScreen(input);
		}

		public string ReadFromFile()
		{
			string input = Console.ReadLine ();
			if (File.Exists(input)) input = File.ReadAllText (input);
			return input;
		}

		public void PrintOnScreen(string input)
		{
			ElaborateText file = new ElaborateText ();
			PrimeNumber number = new PrimeNumber ();
			input = file.StripText (input);
			List<string> wordList = file.SplitWords (input);
			Dictionary<string, int> count = file.CountWords (wordList);
			foreach (KeyValuePair<string, int> word in count) {
				string prime = "";
				if (number.IsPrime (word.Value)) {
					prime = "√";
				} else {
					prime = "x";
				}
				Console.Write (word.Key + "\t" + "\t" + "  times: " + word.Value + "\t" + "prime: " + prime + "\n");
			}
		}

	}
}
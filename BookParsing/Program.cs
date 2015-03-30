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
			string text = program.ReadFromFile ();
			program.PrintOnScreen(program.Elaborate(text));
		}

		public string ReadFromFile()
		{
			string input = Console.ReadLine ();
			if (File.Exists(input)) input = File.ReadAllText (input);
			return input;
		}

		public Dictionary<string, int> Elaborate(string input)
		{
			ElaborateText file = new ElaborateText ();
			input = file.StripText (input);
			List<string> wordList = file.SplitWords (input);
			Dictionary<string, int> count = file.CountWords (wordList);
			return count;
		}

		public void PrintOnScreen(Dictionary<string, int> input)
		{
			PrimeNumber number = new PrimeNumber ();
			foreach (KeyValuePair<string, int> word in input) {
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
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
			Console.WriteLine ("Type some text or a file name (it has to be inside the folder): ");
			string input = Console.ReadLine ();
			if (File.Exists(input)) input = File.ReadAllText (input);
			return input;
		}

		public Dictionary<string, int> Elaborate(string input)
		{
			ElaborateText file = new ElaborateText ();
			input = file.StripText (input);
			string[] wordArray = file.SplitWords (input);
			Dictionary<string, int> count = file.CountWords (wordArray);
			return count;
		}

		public void PrintOnScreen(Dictionary<string, int> input)
		{
			PrimeNumber number = new PrimeNumber ();
			foreach (KeyValuePair<string, int> word in input) {
				string prime = (number.IsPrime (word.Value)) ? "√" : "x" ;
				string space = (word.Key.Length >= 8) ? "\t \t": "\t \t \t";
				Console.Write (word.Key + space + "  times: " + word.Value + "\t" + "prime: " + prime + "\n");
			}
		}
	}
}
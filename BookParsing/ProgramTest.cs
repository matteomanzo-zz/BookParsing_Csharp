using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BookParsing
{
	[TestFixture ()]
	public class ProgramTest
	{		
		Program program;

		[SetUp()]
		public void Init()
		{
			program = new Program();
		}
			
		[Test()]
		public void ItShouldPrintAnInitialMessageOnScreen()
		{
			StringWriter output = new StringWriter();
			Console.SetOut(output);
			program.ReadFromFile ();
			Assert.AreEqual ("Type some text or a file name (it has to be inside the folder): \n", output.ToString ());
		}
			
		[Test()]
		public void ItShouldReturnTheRightOutputOnTheConsole()
		{
			StringWriter output = new StringWriter();
			Console.SetOut(output);
			program.PrintOnScreen (program.Elaborate ("hello, hello."));
			Assert.AreEqual ("hello\t \t \t  times: 2\tprime: √\n", output.ToString ());
		}
	}
}


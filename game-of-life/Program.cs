using System;
using System.Threading;

namespace gameoflife
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			UInt16 lol = 0;
			while (lol != 70) 
			{
				evaluation.displayGrid (gameRules.grid);
				Thread.Sleep (300);
				for (int i = 0; i < 128; i++) 
				{
					Console.Write (Environment.NewLine);
				}

				evaluation.evaluateGrid (gameRules.grid);
				lol++;
			}
			Console.WriteLine ("Stopped after 70 evaluations.");
		}
	}
}

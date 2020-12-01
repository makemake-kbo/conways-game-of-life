using System;
using System.Threading;

namespace gameoflife
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			while (true) 
			{
				evaluation.displayGrid (gameRules.grid);
				Thread.Sleep (300);
				for (int i = 0; i < 128; i++) 
				{
					Console.Write (Environment.NewLine);
				}

				evaluation.evaluateGrid (gameRules.grid);
			}
		}
	}
}

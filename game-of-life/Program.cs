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
				Thread.Sleep(1000);
				for (int i = 0; i < 128; i++) 
				{
					Console.Write(Environment.NewLine);
				}
			}
		}
	}
}

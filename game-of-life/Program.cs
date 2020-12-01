using System;

namespace gameoflife
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			while (true) 
			{
				evaluation.displayGrid (gameRules.grid);
				for (int i = 0; i < 128; i++) 
				{
					Console.Write(Environment.NewLine + Environment.NewLine);
				}
			}
		}
	}
}

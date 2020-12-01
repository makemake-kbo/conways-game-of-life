using System;

namespace gameoflife
{
	public class evaluation : gameRules
	{
		public static void evaluateGrid(int[,] grid){
			for (int x = 0; x < grid.GetLength(0); x++) {
				for (int y = 0; y < grid.GetLength(1); y++) {
					int count = grid [x, y];
					if (!((x-1) < 0)) {
						count = count + grid[x-1, y];
					}
					if (!((y-1) < 0)) {
						count = count + grid[x, y-1];
					}
					if (!((y-1) < 0) && !((x-1) < 0)) {
						count = count + grid[x-1,y-1];
					}
					if (x+1 < grid.GetLength(0)) {
						count = count + grid[x+1, y];
					}
					if (y+1 < grid.GetLength(1)) {
						count = count + grid[x, y+1];
					}
					if (y+1 < grid.GetLength(1) && x+1 < grid.GetLength(0)) {
						count = count + grid[x+1, y+1];
					}
					if (x+1 < grid.GetLength(0) && !((y-1) < 0)) {
						count += grid[x+1, y-1];
					}
					if (y+1 < grid.GetLength(1) && !((x-1) < 0)) {
						count += grid[x-1, y+1];
					}
					gameRules.grid[x, y] = isAlive (gameRules.grid[x, y], count);
				}
			}
		}

		public static void displayGrid(int[,] grid) {
			for (int x = 0; x < grid.GetLength(0); x++) {
				for (int y = 0; y < grid.GetLength(1); y++) {
					Console.Write (string.Format("{0} ", grid[x, y]));
				}
				Console.Write (Environment.NewLine);
			}
		}

	}
}

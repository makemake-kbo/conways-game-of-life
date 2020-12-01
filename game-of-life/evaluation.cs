using System;

namespace gameoflife
{
	public class evaluation : gameRules
	{
		public void evaluateGrid(int[,] grid){
			for (int x = 0; x < grid.GetLength(0); x++) {
				for (int y = 0; y < grid.GetLength(1); y++) {
					int count = grid[x, y]
              					+ grid[x, y+1]
              					+ grid[x+1, y]
              					+ grid[x+1, y+1];
              		if (!((x-1) < 0)) {
              			count = count + grid[x-1, y]
              					+ grid[x-1, y+1];
              		}
              		if (!((y-1) < 0)) {
              			count = count + grid[x, y-1]
              					+ grid[x+1, y-1];
              		}
              		if (!((y-1) < 0) && !((x-1) < 0)) {
              			count = count + grid[x-1,y-1];
              		}
              		grid[x, y] = isAlive (grid[x, y], count);
				}
			}
		}
	}
}

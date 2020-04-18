using System;

/*
Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
You may assume all four edges of the grid are all surrounded by water.

Example 1:

Input:
11110
11010
11000
00000

Output: 1
Example 2:

Input:
11000
11000
00100
00011

Output: 3
*/
namespace number_of_island
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        private int n;
        private int m;

        public int NumIslands(char[][] grid)
        {
            int count = 0;
            n = grid.Length;
            if (n == 0) return 0;
            m = grid[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (grid[i][j] == '1')
                    {
                        DFSMarking(grid, i, j);
                        ++count;
                    }
            }
            return count;
        }

        private void DFSMarking(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= n || j >= m || grid[i][j] != '1') return;
            grid[i][j] = '0';
            DFSMarking(grid, i + 1, j);
            DFSMarking(grid, i - 1, j);
            DFSMarking(grid, i, j + 1);
            DFSMarking(grid, i, j - 1);
        }
    }
}

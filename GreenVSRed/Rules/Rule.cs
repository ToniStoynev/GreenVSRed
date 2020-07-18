namespace GreenVSRed.Rules
{
    using System;
    public static class Rule
    {
        public static char[,] ApplyRules(char[,] grid)
        {
            var nextGen = new char[grid.GetLength(0), grid.GetLength(1)];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '0' && 
                            (   CountGreeenNeighbours(grid, i, j) == 3 
                                || CountGreeenNeighbours(grid, i, j) == 6
                            )
                       )
                    {
                        //grid[i, j] = '1';
                        nextGen[i, j] = '1';
                    }
                    else if (grid[i, j] == '0' && CountGreeenNeighbours(grid, i, j) != 3 && CountGreeenNeighbours(grid, i, j) != 6)
                    {
                        //grid[i, j] = '1';
                        nextGen[i, j] = '0';
                    }
                    else if (grid[i, j] == '1' 
                            && CountGreeenNeighbours(grid, i, j) != 2 
                            && CountGreeenNeighbours(grid, i, j) != 3 
                            && CountGreeenNeighbours(grid, i, j) != 6
                       )
                    {
                        //grid[i, j] = '0';
                        nextGen[i, j] = '0';
                    }
                    else if (grid[i, j] == '1' && 
                        (CountGreeenNeighbours(grid, i, j) == 2)
                       ||CountGreeenNeighbours(grid, i, j) == 3
                       || CountGreeenNeighbours(grid, i, j) == 6)
                    {
                        nextGen[i, j] = '1';
                    }
                }
            }

            return nextGen;
        }

        private static int CountGreeenNeighbours(char[,] grid, int x, int y)
        {
            int count = 0;

            int gridWidth = grid.GetLength(0);
            int gridHeight = grid.GetLength(1);

            //Top Left Corner
            if (x == 0 && y == 0)
            {
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y + 1] == '1')
                {
                    count++;
                }
            }

            //Top Right Corner
            else if (x == 0 && y == gridHeight - 1)
            {
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y - 1] == '1')
                {
                    count++;
                }
            }

            //Bottom Left Corner
            else if (x == gridWidth - 1 && y == 0)
            {
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y + 1] == '1')
                {
                    count++;
                }
            }

            //Bottom Right Corner
            else if (x == gridWidth - 1 && y == gridHeight - 1)
            {
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
            }

            //Left side of the grid
            else if (x > 0 && x < gridWidth - 1 && y == 0)
            {
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
            }


            //Top side of the grid
            else if (x == 0 && y > 0 && y < gridHeight - 1)
            {
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y + 1] == '1')
                {
                    count++;
                }
            }

            //Right side of the grid
            else if (x > 0 && x < gridWidth - 1 && y == gridHeight - 1)
            {
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y - 1] == '1')
                {
                    count++;
                }
            }


            //Bottom side of the grid
            else if (x == gridWidth - 1 && y > 0 && y < gridHeight - 1)
            {
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y + 1] == '1')
                {
                    count++;
                }
            }

            //TODO
            //Inner side of the grid
            else if(x > 0 && x < gridWidth - 1 && y > 0 && y < gridHeight - 1)
            {
                if (grid[x, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y + 1] == '1')
                {
                    count++;
                }
                if (grid[x - 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y - 1] == '1')
                {
                    count++;
                }
                if (grid[x + 1, y + 1] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}

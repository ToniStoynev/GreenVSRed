namespace GreenVSRed
{
    using GreenVSRed.Extensions;
    using GreenVSRed.Rules;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Read the size of the grid
            int[] gridSizes = Console.ReadLine().SplitAndParse();

            //Grid width
            int x = gridSizes[0];

            //Grid height
            int y = gridSizes[1];

            //Initialize the grid
            char[,] grid = new char[x, y];

            //Set the initial state of the grid
            for (int i = 0; i < y; i++)
            {
                string gridRow = Console.ReadLine();
                for (int j = 0; j < x; j++)
                {
                    grid[i, j] = gridRow[j];
                }
            }

            int[] coordinates = Console.ReadLine().SplitAndParse();
            int x1 = coordinates[0];
            int y1 = coordinates[1];
            int generationN = coordinates[2];


            //Result initial value
            int result = 0;

            for (int i = 0; i <= generationN; i++)
            {
                if (IsGreen(grid[x1, y1]))
                {
                    result++;
                }

                //Form the new generation
                var nextGen = Rule.ApplyRules(grid);

                grid = nextGen;
            }

            Console.WriteLine($"# expected result: {result}");
        }

        private static bool IsGreen(char elem)
        {
            if (elem == '1')
            {
                return true;
            }
            return false;
        }
    }
}

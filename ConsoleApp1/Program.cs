using LanguageExt;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            //var grid = new List<List<char>> {
            //      new List<char> { '1', '1', '1', '1', '0' },
            //      new List<char> { '1', '1', '0', '1', '0' },
            //      new List<char> { '1', '1', '0', '0', '0' },
            //      new List<char> { '0', '0', '0', '0', '0' }
            //    };
            char[][] grid = new char[][] {
              new char[] { '1', '1', '1', '1', '0' },
              new char[] { '1', '1', '0', '1', '0' },
              new char[] { '1', '1', '0', '0', '0' },
              new char[] { '0', '0', '0', '0', '1' }
              };
            NumIslands(grid);
            Console.ReadKey();
        }

        public static int NumIslands(char[][] grid)
        {
            int c = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        //turn it into 0 and see if there  is 1 near by and turn those into 0
                        c++;
                        convertTo0(grid, i, j);
                    }
                }
            }

            return c;

        }

        public static void convertTo0(char[][] grid, int i, int j)
        {
            if (i >= grid.Length || i < 0)
            {
                return;
            }
            if (grid[i].Length <= j || j < 0)
            {
                return;
            }
            if (grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';
            convertTo0(grid, i + 1, j);
            convertTo0(grid, i - 1, j);
            convertTo0(grid, i, j + 1);
            convertTo0(grid, i, j - 1);
        }









    }
}

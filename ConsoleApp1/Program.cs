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
            Generate(5);
            Console.ReadKey();
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> row = new List<int>();
            List<int> prow = new List<int>();

            if (numRows == 0) return res;

            row.Add(1);
            res.Add(row);
            for (int i = 1;i<numRows;i++)
            {
                prow = row;
                row = new List<int>();
                for (int j = 0; j <= i;j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);    
                    }
                    else
                    {
                        int n = prow[j - 1] + prow[j];
                        row.Add(n);
                    }   
                }
                res.Add(row);
            }

            return res;
        }







    }
}

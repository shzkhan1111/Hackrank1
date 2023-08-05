using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //List<int> a = new List<int> { 5,2,1,3,4};
            //int[] c = new int[] { 5,4,4,2,2,8};

            //var x = jumpingOnClouds(c , 2);
            //Console.WriteLine(string.Join(", ", permutationEquation(a)));
            //Console.WriteLine(appendAndDelete("y", "yu", 2));

            List<int> query = new List<int> { 1,2,2,3};
            List<List<int>> obs = new List<List<int>>();

            obs.Add(new List<int> { 5, 5 });
            obs.Add(new List<int> { 4, 2 });
            obs.Add(new List<int> { 2, 3 });

            Console.WriteLine(queensAttack(100 , 0 , 1 , 1 , obs).ToString());
            Console.ReadKey();
        }


        //public static int queensAttack(int n, int k, int r_q,
        //    int c_q, List<List<int>> obstacles)
        //{
        //    int res = 0;

        //    int setMaxCount = (n+1) * 2;


        //    int right_count = setMaxCount;
        //    int left_count = setMaxCount;

        //    int up_count = setMaxCount;
        //    int down_count = setMaxCount;

        //    int right_up_count = setMaxCount;
        //    int left_up_count = setMaxCount;

        //    int right_down_count = setMaxCount;
        //    int left_down_count = setMaxCount;

        //    int ru = (n - r_q) < (n - c_q) ? (n - r_q) : (n - c_q);
        //    int lu = (n - r_q) < c_q - 1 ? (n - r_q) : c_q - 1;
        //    int rb = r_q - 1 < (n - c_q) ? r_q - 1 : (n - c_q);
        //    int lb = r_q < c_q ? r_q - 1 : c_q - 1;

        //    //settting up counts 
        //    foreach (var o in obstacles)
        //    {

        //        if (o[0] == r_q)
        //        {
        //            //in the same row up or down 
        //            if (o[1] < c_q)
        //            {
        //                //left
        //                if (left_count > (c_q - o[1]))
        //                    left_count = c_q - o[1];

        //            }
        //            else if (o[1] > c_q)
        //            {
        //                //right
        //                if (right_count > (o[1] - c_q))
        //                    right_count = o[1] - c_q;
        //            }

        //        }
        //        if (o[1] == c_q)
        //        {
        //            //up and down
        //            if (o[0] < r_q)
        //            {
        //                //down
        //                if (down_count > (r_q - o[0]))
        //                    down_count = r_q - o[0];
        //            }
        //            else if (o[0] > r_q)
        //            {
        //                //up
        //                if (up_count > (o[0] - r_q))
        //                    up_count = o[0] - r_q;
        //            }

        //        }





        //        //diagnols
        //        if (Math.Abs(o[0] - r_q) == Math.Abs(o[1] - c_q))
        //        {
        //            int diff = Math.Abs(o[0] - r_q);
        //            int rowdif = r_q - o[0];
        //            int coldif = c_q - o[1];
        //            if (rowdif < 0 && coldif < 0)
        //            {
        //                //left botton
        //                if (left_down_count > diff)
        //                    left_down_count = diff;
        //            }
        //            else if (rowdif > 0 && coldif < 0)
        //            {
        //                //left up
        //                if (left_up_count > diff)
        //                    left_up_count = diff;
        //            }
        //            else if (rowdif < 0 && coldif > 0)
        //            {
        //                //down , right 
        //                if (right_down_count > diff)
        //                    right_down_count = diff;
        //            }
        //            else if (rowdif > 0 && coldif > 0)
        //            {
        //                //up , right 
        //                if (right_up_count > diff)
        //                    right_up_count = diff;
        //            }







        //        }

        //    }

        //    if (right_count == setMaxCount)
        //    {
        //        res += (n - c_q);
        //    }
        //    else
        //    {
        //        res += right_count - 1;
        //    }

        //    if (left_count == setMaxCount)
        //    {
        //        res += (c_q) - 1;
        //    }
        //    else
        //    {
        //        res += left_count -1 ;
        //    }

        //    if (up_count == setMaxCount)
        //    {
        //        res += (n -r_q);
        //    }
        //    else
        //    {
        //        res += up_count - 1;
        //    }
        //    if (down_count== setMaxCount)
        //    {
        //        res += r_q - 1;
        //    }
        //    else
        //    {
        //        res += down_count  - 1 ;
        //    }
        //    //up down 

        //    //find max if no obs


        //    if (right_up_count == setMaxCount)
        //    {
        //        res += ru;
        //    }
        //    else
        //    {
        //        res += right_up_count;
        //    }

        //    if (right_down_count == setMaxCount)
        //    {
        //        res += rb;
        //    }
        //    else
        //    {
        //        res += right_down_count;
        //    }

        //    if (left_up_count == setMaxCount)
        //    {
        //        res += lu;
        //    }
        //    else
        //    {
        //        res += left_up_count;
        //    }
        //    if (left_down_count == setMaxCount)
        //    {
        //        res += lb;
        //    }
        //    else
        //    {
        //        res += left_down_count;
        //    }

        //    return res;
        //}
        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            int res = 0;
            int setMaxCount = (n + 1) * 2;

            int right_count = n - c_q;
            int left_count = c_q - 1;
            int up_count = n - r_q;
            int down_count = r_q - 1;

            int right_up_count = Math.Min(n - r_q, n - c_q);
            int left_up_count = Math.Min(n - r_q, c_q - 1);
            int right_down_count = Math.Min(r_q - 1, n - c_q);
            int left_down_count = Math.Min(r_q - 1, c_q - 1);

            foreach (var o in obstacles)
            {
                int row = o[0];
                int col = o[1];

                // Check if the obstacle is in the same row or column as the queen
                if (row == r_q)
                {
                    if (col < c_q) left_count = Math.Min(left_count, c_q - col - 1);
                    else if (col > c_q) right_count = Math.Min(right_count, col - c_q - 1);
                }
                else if (col == c_q)
                {
                    if (row < r_q) down_count = Math.Min(down_count, r_q - row - 1);
                    else if (row > r_q) up_count = Math.Min(up_count, row - r_q - 1);
                }
                else if (Math.Abs(row - r_q) == Math.Abs(col - c_q))
                {
                    int diff = Math.Abs(row - r_q);
                    if (row > r_q && col > c_q) right_up_count = Math.Min(right_up_count, diff - 1);
                    else if (row > r_q && col < c_q) left_up_count = Math.Min(left_up_count, diff - 1);
                    else if (row < r_q && col > c_q) right_down_count = Math.Min(right_down_count, diff - 1);
                    else if (row < r_q && col < c_q) left_down_count = Math.Min(left_down_count, diff - 1);
                }
            }

            res = right_count + left_count + up_count + down_count +
                  right_up_count + left_up_count + right_down_count + left_down_count;

            return res;
        }


    }
}

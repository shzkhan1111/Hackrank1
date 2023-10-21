using LanguageExt;
using System;
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
            //testing
            int u = 10;
            List<int> list = new List<int>();
            list.Add(u);

            List<List<int>> llist = new List<List<int>>();
            llist.Add(list);
            for (int i = 0; i < 4; i++)
            {
                list = new List<int>();
                list.Add(i + u);
                llist.Add(list);
            }

            List<Something> slist = new List<Something>();
            List<List<Something>> sllist = new List<List<Something>>();

            Something s = new Something();
            slist.Add(s);

            s.x = 10;
            s.y = 10;
            for (int i = 0; i < 4; i++)
            {
                slist = new List<Something>();
                slist.Add(s);   
                sllist.Add(slist);
                s.x = i;
                s.y = i;
            }

            List<Something> slist1 = new List<Something>();
            List<List<Something>> sllist1 = new List<List<Something>>();

            Something s1 = new Something();

            for (int i = 0; i < 4; i++)
            {
                slist = new List<Something>();
                slist.Add(new Something
                {
                    x = i,  y= i
                });
                sllist.Add(slist);
                s.x = i;
                s.y = i;
            }
            Console.ReadKey();


        }

        public class Something
        {
            public int x;
            public int y { get; set; }
        }


       



    }
}

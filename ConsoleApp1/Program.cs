using System;
using System.Linq;
using System.Numerics;
using ConsoleApp1.Service;
using ConsoleApp1.Model;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp1
{


    class Program
    {
        record Person(string FirstName, string LastName);
        record Cat(string Name, Person Owner);
        record Dog(string Name, Person Owner);


        static void Main(string[] args)
        {
            Person magnus = new("Magnus", "Hedlund");
            Person terry = new("Terry", "Adams");
            Person charlotte = new("Charlotte", "Weiss");
            Person arlene = new("Arlene", "Huff");
            Person rui = new("Rui", "Raposo");
            Person phyllis = new("Phyllis", "Harris");

            List<Person> people = new() { magnus, terry, charlotte, arlene, rui, phyllis };
            List<Cat> cats = new()
            {
                new("Barley", terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", rui),
                new("Daisy", magnus),
            };

            List<Dog> dogs = new()
            {
                new("Four Wheel Drive", phyllis),
                new("Duke", magnus),
                new("Denim", terry),
                new("Wiley", charlotte),
                new("Snoopy", rui),
                new("Snickers", arlene),
            };

            var grpJoinQry = 
                from p in people
                             join cat in cats
                             on p equals cat.Owner into pj
                             select new
                             {
                                 A = pj,
                                 //B = cat, // no Accessibility to cats
                                 C = p //accessibility to P alone 
                             };

            foreach (var x in grpJoinQry)
            {
                Console.WriteLine($"P is {x.C.FirstName}");
                foreach (var v in x.A)
                {
                    Console.WriteLine($"Values inside PJ are {v.Name} owner Name {v.Owner.FirstName}");
                }
            }

        }




    }





}

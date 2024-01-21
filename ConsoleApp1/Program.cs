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


            var multiQuery = from p in people
                             join c in cats
                             on p equals c.Owner

                             join d in dogs on
                             new
                             {
                                 Owner = c.Owner,
                                 Name = c.Name[..1]
                             }
                             equals
                             new
                             {
                                 Owner = d.Owner,
                                 Name = d.Name[..1]
                             }
                             select new
                             {
                                 CatName = c.Name,
                                 DogName = d.Name
                             }
                        ;
            foreach (var s in multiQuery)
            {
                Console.WriteLine($"Catname = {s.CatName} and Dog name is {s.DogName}");
            }

        }




    }





}

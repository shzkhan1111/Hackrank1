﻿using System;
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


            var query = people.Join(cats,
                (p => p),
                (c => c.Owner),
                (p, c) => new { p, c }
                )
                .Join(dogs,
                catOwner => new { Owner = catOwner.p, FirstLetterName = catOwner.c.Name[..1] },
                d => new { Owner = d.Owner, FirstLetterName = d.c.Name[..1] },
                (catowner, D) => new { co = catowner, d = D }

                )
                ;
            foreach (var x in query)
            {
                Console.WriteLine($"{x.co.p.Name} : {x.co.c.Name} : {x.co.c.Name}");
            }













            //  var query = people.Join(cats,
            //person => person,
            //cat => cat.Owner,
            //(person, cat) => new { person, cat })
            //  .Join(dogs,
            //commonOwner => new { Owner = commonOwner.person, Letter = commonOwner.cat.Name[..1] },
            //dog => new { dog.Owner, Letter = dog.Name[..1] },
            //(commonOwner, dog) => new { CatName = commonOwner.cat.Name, DogName = dog.Name });
            //  ;





        }




    }





}

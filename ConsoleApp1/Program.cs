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
        record Pet(string Name, Person Owner);
        record Employee(string FirstName, string LastName, int EmployeeID);
        record Cat(string Name, Person Owner) : Pet(Name, Owner);
        record Dog(string Name, Person Owner) : Pet(Name, Owner);
        static void Main(string[] args)
        {

            Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            Person terry = new("Terry", "Adams");
            Person charlotte = new("Charlotte", "Weiss");
            Person arlene = new("Arlene", "Huff");
            Person rui = new("Rui", "Raposo");

            List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

            List<Pet> pets = new()
            {
                new(Name: "Barley", Owner: terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", rui),
                new("Daisy", magnus),
            };

            // Create a collection of person-pet pairs. Each element in the collection
            //// is an anonymous type containing both the person's name and their pet's name.
            //var query =
            //    from person in people
            //    join pet in pets on person equals pet.Owner
            //    select new
            //    {
            //        OwnerName = person.FirstName,
            //        PetName = pet.Name
            //    };

            //var result = "";
            //foreach (var ownerAndPet in query)
            //{
            //    result += $"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}\r\n";
            //}
            //Console.Write(result);



            //var petIsOwnedBy = from p in pets
            //                   join
            //                    person in people
            //                    on p.Owner equals person
            //                   select new { pet = p, person = person };
            var petIsOwnedBy =
                people.Join(
                    pets,
                    person => person,
                    pet => pet.Owner,
                    (person, pet) => new { pet = pet, person = person});

            foreach (var pet in petIsOwnedBy)
            {
                Console.WriteLine($"pet {pet.pet.Name} is owned by {pet.person.FirstName} , {pet.person.LastName}");
            }
            

            /* Output:
                 "Daisy" is owned by Magnus
                 "Barley" is owned by Terry
                 "Boots" is owned by Terry
                 "Whiskers" is owned by Charlotte
                 "Blue Moon" is owned by Rui
            */


        }



    }





}

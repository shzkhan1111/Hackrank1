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
        record Employee(string FirstName, string LastName, int EmployeeID);
        record Student(string FirstName, string LastName, int StudentID);


        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
{
    new("Terry", "Adams", 522459),
    new("Charlotte", "Weiss", 204467),
    new("Magnus", "Hedland", 866200),
    new("Vernette", "Price", 437139)
};

            List<Student> students = new List<Student>()
{
    new("Vernette", "Price", 9562),
    new("Terry", "Earls", 9870),
    new("Terry", "Adams", 9913)
};


            var compositeKeyJoinLinq = from e in employees
                                       join s in students
                                       on new
                                       {
                                           e.FirstName,
                                           e.LastName
                                       }
                                       equals
                                       new
                                       {
                                           s.FirstName,
                                           s.LastName
                                       }

                                       select $"{e.FirstName} {e.LastName}";

            foreach (var x in compositeKeyJoinLinq)
            {
                Console.WriteLine(x);
            }
            //lambda 

            var query = employees.Join(
                         students,//ordder same 
                         employee => new { FirstName = employee.FirstName, LastName = employee.LastName },
                         student => new { FirstName = student.FirstName, student.LastName },
                         (employee, student) => $"{employee.FirstName} {employee.LastName}"
                     );
                foreach (var x in query)
            {
                Console.WriteLine(x);
            }






        }



    }





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_46___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Engin" },
                new Student { FirstName = "Derin" },
                new Person { FirstName = "Salih" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {

    }
    class Customer:Person, IPerson //Buraya da person2 ekleyemiyoruz çünkü bir kişinin bir babası olur
    {                     //ama interface olduğu için IPerson u ekleyebildik
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}

using ApartmentBuilding.Contexts;
using ApartmentBuilding.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding a new person

            using (var apartmentContext = new ApartmentContext())
            {
                Person newPerson = new Person
                {

                    personID = 1,
                    personName = "Nihil",
                    personSurname = "Nia"

                };

                apartmentContext.Persons.Add(newPerson);
                apartmentContext.SaveChanges();
            }

            // Adding debt to an exists person

            using (var apartmentContext = new ApartmentContext())
            {
                Person existsPerson =  apartmentContext.Persons.Find(1); //parameter is primary key which is I made it as personID
                existsPerson.personDebts.Add(new Debt { debtID = 1, personID = 123, currentDebt = 1000});
                apartmentContext.SaveChanges();
            }


            using (var apartmentContext = new ApartmentContext())
            {
                foreach (var person in apartmentContext.Persons)
                {
                    Console.WriteLine("Person name: " + person.personName);
                }
            }
            Console.ReadLine();
        }
    }
}

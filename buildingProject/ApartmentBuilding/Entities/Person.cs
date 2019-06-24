using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBuilding.Entities
{
    public class Person
    {
        public Person()
        {
            personDebts = new List<Debt>();
        }
      


        public int personID { get; set; }

        public string personName { get; set; }

        public string personSurname { get; set; }

        public List<Debt> personDebts { get; set; }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBuilding.Entities
{
    public class Debt
    {
        public int debtID { get; set; }

        public int personID { get; set; }

        public double currentDebt { get; set; }

        public Person person { get; set; }
    }
}

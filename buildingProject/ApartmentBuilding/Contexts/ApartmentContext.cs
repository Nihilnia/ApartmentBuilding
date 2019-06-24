using ApartmentBuilding.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentBuilding.Contexts
{
    class ApartmentContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Debt> Debts { get; set; }
    }
}

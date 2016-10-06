using Labo3;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DBIntializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer custom1 = new Customer()
            {
                AccountBalance= 20,
                AddressLine1 = "Rue Machin",
                AddressLine2 = "Village Truc",
                City = "Namur",
                Country = "Belgique",
                Email = "machin@gmail.com",
                Id = 1,
                Name = "Damien",
                PostCode = "5000",
                Remark = "Génie",                
            };

            context.Customers.Add(custom1);

            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    public class CompanyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CompanyContext()
            //@ permet de ne pas devoir mettre des caractère d'échappement
            : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ConcurrencyDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

    }
}

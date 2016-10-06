using System;
using Labo3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DBIntializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void CanGetCustomers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }

        public CompanyContext GetContext()
        {
            return new CompanyContext();
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void DetecteLesEditionsConcurrentes()
        {
            using (CompanyContext contextDeJohn = GetContext())
            {
                using (CompanyContext contextDeSarah = GetContext())
                {
                    var clientJohn = contextDeJohn.Customers.First();// ici clean code parce que c'est juste le test unitaire donc on test juste pour un truc donc First() OK
                    var clientSarah = contextDeSarah.Customers.First();

                    clientJohn.AccountBalance += 1000;
                    contextDeJohn.SaveChanges();

                    clientSarah.AccountBalance += 2000;
                    contextDeSarah.SaveChanges();
                }
            }
        }

    }
}

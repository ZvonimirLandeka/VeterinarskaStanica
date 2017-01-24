using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;
using System.Data.SQLite;
using NHibernate;
using System.Collections;

namespace VeterinarskaStanica.DAL.Tests
{
    [TestClass]
    public class ZaposlenikRepositoryTests
    {
        private ZaposlenikRepository zaposlenikRepo;

        public ZaposlenikRepositoryTests()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.InMemory);

            zaposlenikRepo = new ZaposlenikRepository();
        }

        [TestMethod]
        public void AddZaposlenik_Test()
        {
            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    Zaposlenik zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic", OIB = "51683824666" };
                    zaposlenikRepo.Add(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }


            var zaposlenici = zaposlenikRepo.GetAll();
            var savedZaposlenik = zaposlenici[0];

            Assert.AreEqual(1, zaposlenici.Count);
            Assert.AreEqual("Marko", savedZaposlenik.Ime);
            Assert.AreEqual("Markovic", savedZaposlenik.Prezime);
            Assert.AreEqual("51683824666", savedZaposlenik.OIB);
        }

        [TestMethod]
        public void DeleteZaposlenik_Test()
        {
            var zaposleniciOld = zaposlenikRepo.GetAll();

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    Zaposlenik zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic", OIB = "51683824666" };
                    zaposlenikRepo.Add(zaposlenik);
                    zaposlenikRepo.Delete(zaposlenik.Id);
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            
            var zaposleniciNew = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposleniciOld.Count, zaposleniciNew.Count);
        }
    }
}

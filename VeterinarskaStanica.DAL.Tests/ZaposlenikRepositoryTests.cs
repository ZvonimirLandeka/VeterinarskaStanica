using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;
using System.Data.SQLite;

namespace VeterinarskaStanica.DAL.Tests
{
    [TestClass]
    public class ZaposlenikRepositoryTests
    {   
        private SQLiteTestDatabase database;

        public ZaposlenikRepositoryTests()
        {
            database = new SQLiteTestDatabase();
        }

        [TestMethod]
        public void AddZaposlenik_Test()
        {
            ZaposlenikRepository zaposlenikRepo = new ZaposlenikRepository(database.Session);
                
            Zaposlenik zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic", OIB = "51683824666" };
            
            zaposlenikRepo.Add(zaposlenik);

            var zaposlenici = zaposlenikRepo.GetAll();

            Assert.AreEqual(1, zaposlenici.Count);

            var savedZaposlenik = zaposlenici[0];

            Assert.AreEqual("Marko", savedZaposlenik.Ime);
            Assert.AreEqual("Markovic", savedZaposlenik.Prezime);
            Assert.AreEqual("51683824666", savedZaposlenik.OIB);

        }

        [TestMethod]
        public void DeleteZaposlenik_Test()
        {
            ZaposlenikRepository zaposlenikRepo = new ZaposlenikRepository(database.Session);

            Zaposlenik zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic", OIB = "51683824666" };

                zaposlenikRepo.Add(zaposlenik);


            var zaposlenici = zaposlenikRepo.GetAll();
            Assert.AreEqual(1, zaposlenici.Count);

            var savedZaposlenik = zaposlenici[0];
            Assert.AreEqual("Marko", savedZaposlenik.Ime);
            Assert.AreEqual("Markovic", savedZaposlenik.Prezime);
            Assert.AreEqual("51683824666", savedZaposlenik.OIB);

            using (var transaction = database.Session.BeginTransaction())
            {
                zaposlenikRepo.Delete(savedZaposlenik.Id);
            }

            database.Session.Clear();

            zaposlenici = zaposlenikRepo.GetAll();
            Assert.AreEqual(0, zaposlenici.Count);
        }
    }
}

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

        [TestMethod]
        public void AddZaposlenik_Test()
        {
            database = new SQLiteTestDatabase();

            ZaposlenikRepository zaposlenikRepo = new ZaposlenikRepository(database.Session);

            Zaposlenik zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic" };

            //zaposlenikRepo.
        }
    }
}

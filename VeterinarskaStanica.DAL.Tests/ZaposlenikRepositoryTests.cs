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

            // brisanje unesenog objekta kako ne bi doslo do kolizije s ostalim testovima
            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(savedZaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            //provjera uspjesnosti brisanja
            zaposlenici = zaposlenikRepo.GetAll();
            Assert.AreEqual(0, zaposlenici.Count);
        }

        [TestMethod]
        public void AddVrstaZaposlenika_Test()
        {
            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    VrstaZaposlenika vrstaZaposlenika = new VrstaZaposlenika() { Naziv = "Doktor"} ;
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var VrstaZaposlenikaList = zaposlenikRepo.GetAllVrstaZaposlenika();
            var VrstaZaposlenika = VrstaZaposlenikaList[0];

            Assert.AreEqual("Doktor", VrstaZaposlenika.Naziv);

            // brisanje unesenog objekta kako ne bi doslo do kolizije s ostalim testovima
            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.DeleteVrstaZaposlenika(VrstaZaposlenika.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            //provjera uspjesnosti brisanja
            VrstaZaposlenikaList = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(0, VrstaZaposlenikaList.Count);
        }

        [TestMethod]
        public void DeleteZaposlenik_Test()
        {
            Zaposlenik zaposlenik = null;

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik = new Zaposlenik() { Ime = "Marko", Prezime = "Markovic", OIB = "51683824666" };
                    zaposlenikRepo.Add(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            
            var zaposleniciBeforeDelete = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposleniciBeforeDelete.Count, 1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var zaposleniciAfterDelete = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposleniciAfterDelete.Count, 0);
        }

        [TestMethod]
        public void DeleteVrstaZaposlenika_Test()
        {
            VrstaZaposlenika vrstaZaposlenika = null;

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZaposlenika = new VrstaZaposlenika() { Naziv = "Doktor" };
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
                
            }

            var vrsteZaposlenikaBeforeDelete = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(vrsteZaposlenikaBeforeDelete.Count, 1);

            using(var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var vrsteZaposlenikaAfterDelete = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(vrsteZaposlenikaAfterDelete.Count, 0);
        }

        [TestMethod]
        public void GetAll_Test()
        {
            Zaposlenik zaposlenik1 = null;
            Zaposlenik zaposlenik2 = null;
            Zaposlenik zaposlenik3 = null;

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik1 = new Zaposlenik() { Ime = "Matko" };
                    zaposlenik2 = new Zaposlenik() { Ime = "Zvonimir" }; ;
                    zaposlenik3 = new Zaposlenik() { Ime = "Ivan" };

                    zaposlenikRepo.Add(zaposlenik1);
                    zaposlenikRepo.Add(zaposlenik2);
                    zaposlenikRepo.Add(zaposlenik3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }        
            }

            var listaZaposlenika = zaposlenikRepo.GetAll();
            Assert.AreEqual(listaZaposlenika.Count, 3);
            Assert.AreEqual(listaZaposlenika[0].Ime, "Matko");
            Assert.AreEqual(listaZaposlenika[1].Ime, "Zvonimir");
            Assert.AreEqual(listaZaposlenika[2].Ime, "Ivan");

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik1.Id);
                    zaposlenikRepo.Delete(zaposlenik2.Id);
                    zaposlenikRepo.Delete(zaposlenik3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            listaZaposlenika = zaposlenikRepo.GetAll();
            Assert.AreEqual(listaZaposlenika.Count, 0);
        }

        [TestMethod]
        public void GetAllVrstaZaposlenika_Test()
        {
            VrstaZaposlenika vrstaZaposlenika1 = null;
            VrstaZaposlenika vrstaZaposlenika2 = null;
            VrstaZaposlenika vrstaZaposlenika3 = null;

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZaposlenika1 = new VrstaZaposlenika() { Naziv = "Doktor" };
                    vrstaZaposlenika2 = new VrstaZaposlenika() { Naziv = "Tehnicar" };
                    vrstaZaposlenika3 = new VrstaZaposlenika() { Naziv = "Tajnica" };
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika1);
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika2);
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                } 
            }

            var listaVrsteZaposlenika = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(listaVrsteZaposlenika.Count, 3);
            Assert.AreEqual(listaVrsteZaposlenika[0].Naziv, "Doktor");
            Assert.AreEqual(listaVrsteZaposlenika[1].Naziv, "Tehnicar");
            Assert.AreEqual(listaVrsteZaposlenika[2].Naziv, "Tajnica");

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika1.Id);
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika2.Id);
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            listaVrsteZaposlenika = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(listaVrsteZaposlenika.Count, 0);
        }

        [TestMethod]
        public void GetById_Test()
        {
            Zaposlenik zaposlenik = null;
            String ime = "Ivan";

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik = new Zaposlenik() { Ime = ime };
                    zaposlenikRepo.Add(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            Zaposlenik zaposlenikTest = zaposlenikRepo.GetById(zaposlenik.Id);

            Assert.AreEqual(ime, zaposlenikTest.Ime);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var listaZaposlenika = zaposlenikRepo.GetAll();
            Assert.AreEqual(listaZaposlenika.Count, 0);
        }

        [TestMethod]
        public void GetByKorisnickoIme_Test()
        {
            Zaposlenik zaposlenik = null;

            using(var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik = new Zaposlenik() { KorisnickoIme = "mmesar", Ime = "Krtica" };
                    zaposlenikRepo.Add(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            Zaposlenik zaposlenikTest = zaposlenikRepo.GetByKorisnickoIme(zaposlenik.KorisnickoIme);
            Assert.AreEqual(zaposlenik.KorisnickoIme, zaposlenikTest.KorisnickoIme);
            Assert.AreEqual(zaposlenik.Ime, zaposlenikTest.Ime);

            using( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var lista = zaposlenikRepo.GetAll();
            Assert.AreEqual(lista.Count, 0);
        }

        [TestMethod]
        public void GetByOib_Test()
        {
            Zaposlenik zaposlenik = null;

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik = new Zaposlenik() { OIB = "TestniOib", Ime = "Katica" };
                    zaposlenikRepo.Add(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            Zaposlenik zaposlenikTest = zaposlenikRepo.GetByOib(zaposlenik.OIB);

            Assert.AreEqual(zaposlenik.OIB, zaposlenikTest.OIB);
            Assert.AreEqual(zaposlenik.Ime, zaposlenikTest.Ime);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var list = zaposlenikRepo.GetAll();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void GetVrstaZaposlenikaById_Test()
        {
            VrstaZaposlenika vrstaZaposlenika = null;

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZaposlenika = new VrstaZaposlenika() { Id = 12312354, Naziv = "Doktor" };
                    zaposlenikRepo.AddVrstaZaposlenika(vrstaZaposlenika);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            VrstaZaposlenika vrstaZaposlenikaTest = zaposlenikRepo.GetVrstaZaposlenikaById(vrstaZaposlenika.Id);
            Assert.AreEqual(vrstaZaposlenika.Id, vrstaZaposlenikaTest.Id);
            Assert.AreEqual(vrstaZaposlenika.Naziv, vrstaZaposlenikaTest.Naziv);

           using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var lista = zaposlenikRepo.GetAll();
            Assert.AreEqual(lista.Count, 0);
        }

        [TestMethod]
        public void Update_Test()
        {
            String oldName = "Ivan";
            String newName = "Zvonimir";
            Zaposlenik zaposlenik = new Zaposlenik() { Id = 1232345, Ime = oldName };

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik.Ime = newName;
                    zaposlenikRepo.Update(zaposlenik);
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }

            Zaposlenik zaposlenikTest = zaposlenikRepo.GetById(zaposlenik.Id);
            Assert.AreEqual(zaposlenik.Id, zaposlenikTest.Id);
            Assert.AreNotEqual(zaposlenik.Ime, oldName);
            Assert.AreEqual(zaposlenikTest.Ime, newName);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var list = zaposlenikRepo.GetAll();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void UpdateVrstaZaposlenika_Test()
        {
            String oldName = "DoktorDoom";
            String newName = "FantasticFour";
            VrstaZaposlenika vrstaZaposlenika = new VrstaZaposlenika() { Id = 4527382, Naziv = oldName};

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZaposlenika.Naziv = newName;
                    zaposlenikRepo.UpdateVrstaZaposlenika(vrstaZaposlenika);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            VrstaZaposlenika vrstaZaposlenikaTest = zaposlenikRepo.GetVrstaZaposlenikaById(vrstaZaposlenika.Id);
            Assert.AreEqual(vrstaZaposlenika.Id, vrstaZaposlenikaTest.Id);
            Assert.AreNotEqual(vrstaZaposlenikaTest.Naziv, oldName);
            Assert.AreEqual(vrstaZaposlenikaTest.Naziv, newName);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.DeleteVrstaZaposlenika(vrstaZaposlenika.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            var list = zaposlenikRepo.GetAllVrstaZaposlenika();
            Assert.AreEqual(list.Count, 0);
        }
    }
}

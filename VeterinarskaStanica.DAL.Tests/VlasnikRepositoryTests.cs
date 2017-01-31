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
    public class VlasnikRepositoryTests
    {
        private VlasnikRepository vlasnikRepo;

        public VlasnikRepositoryTests()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.InMemory);
            vlasnikRepo = new VlasnikRepository();
        }

        [TestMethod]
        public void AddVlasnik_Test()
        {
            Vlasnik vlasnik = null;
            String ime = "Tyrael";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik = new Vlasnik() { Ime = ime };
                    vlasnikRepo.Add(vlasnik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 1);

            Vlasnik vlasnikTest = vlasnikList[0];
            Assert.AreEqual(vlasnikTest.Ime, ime);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void DeleteVlasnik_Test()
        {
            Vlasnik vlasnik = null;

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik = new Vlasnik() {};
                    vlasnikRepo.Add(vlasnik);
                    transaction.Commit();
                }
                catch(Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void GetAll_Test()
        {
            Vlasnik vlasnik1 = null;
            Vlasnik vlasnik2 = null;
            Vlasnik vlasnik3 = null;
            String ime1 = "Ivan";
            String ime2 = "Zvonimir";
            String ime3 = "Matko";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik1 = new Vlasnik() { Ime = ime1 };
                    vlasnik2 = new Vlasnik() { Ime = ime2 };
                    vlasnik3 = new Vlasnik() { Ime = ime3 };
                    vlasnikRepo.Add(vlasnik1);
                    vlasnikRepo.Add(vlasnik2);
                    vlasnikRepo.Add(vlasnik3);
                    transaction.Commit();

                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 3);

            Vlasnik vlasnikTest1 = vlasnikList[0];
            Vlasnik vlasnikTest2 = vlasnikList[1];
            Vlasnik vlasnikTest3 = vlasnikList[2];

            Assert.AreEqual(vlasnikTest1.Ime, ime1);
            Assert.AreEqual(vlasnikTest2.Ime, ime2);
            Assert.AreEqual(vlasnikTest3.Ime, ime3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik1.Id);
                    vlasnikRepo.Delete(vlasnik2.Id);
                    vlasnikRepo.Delete(vlasnik3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void GetById_Test()
        {
            Vlasnik vlasnik1 = null;
            Vlasnik vlasnik2 = null;
            String ime1 = "fe98azg87z";
            String ime2 = "btr8n98nuf";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik1 = new Vlasnik() { Ime = ime1 };
                    vlasnik2 = new Vlasnik() { Ime = ime2 };
                    vlasnikRepo.Add(vlasnik1);
                    vlasnikRepo.Add(vlasnik2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 2);

            Vlasnik vlasnikTest = vlasnikRepo.GetById(vlasnik1.Id);
            Assert.AreEqual(vlasnikTest.Ime, ime1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik1.Id);
                    vlasnikRepo.Delete(vlasnik2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void GetByKorisnickoIme_Test()
        {
            Vlasnik vlasnik1 = null;
            Vlasnik vlasnik2 = null;
            String korisnickoIme1 = "3a5h4a5rt";
            String ime1 = "yrj98rhgr98t";
            String korisnickoIme2 = "tr7gfeagu89";
            String ime2 = "j87rezf7";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik1 = new Vlasnik() { KorisnickoIme = korisnickoIme1, Ime = ime1};
                    vlasnik2 = new Vlasnik() { KorisnickoIme = korisnickoIme2, Ime = ime2};
                    vlasnikRepo.Add(vlasnik1);
                    vlasnikRepo.Add(vlasnik2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 2);

            Vlasnik vlasnikTest = vlasnikRepo.GetByKorisnickoIme(korisnickoIme1);
            Assert.AreEqual(vlasnikTest.Ime, ime1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik1.Id);
                    vlasnikRepo.Delete(vlasnik2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void GetByOib_Test()
        {
            Vlasnik vlasnik1 = null;
            Vlasnik vlasnik2 = null;
            String oib1 = "ro8zg87aerzg87";
            String ime1 = "a4tia094i";
            String oib2 = "slihf7zg0'efs";
            String ime2 = "afjaw9feu9";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik1 = new Vlasnik() { Ime = ime1, OIB = oib1 };
                    vlasnik2 = new Vlasnik() { Ime = ime2, OIB = oib2 };
                    vlasnikRepo.Add(vlasnik1);
                    vlasnikRepo.Add(vlasnik2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 2);

            Vlasnik vlasnikTest = vlasnikRepo.GetByOib(oib1);
            Assert.AreEqual(vlasnikTest.Ime, ime1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik1.Id);
                    vlasnikRepo.Delete(vlasnik2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }

        [TestMethod]
        public void Update_Test()
        {
            Vlasnik vlasnik = null;
            String oldIme = "erig0eaig09";
            String newIme = "yoewrug98erg";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik = new Vlasnik() { Ime = oldIme };
                    vlasnikRepo.Add(vlasnik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik.Ime = newIme;
                    vlasnikRepo.Update(vlasnik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 1);

            Vlasnik vlasnikTest = vlasnikList[0];
            Assert.AreEqual(vlasnikTest.Ime, newIme);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnikRepo.Delete(vlasnik.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);
        }
    }
}

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
    public class ZivotinjaRepositoryTests
    {
        private ZivotinjaRepository zivotinjaRepo;
        private VlasnikRepository vlasnikRepo;

        public ZivotinjaRepositoryTests()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.InMemory);
            zivotinjaRepo = new ZivotinjaRepository();
            vlasnikRepo = new VlasnikRepository();
        }

        [TestMethod]
        public void AddZivotinja_Test()
        {
            Zivotinja zivotinja = null;
            String ime = "ors8yrg8r7";

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja = new Zivotinja() { Ime = ime };
                    zivotinjaRepo.Add(zivotinja);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 1);

            Zivotinja zivotinjaTest = zivotinjaList[0];
            Assert.AreEqual(zivotinjaTest.Ime, ime);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void AddBolest_Test()
        {
            Bolest bolest = null;
            String naziv = "fees98ufs98ef";

            var bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest = new Bolest() { Naziv = naziv };
                    zivotinjaRepo.AddBolest(bolest);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 1);

            Bolest bolestTest = bolestList[0];
            Assert.AreEqual(bolestTest.Naziv, naziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteBolest(bolest.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);
        }

        [TestMethod]
        public void AddPasminaZivotinje_Test()
        {
            PasminaZivotinje pasminaZivotinje = null;
            String naziv = "da98gzusr987";

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje = new PasminaZivotinje() { Naziv = naziv };
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 1);

            PasminaZivotinje pasminaZivotinjeTest = pasminaZivotinjeList[0];
            Assert.AreEqual(pasminaZivotinjeTest.Naziv, naziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void AddVrstaZivotinje_Test()
        {
            VrstaZivotinje vrstaZivotinje = null;
            String naziv = "fe98<z<8g<srg";

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje = new VrstaZivotinje() { Naziv = naziv };
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 1);

            VrstaZivotinje vrstaZivotinjeTest = vrstaZivotinjeList[0];
            Assert.AreEqual(vrstaZivotinjeTest.Naziv, naziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void DeleteZivotinja_Test()
        {
            Zivotinja zivotinja = null;

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja = new Zivotinja();
                    zivotinjaRepo.Add(zivotinja);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void DeleteBolest_Test()
        {
            Bolest bolest = null;

            var bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest = new Bolest();
                    zivotinjaRepo.AddBolest(bolest);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteBolest(bolest.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);
        }

        [TestMethod]
        public void DeletePasminaZivotinje_Test()
        {
            PasminaZivotinje pasminaZivotinje = null;

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje = new PasminaZivotinje();
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void DeleteVrstaZivotinje_Test()
        {
            VrstaZivotinje vrstaZivotinje = null;

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje = new VrstaZivotinje();
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void GetAll_Test()
        {
            Zivotinja zivotinja1 = null;
            String ime1 = "čjge7rzh";
            Zivotinja zivotinja2 = null;
            String ime2 = "ydlrihg09<w8zg";
            Zivotinja zivotinja3 = null;
            String ime3 = "<kg<ir9<8wr";

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja1 = new Zivotinja() { Ime = ime1 };
                    zivotinja2 = new Zivotinja() { Ime = ime2 };
                    zivotinja3 = new Zivotinja() { Ime = ime3 };

                    zivotinjaRepo.Add(zivotinja1);
                    zivotinjaRepo.Add(zivotinja2);
                    zivotinjaRepo.Add(zivotinja3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 3);

            Zivotinja zivotinjaTest1 = zivotinjaList[0];
            Zivotinja zivotinjaTest2 = zivotinjaList[1];
            Zivotinja zivotinjaTest3 = zivotinjaList[2];
            Assert.AreEqual(zivotinjaTest1.Ime, ime1);
            Assert.AreEqual(zivotinjaTest2.Ime, ime2);
            Assert.AreEqual(zivotinjaTest3.Ime, ime3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja1.Id);
                    zivotinjaRepo.Delete(zivotinja2.Id);
                    zivotinjaRepo.Delete(zivotinja3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void GetAllBolest_Test()
        {
            Bolest bolest1 = null;
            String naziv1 = "yrp9ug30";
            Bolest bolest2 = null;
            String naziv2 = "0ac,ortšwer32";
            Bolest bolest3 = null;
            String naziv3 = "dlfortuisynbv";

            var bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest1 = new Bolest() { Naziv = naziv1 };
                    bolest2 = new Bolest() { Naziv = naziv2 };
                    bolest3 = new Bolest() { Naziv = naziv3 };
                    zivotinjaRepo.AddBolest(bolest1);
                    zivotinjaRepo.AddBolest(bolest2);
                    zivotinjaRepo.AddBolest(bolest3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 3);

            Bolest bolestTest1 = bolestList[0];
            Bolest bolestTest2 = bolestList[1];
            Bolest bolestTest3 = bolestList[2];
            Assert.AreEqual(bolestTest1.Naziv, naziv1);
            Assert.AreEqual(bolestTest2.Naziv, naziv2);
            Assert.AreEqual(bolestTest3.Naziv, naziv3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteBolest(bolest1.Id);
                    zivotinjaRepo.DeleteBolest(bolest2.Id);
                    zivotinjaRepo.DeleteBolest(bolest3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);
        }

        [TestMethod]
        public void GetAllByVlasnikId_Test()
        {
            Vlasnik vlasnik1 = null;
            String imeVlasnik1 = "21tageyg34t";
            Vlasnik vlasnik2 = null;
            String imeVlasnik2 = "<sekjg3r093t";

            Zivotinja zivotinja1 = null;
            String imeZivotinja1 = "<kdfuwer<lk";
            Zivotinja zivotinja2 = null;
            String imeZivotinja2 = "aifufszfuzsf";
            Zivotinja zivotinja3 = null;
            String imeZivotinja3 = "d9aw89afe";

            var vlasnikList = vlasnikRepo.GetAll();
            Assert.AreEqual(vlasnikList.Count, 0);

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vlasnik1 = new Vlasnik() { Ime = imeVlasnik1 };
                    vlasnik2 = new Vlasnik() { Ime = imeVlasnik2 };
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

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja1 = new Zivotinja() { Ime = imeZivotinja1, Vlasnik = vlasnik1 };
                    zivotinja2 = new Zivotinja() { Ime = imeZivotinja2, Vlasnik = vlasnik1 };
                    zivotinja3 = new Zivotinja() { Ime = imeZivotinja3, Vlasnik = vlasnik2 };
                    zivotinjaRepo.Add(zivotinja1);
                    zivotinjaRepo.Add(zivotinja2);
                    zivotinjaRepo.Add(zivotinja3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 3);

            zivotinjaList = zivotinjaRepo.GetAllByVlasnikId(vlasnik1.Id);
            Assert.AreEqual(zivotinjaList.Count, 2);

            Zivotinja zivotinjaTest1 = zivotinjaList[0];
            Zivotinja zivotinjaTest2 = zivotinjaList[1];

            Assert.AreEqual(zivotinjaTest1.Ime, imeZivotinja1);
            Assert.AreEqual(zivotinjaTest1.Vlasnik.Ime, imeVlasnik1);

            Assert.AreEqual(zivotinjaTest2.Ime, imeZivotinja2);
            Assert.AreEqual(zivotinjaTest2.Vlasnik.Ime, imeVlasnik1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja1.Id);
                    zivotinjaRepo.Delete(zivotinja2.Id);
                    zivotinjaRepo.Delete(zivotinja3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

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
        public void GetAllPasminaZivotinje_Test()
        {
            PasminaZivotinje pasminaZivotinje1 = null;
            String naziv1 = "agrrhzrj";
            PasminaZivotinje pasminaZivotinje2 = null;
            String naziv2 = "<we8fy9szg";
            PasminaZivotinje pasminaZivotinje3 = null;
            String naziv3 = "disfui<ttaw4r";

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje1 = new PasminaZivotinje() { Naziv = naziv1 };
                    pasminaZivotinje2 = new PasminaZivotinje() { Naziv = naziv2 };
                    pasminaZivotinje3 = new PasminaZivotinje() { Naziv = naziv3 };
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje1);
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje2);
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 3);

            PasminaZivotinje pasminaZivotinjeTest1 = pasminaZivotinjeList[0];
            PasminaZivotinje pasminaZivotinjeTest2 = pasminaZivotinjeList[1];
            PasminaZivotinje pasminaZivotinjeTest3 = pasminaZivotinjeList[2];

            Assert.AreEqual(pasminaZivotinjeTest1.Naziv, naziv1);
            Assert.AreEqual(pasminaZivotinjeTest2.Naziv, naziv2);
            Assert.AreEqual(pasminaZivotinjeTest3.Naziv, naziv3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje1.Id);
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje2.Id);
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void GetAllPasminaZivotinjeByVrstaZivotinje_Test()
        {
            PasminaZivotinje pasminaZivotinje1 = null;
            String nazivPasmine1 = "<gfj89ag9ei"; 
            PasminaZivotinje pasminaZivotinje2 = null;
            String nazivPasmine2 = "fw8ef<7sfzsydf";
            PasminaZivotinje pasminaZivotinje3 = null;
            String nazivPasmine3 = "fhfizgf6er32";

            VrstaZivotinje vrstaZivotinje1 = null;
            String nazivVrste1 = "rgmi<sjddhf";
            VrstaZivotinje vrstaZivotinje2 = null;
            String nazivVrste2 = "ysgjuyhbgfcsa";

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje1 = new VrstaZivotinje() { Naziv = nazivVrste1 };
                    vrstaZivotinje2 = new VrstaZivotinje() { Naziv = nazivVrste2 };
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje1);
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 2);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje1 = new PasminaZivotinje() { Naziv = nazivPasmine1, VrstaZivotinje = vrstaZivotinje1 };
                    pasminaZivotinje2 = new PasminaZivotinje() { Naziv = nazivPasmine2, VrstaZivotinje = vrstaZivotinje1 };
                    pasminaZivotinje3 = new PasminaZivotinje() { Naziv = nazivPasmine3, VrstaZivotinje = vrstaZivotinje2 };
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje1);
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje2);
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 3);

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinjeByVrstaZivotinje(vrstaZivotinje1);
            Assert.AreEqual(pasminaZivotinjeList.Count, 2);

            PasminaZivotinje pasminaZivotinjeTest1 = pasminaZivotinjeList[0];
            PasminaZivotinje pasminaZivotinjeTest2 = pasminaZivotinjeList[1];

            Assert.AreEqual(pasminaZivotinjeTest1.Naziv, nazivPasmine1);
            Assert.AreEqual(pasminaZivotinjeTest1.VrstaZivotinje, vrstaZivotinje1);

            Assert.AreEqual(pasminaZivotinjeTest2.Naziv, nazivPasmine2);
            Assert.AreEqual(pasminaZivotinjeTest2.VrstaZivotinje, vrstaZivotinje1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje1.Id);
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje2.Id);
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje1.Id);
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void GetAllVrstaZivotinje_Test()
        {
            VrstaZivotinje vrstaZivotinje1 = null;
            String naziv1 = "aorzugi<szvds";
            VrstaZivotinje vrstaZivotinje2 = null;
            String naziv2 = "d<jicvbšsef";

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje1 = new VrstaZivotinje() { Naziv = naziv1 };
                    vrstaZivotinje2 = new VrstaZivotinje() { Naziv = naziv2 };
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje1);
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 2);

            VrstaZivotinje vrstaZivotinjeTest1 = vrstaZivotinjeList[0];
            VrstaZivotinje vrstaZivotinjeTest2 = vrstaZivotinjeList[1];

            Assert.AreEqual(vrstaZivotinjeTest1.Naziv, naziv1);
            Assert.AreEqual(vrstaZivotinjeTest2.Naziv, naziv2);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje1.Id);
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void GetBolestById()
        {
            Bolest bolest1 = null;
            String naziv1 = "yčrgur8g2";
            Bolest bolest2 = null;
            String naziv2 = "y0uyftvz<ff";

            var bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest1 = new Bolest() { Naziv = naziv1 };
                    bolest2 = new Bolest() { Naziv = naziv2 };
                    zivotinjaRepo.AddBolest(bolest1);
                    zivotinjaRepo.AddBolest(bolest2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 2);

            Bolest bolestTest = zivotinjaRepo.GetBolestById(bolest1.Id);
            Assert.AreEqual(bolestTest.Naziv, naziv1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteBolest(bolest1.Id);
                    zivotinjaRepo.DeleteBolest(bolest2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);
        }

        [TestMethod]
        public void GetByBrojCipa()
        {
            Zivotinja zivotinja1 = null;
            String brojCipa1 = "čro<sfeuoy8zf";
            String ime1 = "<esf<8ezf87yg";

            Zivotinja zivotinja2 = null;
            String brojCipa2 = "f<es8f923fw";
            String ime2 = "2d832lsačsdfso";

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja1 = new Zivotinja() { BrojCipa = brojCipa1, Ime = ime1 };
                    zivotinja2 = new Zivotinja() { BrojCipa = brojCipa2, Ime = ime2 };
                    zivotinjaRepo.Add(zivotinja1);
                    zivotinjaRepo.Add(zivotinja2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 2);

            Zivotinja zivotinjaTest = zivotinjaRepo.GetByBrojCipa(brojCipa1);
            Assert.AreEqual(zivotinjaTest.Ime, ime1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja1.Id);
                    zivotinjaRepo.Delete(zivotinja2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void GetById_Test()
        {
            Zivotinja zivotinja1 = null;
            String ime1 = "lk<jirwr3r2";

            Zivotinja zivotinja2 = null;
            String ime2 = "lijeglyjsggy";

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja1 = new Zivotinja() { Ime = ime1 };
                    zivotinja2 = new Zivotinja() { Ime = ime2 };
                    zivotinjaRepo.Add(zivotinja1);
                    zivotinjaRepo.Add(zivotinja2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 2);

            Zivotinja zivotinjaTest1 = zivotinjaRepo.GetById(zivotinja1.Id);
            Assert.AreEqual(zivotinjaTest1.Ime, ime1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja1.Id);
                    zivotinjaRepo.Delete(zivotinja2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void GetPasminaZivotinjeById_Test()
        {
            PasminaZivotinje pasminaZivotinje1 = null;
            String naziv1 = "f<s9f,t23t2";

            PasminaZivotinje pasminaZivotinje2 = null;
            String naziv2 = "lsouvigzbebr";

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje1 = new PasminaZivotinje() { Naziv = naziv1 };
                    pasminaZivotinje2 = new PasminaZivotinje() { Naziv = naziv2 };
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje1);
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 2);

            PasminaZivotinje pasminaZivotinjeTest = zivotinjaRepo.GetPasminaZivotinjeById(pasminaZivotinje1.Id);
            Assert.AreEqual(pasminaZivotinjeTest.Naziv, naziv1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje1.Id);
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void GetVrstaZivotinjeById_Test()
        {
            VrstaZivotinje vrstaZivotinje1 = null;
            String naziv1 = "kisjurfhszasd";

            VrstaZivotinje vrstaZivotinje2 = null;
            String naziv2 = "0adi9afuačowkga";

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje1 = new VrstaZivotinje() { Naziv = naziv1 };
                    vrstaZivotinje2 = new VrstaZivotinje() { Naziv = naziv2 };
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje1);
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 2);

            VrstaZivotinje vrstaZivotinjeTest = zivotinjaRepo.GetVrstaZivotinjeById(vrstaZivotinje1.Id);
            Assert.AreEqual(vrstaZivotinjeTest.Naziv, naziv1);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje1.Id);
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void Update_Test()
        {
            Zivotinja zivotinja = null;
            String oldName = "skeug98eyugeh";
            String newName = "yligiyszg6ywg";

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja = new Zivotinja() { Ime = oldName };
                    zivotinjaRepo.Add(zivotinja);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 1);

            Zivotinja zivotinjaTest = zivotinjaList[0];
            Assert.AreEqual(zivotinjaTest.Ime, oldName);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinja.Ime = newName;
                    zivotinjaRepo.Update(zivotinja);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 1);

            zivotinjaTest = zivotinjaList[0];
            Assert.AreEqual(zivotinjaTest.Ime, newName);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.Delete(zivotinja.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);
        }

        [TestMethod]
        public void UpdateBolest_Test()
        {
            Bolest bolest = null;
            String oldNaziv = "fjfou<af<7zg";
            String newNaziv = "<FČko8<zug9<wg";

            var bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest = new Bolest() { Naziv = oldNaziv };
                    zivotinjaRepo.AddBolest(bolest);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 1);

            Bolest bolestTest = bolestList[0];
            Assert.AreEqual(bolestTest.Naziv, oldNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    bolest.Naziv = newNaziv;
                    zivotinjaRepo.UpdateBolest(bolest);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 1);

            bolestTest = bolestList[0];
            Assert.AreEqual(bolestTest.Naziv, newNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteBolest(bolest.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            bolestList = zivotinjaRepo.GetAllBolest();
            Assert.AreEqual(bolestList.Count, 0);
        }

        [TestMethod]
        public void UpdatePasminaZivotinje_Test()
        {
            PasminaZivotinje pasminaZivotinje = null;
            String oldNaziv = "<ilf<fz<wef<wf";
            String newNaziv = "ofo<ise98<fef<f";

            var pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje = new PasminaZivotinje() { Naziv = oldNaziv };
                    zivotinjaRepo.AddPasminaZivotinje(pasminaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 1);

            PasminaZivotinje pasminaZivotinjeTest = pasminaZivotinjeList[0];
            Assert.AreEqual(pasminaZivotinjeTest.Naziv, oldNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    pasminaZivotinje.Naziv = newNaziv;
                    zivotinjaRepo.UpdatePasminaZivotinje(pasminaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 1);

            pasminaZivotinjeTest = pasminaZivotinjeList[0];
            Assert.AreEqual(pasminaZivotinjeTest.Naziv, newNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeletePasminaZivotinje(pasminaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            pasminaZivotinjeList = zivotinjaRepo.GetAllPasminaZivotinje();
            Assert.AreEqual(pasminaZivotinjeList.Count, 0);
        }

        [TestMethod]
        public void UpdateVrstaZivotinje_Test()
        {
            VrstaZivotinje vrstaZivotinje = null;
            String oldNaziv = "<seijfyrszg98yg";
            String newNaziv = "<sigfjighgr<wg<";

            var vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje = new VrstaZivotinje() { Naziv = oldNaziv };
                    zivotinjaRepo.AddVrstaZivotinje(vrstaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 1);

            VrstaZivotinje vrstaZivotinjeTest = vrstaZivotinjeList[0];
            Assert.AreEqual(vrstaZivotinjeTest.Naziv, oldNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZivotinje.Naziv = newNaziv;
                    zivotinjaRepo.UpdateVrstaZivotinje(vrstaZivotinje);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 1);

            vrstaZivotinjeTest = vrstaZivotinjeList[0];
            Assert.AreEqual(vrstaZivotinjeTest.Naziv, newNaziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zivotinjaRepo.DeleteVrstaZivotinje(vrstaZivotinje.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZivotinjeList = zivotinjaRepo.GetAllVrstaZivotinje();
            Assert.AreEqual(vrstaZivotinjeList.Count, 0);
        }
    }
}

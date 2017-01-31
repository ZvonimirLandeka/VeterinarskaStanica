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
    public class TerminRepositryTests
    {
        private TerminRepository terminRepo;
        private ZaposlenikRepository zaposlenikRepo;
        private ZivotinjaRepository zivotinjaRepo;

        public TerminRepositryTests()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.InMemory);
            terminRepo = new TerminRepository();
            zaposlenikRepo = new ZaposlenikRepository();
            zivotinjaRepo = new ZivotinjaRepository();
        }

        [TestMethod]
        public void AddTermin_Test()
        {
            Termin termin = null;
            String opis = "Pregled";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count,0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin = new Termin() { Opis = opis};
                    terminRepo.Add(termin);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Termin terminTest = terminList[0];
            Assert.AreEqual(terminList.Count, 1);
            Assert.AreEqual(terminTest.Opis, opis);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);
        }

        [TestMethod]
        public void AddLijek_Test()
        {
            Lijek lijek = null;
            String naziv = "Penicilin";

            var lijekLista = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekLista.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek = new Lijek() { Naziv = naziv };
                    terminRepo.AddLijek(lijek);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekLista = terminRepo.GetAllLijek();
            Lijek lijekTest = lijekLista[0];
            Assert.AreEqual(lijekLista.Count, 1);
            Assert.AreEqual(lijek.Naziv, lijekTest.Naziv);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteLijek(lijek.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekLista = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekLista.Count, 0);
        }

        [TestMethod]
        public void AddVrstaZahvata_Test()
        {
            VrstaZahvata vrstaZahvata = null;
            String naziv = "Operacija";

            var vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata = new VrstaZahvata() { Naziv = naziv};
                    terminRepo.AddVrstaZahvata(vrstaZahvata);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            VrstaZahvata vrstaZahvataTest = vrstaZahvataList[0];
            Assert.AreEqual(vrstaZahvataList.Count, 1);
            Assert.AreEqual(vrstaZahvata.Naziv, vrstaZahvataTest.Naziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);
        }

        [TestMethod]
        public void DeleteTermin_Test()
        {
            Termin termin = null;
            String opis = "aef4tsd";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin = new Termin() { Opis = opis };
                    terminRepo.Add(termin);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Termin terminTest = terminList[0];
            Assert.AreEqual(terminList.Count, 1);
            Assert.AreEqual(termin.Opis, terminTest.Opis);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);
        }

        [TestMethod]
        public void DeleteLijek_Test()
        {
            Lijek lijek = null;
            String naziv = "a4tygydg";

            var lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek = new Lijek() { Naziv = naziv };
                    terminRepo.AddLijek(lijek);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteLijek(lijek.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);
        }

        [TestMethod]
        public void DeleteVrstaZahvata_Test()
        {
            VrstaZahvata vrstaZahvata = null;
            String naziv = "a4g4t";

            var vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata = new VrstaZahvata() { Naziv = naziv};
                    terminRepo.AddVrstaZahvata(vrstaZahvata);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);
        }

        [TestMethod]
        public void GetAll_Test()
        {
            Termin termin1 = null;
            Termin termin2 = null;
            Termin termin3 = null;
            String opis1 = "43qf<sef4w";
            String opis2 = "wegpvy98dfv";
            String opis3 = "gaoy8zfbz";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin1 = new Termin() { Opis = opis1 };
                    termin2 = new Termin() { Opis = opis2 };
                    termin3 = new Termin() { Opis = opis3 };
                    terminRepo.Add(termin1);
                    terminRepo.Add(termin2);
                    terminRepo.Add(termin3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 3);
            Termin terminTest1 = terminList[0];
            Termin terminTest2 = terminList[1];
            Termin terminTest3 = terminList[2];
            Assert.AreEqual(terminTest1.Opis, opis1);
            Assert.AreEqual(terminTest2.Opis, opis2);
            Assert.AreEqual(terminTest3.Opis, opis3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin1.Id);
                    terminRepo.Delete(termin2.Id);
                    terminRepo.Delete(termin3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);
        }

        [TestMethod]
        public void GetAllByZaposlenikId()
        {
            Termin termin1 = null;
            Termin termin2 = null;
            Termin termin3 = null;
            Zaposlenik zaposlenik1 = null;
            Zaposlenik zaposlenik2 = null;
            String ime1 = "Rafael";
            String ime2 = "Mihael";
            

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            var zaposlenikList = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposlenikList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenik1 = new Zaposlenik() { Ime = ime1 };
                    zaposlenik2 = new Zaposlenik() { Ime = ime2 };
                    zaposlenikRepo.Add(zaposlenik1);
                    zaposlenikRepo.Add(zaposlenik2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zaposlenikList = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposlenikList.Count, 2);
            
            
            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin1 = new Termin() { Zaposlenik = zaposlenikList[0] };
                    termin2 = new Termin() { Zaposlenik = zaposlenikList[0] };
                    termin3 = new Termin() { Zaposlenik = zaposlenikList[1] };
                    terminRepo.Add(termin1);
                    terminRepo.Add(termin2);
                    terminRepo.Add(termin3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 3);

            var terminListById = terminRepo.GetAllByZaposlenikId(zaposlenik1.Id);
            Assert.AreEqual(terminListById.Count, 2);

            Termin terminTest1 = terminListById[0];
            Termin terminTest2 = terminListById[1];
            Assert.AreEqual(terminTest1.Zaposlenik.Ime, ime1);
            Assert.AreEqual(terminTest2.Zaposlenik.Ime, ime1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin1.Id);
                    terminRepo.Delete(termin2.Id);
                    terminRepo.Delete(termin3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    zaposlenikRepo.Delete(zaposlenik1.Id);
                    zaposlenikRepo.Delete(zaposlenik2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            zaposlenikList = zaposlenikRepo.GetAll();
            Assert.AreEqual(zaposlenikList.Count, 0);
        }

        [TestMethod]
        public void GetAllByZivotinjaId_Test()
        {
            Termin termin1 = null;
            Termin termin2 = null;
            Termin termin3 = null;
            Zivotinja zivotinja1 = null;
            Zivotinja zivotinja2 = null;
            String ime1 = "Metatron";
            String ime2 = "Abadon";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            var zivotinjaList = zivotinjaRepo.GetAll();
            Assert.AreEqual(zivotinjaList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
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

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin1 = new Termin() { Zivotinja = zivotinja1 };
                    termin2 = new Termin() { Zivotinja = zivotinja1 };
                    termin3 = new Termin() { Zivotinja = zivotinja2 };
                    terminRepo.Add(termin1);
                    terminRepo.Add(termin2);
                    terminRepo.Add(termin3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 3);

            var terminListByZivotinjaId = terminRepo.GetAllByZivotinjaId(zivotinja1.Id);
            Assert.AreEqual(terminListByZivotinjaId.Count, 2);
            Assert.AreEqual(terminListByZivotinjaId[0].Zivotinja.Ime, ime1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin1.Id);
                    terminRepo.Delete(termin2.Id);
                    terminRepo.Delete(termin3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
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
        public void GetAllLijek_Test()
        {
            Lijek lijek1 = null;
            Lijek lijek2 = null;
            Lijek lijek3 = null;
            String naziv1 = "t4fysfd";
            String naziv2 = "z54zygrg";
            String naziv3 = "21r3zetgtg";

            var listLijek = terminRepo.GetAllLijek();
            Assert.AreEqual(listLijek.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek1 = new Lijek() { Naziv = naziv1 };
                    lijek2 = new Lijek() { Naziv = naziv2 };
                    lijek3 = new Lijek() { Naziv = naziv3 };
                    terminRepo.AddLijek(lijek1);
                    terminRepo.AddLijek(lijek2);
                    terminRepo.AddLijek(lijek3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            listLijek = terminRepo.GetAllLijek();
            Assert.AreEqual(listLijek.Count, 3);
            Lijek lijekTest1 = listLijek[0];
            Lijek lijekTest2 = listLijek[1];
            Lijek lijekTest3 = listLijek[2];

            Assert.AreEqual(lijekTest1.Naziv, naziv1);
            Assert.AreEqual(lijekTest2.Naziv, naziv2);
            Assert.AreEqual(lijekTest3.Naziv, naziv3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteLijek(lijek1.Id);
                    terminRepo.DeleteLijek(lijek2.Id);
                    terminRepo.DeleteLijek(lijek3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            listLijek = terminRepo.GetAllLijek();
            Assert.AreEqual(listLijek.Count, 0);
        }

        [TestMethod]
        public void GetAllVrstaZahvata_Test()
        {
            VrstaZahvata vrstaZahvata1 = null;
            VrstaZahvata vrstaZahvata2 = null;
            VrstaZahvata vrstaZahvata3 = null;
            String naziv1 = "321rgfvsez5";
            String naziv2 = "tr43zj5e56j";
            String naziv3 = "h5ej6e7k";

            var vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);

            using (var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata1 = new VrstaZahvata() { Naziv = naziv1 };
                    vrstaZahvata2 = new VrstaZahvata() { Naziv = naziv2 };
                    vrstaZahvata3 = new VrstaZahvata() { Naziv = naziv3 };
                    terminRepo.AddVrstaZahvata(vrstaZahvata1);
                    terminRepo.AddVrstaZahvata(vrstaZahvata2);
                    terminRepo.AddVrstaZahvata(vrstaZahvata3);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 3);

            VrstaZahvata vrstaZahvataTest1 = vrstaZahvataList[0];
            VrstaZahvata vrstaZahvataTest2 = vrstaZahvataList[1];
            VrstaZahvata vrstaZahvataTest3 = vrstaZahvataList[2];

            Assert.AreEqual(vrstaZahvataTest1.Naziv, naziv1);
            Assert.AreEqual(vrstaZahvataTest2.Naziv, naziv2);
            Assert.AreEqual(vrstaZahvataTest3.Naziv, naziv3);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata1.Id);
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata2.Id);
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata3.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);
        }

        [TestMethod]
        public void GetById_Test()
        {
            Termin termin1 = null;
            Termin termin2 = null;
            String opis1 = "aorues87zh";
            String opis2 = "lietjoeithj";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin1 = new Termin() { Opis = opis1 };
                    termin2 = new Termin() { Opis = opis2 };
                    terminRepo.Add(termin1);
                    terminRepo.Add(termin2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 2);

            Termin terminTest = terminRepo.GetById(termin1.Id);
            Assert.AreEqual(terminTest.Opis, opis1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.Delete(termin1.Id);
                    terminRepo.Delete(termin2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);
        }

        [TestMethod]
        public void GetLijekById_Test()
        {
            Lijek lijek1 = null;
            Lijek lijek2 = null;
            String naziv1 = "a3tag34";
            String naziv2 = "aperi09teih0";

            var lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek1 = new Lijek() { Naziv = naziv1 };
                    lijek2 = new Lijek() { Naziv = naziv2 };
                    terminRepo.AddLijek(lijek1);
                    terminRepo.AddLijek(lijek2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 2);

            Lijek lijekTest = terminRepo.GetLijekById(lijek1.Id);
            Assert.AreEqual(lijekTest.Naziv, naziv1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteLijek(lijek1.Id);
                    terminRepo.DeleteLijek(lijek2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);
        }

        [TestMethod]
        public void GetVrstaZahvataById_Test()
        {
            VrstaZahvata vrstaZahvata1 = null;
            VrstaZahvata vrstaZahvata2 = null;
            String naziv1 = "jghj9srtn0s";
            String naziv2 = "a34te0ig0hjt";

            var vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0); 

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata1 = new VrstaZahvata() { Naziv = naziv1 };
                    vrstaZahvata2 = new VrstaZahvata() { Naziv = naziv2 };
                    terminRepo.AddVrstaZahvata(vrstaZahvata1);
                    terminRepo.AddVrstaZahvata(vrstaZahvata2);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 2);

            VrstaZahvata vrstaZahvataTest = terminRepo.GetVrstaZahvataById(vrstaZahvata1.Id);
            Assert.AreEqual(vrstaZahvataTest.Naziv, naziv1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata1.Id);
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata2.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);
        }

        [TestMethod]
        public void UpdateTermin_Test()
        {
            Termin termin = null;
            String oldOpis = "areoihg98rea";
            String newOpis = "orug0a8re";

            var terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin = new Termin() { Opis = oldOpis};
                    terminRepo.Add(termin);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    termin.Opis = newOpis;
                    terminRepo.Update(termin);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            terminList = terminRepo.GetAll();
            Assert.AreEqual(terminList.Count, 1);

            Termin terminTest = terminList[0];
            Assert.AreEqual(terminTest.Opis, newOpis);
        }

        [TestMethod]
        public void UpdateLijek_Test()
        {
            Lijek lijek = null;
            String oldNaziv = "q43zqz53";
            String newNaziv = "tq3zu64u";

            var lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek = new Lijek() { Naziv = oldNaziv};
                    terminRepo.AddLijek(lijek);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    lijek.Naziv = newNaziv;
                    terminRepo.UpdateLijek(lijek);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 1);

            Lijek lijekTest = lijekList[0];
            Assert.AreEqual(lijekTest.Naziv, newNaziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteLijek(lijek.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            lijekList = terminRepo.GetAllLijek();
            Assert.AreEqual(lijekList.Count, 0);
        }

        [TestMethod]
        public void UpdateVrstaZahvata_Test()
        {
            VrstaZahvata vrstaZahvata = null;
            String oldNaziv = "34z35zhfh";
            String newNaziv = "aephtjngf9";

            var vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata = new VrstaZahvata() { Naziv = oldNaziv };
                    terminRepo.AddVrstaZahvata(vrstaZahvata);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 1);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    vrstaZahvata.Naziv = newNaziv;
                    terminRepo.UpdateVrstaZahvata(vrstaZahvata);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 1);

            VrstaZahvata vrstaZahvataTest = vrstaZahvataList[0];
            Assert.AreEqual(vrstaZahvataTest.Naziv, newNaziv);

            using ( var transaction = NHibernateHelper.CurrentSession.BeginTransaction())
            {
                try
                {
                    terminRepo.DeleteVrstaZahvata(vrstaZahvata.Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }

            vrstaZahvataList = terminRepo.GetAllVrstaZahvata();
            Assert.AreEqual(vrstaZahvataList.Count, 0);

        }
    }
}

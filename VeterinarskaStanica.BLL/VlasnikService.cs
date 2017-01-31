using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Repositories;

namespace VeterinarskaStanica.BLL
{
    public class VlasnikService
    {
        private IVlasnikRepository repository;
        private ISession ActiveSession { get { return NHibernateHelper.CurrentSession; } }

        public VlasnikService()
        {
            repository = new VlasnikRepository();
        }

        public bool CheckLogin(string KorisnickoIme, string Lozinka)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                Vlasnik Vlasnik = repository.GetByKorisnickoIme(KorisnickoIme);

                if (Vlasnik?.Lozinka == Lozinka)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Add(Vlasnik noviVlasnik)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    var postojeciVlasnici = repository.GetAll();
                    var ZauzetoKorisnickoIme = postojeciVlasnici.Exists(x => x.KorisnickoIme == noviVlasnik.KorisnickoIme);

                    if (noviVlasnik.KorisnickoIme?.Length > 0 && ZauzetoKorisnickoIme)
                    {
                        throw new Exception("Vlasnik sa zadanim korisničkim imenom već postoji.");
                    }

                    if (noviVlasnik.Lozinka != null)
                    {
                        noviVlasnik.Lozinka = noviVlasnik.Lozinka.GetHashCode().ToString();
                    }

                    repository.Add(noviVlasnik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Update(Vlasnik Vlasnik)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    var stariVlasnik = repository.GetById(Vlasnik.Id);

                    var postojeciVlasnici = repository.GetAll().Where(x => x.Id != Vlasnik.Id).ToList();
                    var ZauzetoKorisnickoIme = postojeciVlasnici.Exists(x => x.KorisnickoIme == Vlasnik.KorisnickoIme);

                    if (Vlasnik.KorisnickoIme?.Length > 0 && ZauzetoKorisnickoIme)
                    {
                        throw new Exception("Zaposlenik sa zadanim korisničkim imenom već postoji.");
                    }

                    if (Vlasnik.Lozinka?.Length > 0 && Vlasnik.Lozinka != stariVlasnik.Lozinka)
                    {
                        Vlasnik.Lozinka = Vlasnik.Lozinka.GetHashCode().ToString();
                    }

                    repository.Update(Vlasnik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(int Id)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    repository.Delete(Id);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<Vlasnik> GetAll()
        {
            var postojeciVlasnici = repository.GetAll();

            return postojeciVlasnici;
        }

        public Vlasnik GetIdByKorisnickoIme(string KorisnickoIme)
        {
            return repository.GetByKorisnickoIme(KorisnickoIme);
        }
    }
}

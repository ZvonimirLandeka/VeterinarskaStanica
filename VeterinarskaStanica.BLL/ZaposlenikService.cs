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
    public class ZaposlenikService
    {
        private IZaposlenikRepository repository;
        private ISession ActiveSession { get { return NHibernateHelper.CurrentSession; } }

        public ZaposlenikService()
        {
            repository = new ZaposlenikRepository();
        }

        public bool CheckLogin(string KorisnickoIme, string Lozinka)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                Zaposlenik zaposlenik = repository.GetByKorisnickoIme(KorisnickoIme);

                if (zaposlenik?.Lozinka == Lozinka)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Zaposlenik GetByKorisnickoIme(string KorisnickoIme)
        {
            return repository.GetByKorisnickoIme(KorisnickoIme);
        }

        public void Add(Zaposlenik noviZaposlenik)
        {
            using(var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    var postojeciZaposlenici = repository.GetAll();
                    var ZauzetoKorisnickoIme = postojeciZaposlenici.Exists(x => x.KorisnickoIme == noviZaposlenik.KorisnickoIme);

                    if (noviZaposlenik.KorisnickoIme?.Length > 0 && ZauzetoKorisnickoIme)
                    {
                        throw new Exception("Zaposlenik sa zadanim korisničkim imenom već postoji.");
                    }
                    
                    if(noviZaposlenik.Lozinka != null)
                    {
                        noviZaposlenik.Lozinka = noviZaposlenik.Lozinka.GetHashCode().ToString();
                    }

                    repository.Add(noviZaposlenik);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Update(Zaposlenik zaposlenik)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    var stariZaposlenik = repository.GetById(zaposlenik.Id);

                    var postojeciZaposlenici = repository.GetAll().Where(x => x.Id != zaposlenik.Id).ToList();
                    var ZauzetoKorisnickoIme = postojeciZaposlenici.Exists(x => x.KorisnickoIme == zaposlenik.KorisnickoIme);

                    if (zaposlenik.KorisnickoIme?.Length > 0 && ZauzetoKorisnickoIme)
                    {
                        throw new Exception("Zaposlenik sa zadanim korisničkim imenom već postoji.");
                    }

                    if (zaposlenik.Lozinka?.Length > 0 && zaposlenik.Lozinka != stariZaposlenik.Lozinka)
                    {
                        zaposlenik.Lozinka = zaposlenik.Lozinka.GetHashCode().ToString();
                    }

                    repository.Update(zaposlenik);
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

        public List<Zaposlenik> GetAll()
        {
            var postojeciZaposlenici = repository.GetAll();

            return postojeciZaposlenici;
        }
    }
}

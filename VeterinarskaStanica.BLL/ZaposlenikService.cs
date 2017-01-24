using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.DAL.Repository;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.BLL
{
    public class ZaposlenikService
    {
        private ZaposlenikRepository repository;
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

        public void Create(Zaposlenik noviZaposlenik)
        {
            using(var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    var postojeciZaposlenici = repository.GetAll();

                    if(postojeciZaposlenici.Exists(x => x.KorisnickoIme == noviZaposlenik.KorisnickoIme))
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

        public List<Zaposlenik> GetAll()
        {
            var postojeciZaposlenici = repository.GetAll();

            return postojeciZaposlenici;
        }
    }
}

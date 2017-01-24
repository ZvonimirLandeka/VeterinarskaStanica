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

        public bool CheckLogin(string KorisnickoIme, string Lozinka)
        {
            ISession session = NHibernateHelper.OpenSession();
            repository = new ZaposlenikRepository(session);
            using (var transaction = session.BeginTransaction())
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

    }
}

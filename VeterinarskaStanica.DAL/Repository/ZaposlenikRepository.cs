using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Repositories;

namespace VeterinarskaStanica.DAL.Repository
{
    public class ZaposlenikRepository : IZaposlenikRepository
    {
        private ISession _session
        {
            get { return NHibernateHelper.CurrentSession; }
        }
        public ZaposlenikRepository()
        {

        }

        public bool Add(Zaposlenik Zaposlenik)
        {
            try
            {
                _session.Save(Zaposlenik);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddVrstaZaposlenika(VrstaZaposlenika VrstaZaposlenika)
        {
            try
            {
                _session.Save(VrstaZaposlenika);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(int Id)
        {
            try
            {
                Zaposlenik Zaposlenik = _session.Get<Zaposlenik>(Id);
                if (Zaposlenik != null)
                {
                    _session.Delete(Zaposlenik);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteVrstaZaposlenika(int Id)
        {
            try
            {
                VrstaZaposlenika VrstaZaposlenika = _session.Get<VrstaZaposlenika>(Id);
                if (VrstaZaposlenika != null)
                {
                    _session.Delete(VrstaZaposlenika);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Zaposlenik> GetAll()
        {
            return _session.Query<Zaposlenik>().ToList();

        }

        public List<VrstaZaposlenika> GetAllVrstaZaposlenika()
        {
            return _session.Query<VrstaZaposlenika>().ToList();

        }

        public Zaposlenik GetById(int Id)
        {
            return _session.Get<Zaposlenik>(Id);
        }

        public Zaposlenik GetByKorisnickoIme(string KorisnickoIme)
        {
            return _session.Query<Zaposlenik>().First(x => x.KorisnickoIme == KorisnickoIme);

        }

        public Zaposlenik GetByOib(string OIB)
        {
            return _session.Query<Zaposlenik>().First(x => x.OIB == OIB);
        }

        public VrstaZaposlenika GetVrstaZaposlenikaById(int Id)
        {
            return _session.Get<VrstaZaposlenika>(Id);
        }

        public bool Update(Zaposlenik Zaposlenik)
        {
            try
            {
                _session.Update(Zaposlenik);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateVrstaZaposlenika(VrstaZaposlenika VrstaZaposlenika)
        {
            try
            {
                _session.Update(VrstaZaposlenika);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

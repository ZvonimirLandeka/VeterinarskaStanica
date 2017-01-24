using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Repositories;

namespace VeterinarskaStanica.DAL.Repository
{
    public class VlasnikRepository : IVlasnikRepository
    {
        private ISession _session
        {
            get { return NHibernateHelper.CurrentSession; }
        }
        public VlasnikRepository()
        {

        }

        public bool Add(Vlasnik Vlasnik)
        {
            try
            {
                _session.Save(Vlasnik);
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
                Vlasnik Vlasnik = _session.Get<Vlasnik>(Id);
                if (Vlasnik != null)
                {
                    _session.Delete(Vlasnik);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Vlasnik> GetAll()
        {
            return _session.Query<Vlasnik>().ToList();
        }

        public Vlasnik GetById(int Id)
        {
            return _session.Get<Vlasnik>(Id);
        }

        public Vlasnik GetByKorisnickoIme(string KorisnickoIme)
        {
            return _session.Query<Vlasnik>().First(x=>x.KorisnickoIme==KorisnickoIme);
        }

        public Vlasnik GetByOib(string OIB)
        {
            return _session.Query<Vlasnik>().First(x => x.OIB == OIB);
        }

        public bool Update(Vlasnik Vlasnik)
        {
            try
            {
                _session.Update(Vlasnik);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

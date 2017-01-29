using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Repositories;
using NHibernate;
using NHibernate.Linq;

namespace VeterinarskaStanica.DAL.Repository
{
    public class TerminRepository : ITerminRepository
    {
        private ISession _session
        {
            get { return NHibernateHelper.CurrentSession; }
        }
        public TerminRepository()
        {

        }
        public bool Add(Termin Termin)
        {
            try
            {
                _session.Save(Termin);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddLijek(Lijek Lijek)
        {
            try
            {
                _session.Save(Lijek);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddVrstaZahvata(VrstaZahvata VrstaZahvata)
        {
            try
            {
                _session.Save(VrstaZahvata);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public VrstaTermina GetVrstaTerminaById(int idVrstaTermina)
        {
            return _session.Get<VrstaTermina>(idVrstaTermina);
        }

        public bool Delete(int Id)
        {
            try
            {
                Termin Termin = _session.Get<Termin>(Id);
                if (Termin != null)
                {
                    _session.Delete(Termin);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteLijek(int Id)
        {
            try
            {
                Lijek Lijek = _session.Get<Lijek>(Id);
                if (Lijek != null)
                {
                    _session.Delete(Lijek);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteVrstaZahvata(int Id)
        {
            try
            {
                VrstaZahvata VrstaZahvata = _session.Get<VrstaZahvata>(Id);
                if (VrstaZahvata != null)
                {
                    _session.Delete(VrstaZahvata);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Termin> GetAll()
        {
            return _session.Query<Termin>().ToList();
        }

        public List<Termin> GetAllByZaposlenikId(int Id)
        {
            return _session.Query<Termin>().Where(x=>x.Zaposlenik.Id==Id).ToList();
        }

        public List<Termin> GetAllByZivotinjaId(int Id)
        {
            return _session.Query<Termin>().Where(x => x.Zivotinja.Id == Id).ToList();
        }

        public List<Lijek> GetAllLijek()
        {
            return _session.Query<Lijek>().ToList();
        }

        public List<VrstaZahvata> GetAllVrstaZahvata()
        {
            return _session.Query<VrstaZahvata>().ToList();
        }

        public Termin GetById(int Id)
        {
            return _session.Get<Termin>(Id);
        }

        public Lijek GetLijekById(int Id)
        {
            return _session.Get<Lijek>(Id);
        }

        public VrstaZahvata GetVrstaZahvataById(int Id)
        {
            return _session.Get<VrstaZahvata>(Id);
        }

        public bool Update(Termin Termin)
        {
            try
            {
                _session.Update(Termin);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateLijek(Lijek Lijek)
        {
            try
            {
                _session.Update(Lijek);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateVrstaZahvata(VrstaZahvata VrstaZahvata)
        {
            try
            {
                _session.Update(VrstaZahvata);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<VrstaTermina> GetAllVrstaTermina()
        {
            return _session.Query<VrstaTermina>().ToList();
        }
        public List<Termin> GetAllByVlasnikId(int idVlasnik)
        {
            return _session.Query<Termin>().Where(x => x.Zivotinja.Vlasnik.Id == idVlasnik).ToList();
        }
        public List<Termin> GetAllZatrazeniByVlasnikId(int idVlasnik)
        {
            return _session.Query<Termin>().Where(x=>x.Zivotinja.Vlasnik.Id==idVlasnik && x.Status== StatusTermina.Zatražen).ToList();
        }
        public List<Termin> GetAllOdobreniByVlasnikId(int idVlasnik)
        {
            return _session.Query<Termin>().Where(x => x.Zivotinja.Vlasnik.Id == idVlasnik && x.Status == StatusTermina.Odobren).OrderBy(x=>x.Datum).ToList();
        }
    }
}

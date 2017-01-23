using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Repositories;
using NHibernate.Linq;

namespace VeterinarskaStanica.DAL.Repository
{
    public class ZivotinjaRepository : IZivotinjaRepository
    {
        ISession _session = null;
        public ZivotinjaRepository(ISession Session)
        {
            _session = Session;
        }
        public bool Add(Zivotinja Zivotinja)
        {
            try
            {
                _session.Save(Zivotinja);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddBolest(Bolest Bolest)
        {
            try
            {
                _session.Save(Bolest);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddPasminaZivotinje(PasminaZivotinje PasminaZivotinje)
        {
            try
            {
                _session.Save(PasminaZivotinje);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddVrstaZivotinje(VrstaZivotinje VrstaZivotinje)
        {
            try
            {
                _session.Save(VrstaZivotinje);
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
                Zivotinja Zivotinja = _session.Get<Zivotinja>(Id);
                if (Zivotinja != null)
                {
                    _session.Delete(Zivotinja);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteBolest(int Id)
        {
            try
            {
                Bolest Bolest = _session.Get<Bolest>(Id);
                if (Bolest != null)
                {
                    _session.Delete(Bolest);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeletePasminaZivotinje(int Id)
        {
            try
            {
                PasminaZivotinje PasminaZivotinje = _session.Get<PasminaZivotinje>(Id);
                if (PasminaZivotinje != null)
                {
                    _session.Delete(PasminaZivotinje);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteVrstaZivotinje(int Id)
        {
            try
            {
                VrstaZivotinje VrstaZivotinje = _session.Get<VrstaZivotinje>(Id);
                if (VrstaZivotinje != null)
                {
                    _session.Delete(VrstaZivotinje);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Zivotinja> GetAll()
        {
            return _session.Query<Zivotinja>().ToList();
        }

        public List<Bolest> GetAllBolest()
        {
            return _session.Query<Bolest>().ToList();
        }

        public List<Zivotinja> GetAllByVlasnikId(int Id)
        {
            return _session.Query<Zivotinja>().Where(x=>x.Vlasnik.Id==Id).ToList();
        }

        public List<PasminaZivotinje> GetAllPasminaZivotinje()
        {
            return _session.Query<PasminaZivotinje>().ToList();
        }

        public List<VrstaZivotinje> GetAllVrstaZivotinje()
        {
            return _session.Query<VrstaZivotinje>().ToList();
        }

        public Bolest GetBolestById(int Id)
        {
            return _session.Get<Bolest>(Id);
        }

        public Zivotinja GetByBrojCipa(string BrojCipa)
        {
            return _session.Query<Zivotinja>().First(x=>x.BrojCipa.Equals(BrojCipa));
        }

        public Zivotinja GetById(int Id)
        {
            return _session.Get<Zivotinja>(Id);
        }

        public PasminaZivotinje GetPasminaZivotinjeById(int Id)
        {
            return _session.Get<PasminaZivotinje>(Id);
        }

        public VrstaZivotinje GetVrstaZivotinjeById(int Id)
        {
            return _session.Get<VrstaZivotinje>(Id);
        }

        public bool Update(Zivotinja Zivotinja)
        {
            try
            {
                _session.Update(Zivotinja);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateBolest(Bolest Bolest)
        {
            try
            {
                _session.Update(Bolest);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdatePasminaZivotinje(PasminaZivotinje PasminaZivotinje)
        {
            try
            {
                _session.Update(PasminaZivotinje);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateVrstaZivotinje(VrstaZivotinje VrstaZivotinje)
        {
            try
            {
                _session.Update(VrstaZivotinje);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

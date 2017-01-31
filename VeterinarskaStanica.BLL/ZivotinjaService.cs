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
    public class ZivotinjaService
    {
        private IZivotinjaRepository repository;
        private ISession ActiveSession { get { return NHibernateHelper.CurrentSession; } }


        public ZivotinjaService()
        {
            repository = new ZivotinjaRepository();
        }

        public List<Zivotinja> GetAll()
        {
            return repository.GetAll();
        }

        public List<PasminaZivotinje> GetPasmineByIdVrsta(int Id)
        {
            ZivotinjaRepository ZivotinjaRepository = new ZivotinjaRepository();
            return ZivotinjaRepository.GetPasmineByIdVrste(Id);
        }
        public bool Add(Zivotinja Zivotinja)
        {
            try
            {
                ISession session = NHibernateHelper.CurrentSession;
                
                using (var transaction = session.BeginTransaction())
                {
                    
                    repository.Add(Zivotinja);
                    
                    transaction.Commit();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Update(Zivotinja zivotinja)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {

                    var postojeceZivotinje = repository.GetAll().Where(x => x.Id != zivotinja.Id).ToList();
                    var BrojCipaZauzet = postojeceZivotinje.Exists(x => x.BrojCipa == zivotinja.BrojCipa);

                    if (BrojCipaZauzet)
                    {
                        throw new Exception($"Životinja sa brojem čipa: {zivotinja.BrojCipa} već postoji.");
                    }

                    repository.Update(zivotinja);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public Zivotinja GetById(int Id)
        {
            return repository.GetById(Id);
            
        }

        public List<VrstaZivotinje> GetAllVrstaZivotinje()
        {
            return repository.GetAllVrstaZivotinje();
        }

        public List<PasminaZivotinje> GetAllPasminaZivotinjeByVrstaZivotinje(VrstaZivotinje vrstaZivotinje)
        {
            return repository.GetAllPasminaZivotinjeByVrstaZivotinje(vrstaZivotinje);
        }
        public bool Delete(int Id)
        {
            try
            {
                ISession session = NHibernateHelper.CurrentSession;

                using (var transaction = session.BeginTransaction())
                {
                    repository.Delete(Id);

                    transaction.Commit();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public List<Zivotinja> GetAllByVlasnikId(int IdVlasnik)
        {
            return repository.GetAllByVlasnikId(IdVlasnik);
        }
    }
}

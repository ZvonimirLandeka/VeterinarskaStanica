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
using System.Collections;

namespace VeterinarskaStanica.BLL
{
    public class TerminService
    {
        private ITerminRepository repository;
        private ISession ActiveSession { get { return NHibernateHelper.CurrentSession; } }

        public TerminService()
        {
            repository = new TerminRepository();
        }

        public List<Termin> GetAll()
        {
            return repository.GetAll();
        }

        public List<Termin> GetAllZatrazeniByVlasnikId(int IdVlasnik)
        {
            return repository.GetAllZatrazeniByVlasnikId(IdVlasnik);
        }
        public List<Termin> GetAllOdobreniByVlasnikId(int IdVlasnik)
        {
            return repository.GetAllOdobreniByVlasnikId(IdVlasnik);
        }
        public List<Termin> GetAllByVlasnikId(int IdVlasnik)
        {
            return repository.GetAllByVlasnikId(IdVlasnik);
        }

        public bool Add(Termin Termin)
        {
            try
            {
                ISession session = NHibernateHelper.CurrentSession;

                using (var transaction = session.BeginTransaction())
                {
                    repository.Add(Termin);

                    transaction.Commit();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Termin> GetAllByIdZivotinja(int Id)
        {
            return repository.GetAllByIdZivotinja(Id);
        }

        public List<VrstaTermina> GetAllVrstaTermina()
        {
            return repository.GetAllVrstaTermina();
        }

        public VrstaTermina GetVrstaTerminaById(int idVrstaTermina)
        {
            return repository.GetVrstaTerminaById(idVrstaTermina);
        }

        public void Update(Termin Termin)
        {
            using (var transaction = ActiveSession.BeginTransaction())
            {
                try
                {
                    repository.Update(Termin);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            //using (var transaction = ActiveSession.BeginTransaction())
            //{
            //    try
            //    {
            //        repository.Update(Termin);
            //        transaction.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        transaction.Rollback();
            //        throw;
            //    }
            //}
        }

        public Termin GetById(int Id)
        {
            return repository.GetById(Id);

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

    }
}

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
    public class ZivotinjaService
    {
        private ZivotinjaRepository repository;

        public ZivotinjaService()
        {
            repository = new ZivotinjaRepository();
        }

        public List<Zivotinja> GetAll()
        {
            return repository.GetAll();
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

        public Zivotinja GetById(int Id)
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

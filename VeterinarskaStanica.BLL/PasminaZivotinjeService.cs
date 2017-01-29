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
    public class PasminaZivotinjeService
    {
        private ZivotinjaRepository ZivotinjaRepository;
        public PasminaZivotinjeService()
        {
            ZivotinjaRepository = new ZivotinjaRepository();
        }


        public List<PasminaZivotinje> GetAll()
        {
            return ZivotinjaRepository.GetAllPasminaZivotinje();
        }
        public bool Add(PasminaZivotinje PasminaZivotinje)
        {
            try
            {
                ISession session = NHibernateHelper.CurrentSession;

                using (var transaction = session.BeginTransaction())
                {
                    ZivotinjaRepository.AddPasminaZivotinje(PasminaZivotinje);

                    transaction.Commit();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public PasminaZivotinje GetById(int Id)
        {
            return ZivotinjaRepository.GetPasminaZivotinjeById(Id);

        }
        public bool Delete(int Id)
        {
            try
            {
                ISession session = NHibernateHelper.CurrentSession;

                using (var transaction = session.BeginTransaction())
                {
                    ZivotinjaRepository.DeletePasminaZivotinje(Id);

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

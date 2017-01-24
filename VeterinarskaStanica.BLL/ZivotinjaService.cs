using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
